using System;
using System.Diagnostics;

namespace SpeedTestCLI
{
    public static class CpuSpeedTest
    {
        public static void Run()
        {
            var sw = Stopwatch.StartNew();
            int iterations = 1000000;
            double result = 0;

            // Simple CPU intensive task (calculation)
            for (int i = 0; i < iterations; i++)
            {
                result += Math.Sqrt(i);
            }

            sw.Stop();
            Console.WriteLine($"CPU Speed Test completed in {sw.ElapsedMilliseconds} ms for {iterations} iterations.");
            Console.WriteLine($"Result: {result}");
        }
    }
}
