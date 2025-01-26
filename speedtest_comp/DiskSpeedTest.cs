using System;
using System.Diagnostics;
using System.IO;

namespace SpeedTestCLI
{
    public static class DiskSpeedTest
    {
        public static void Run()
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "disk_test_file.tmp");
            var sw = Stopwatch.StartNew();

            // Write to disk
            using (var fs = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024 * 1024];  // 1 MB
                for (int i = 0; i < 100; i++) // Write 100 MB
                {
                    fs.Write(buffer, 0, buffer.Length);
                }
            }

            // Read from disk
            using (var fs = new FileStream(tempFile, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024];
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }

            sw.Stop();
            Console.WriteLine($"Disk Speed Test completed in {sw.ElapsedMilliseconds} ms for 100 MB.");
            File.Delete(tempFile);  // Clean up
        }
    }
}
