using System;
using System.Diagnostics;

namespace SpeedTestCLI
{
    public static class RamSpeedTest
    {
        public static void Run()
        {
            var sw = Stopwatch.StartNew();
            int sizeInMb = 1024;  // Size of the array in MB
            byte[] data = new byte[sizeInMb * 1024 * 1024];

            // Perform a RAM write operation
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(i % 256);
            }

            sw.Stop();
            Console.WriteLine($"RAM Speed Test completed in {sw.ElapsedMilliseconds} ms for {sizeInMb} MB of data.");
        }
    }
}
