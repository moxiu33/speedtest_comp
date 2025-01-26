using System;
using System.Diagnostics;

namespace SpeedTestCLI
{
    public static class NetworkSpeedTest
    {
        public static void Run()
        {
            string server = "google.com";  // Can be any reliable server
            int pings = 10;
            double totalTime = 0;

            var ping = new System.Net.NetworkInformation.Ping();

            for (int i = 0; i < pings; i++)
            {
                try
                {
                    var reply = ping.Send(server);
                    if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                    {
                        totalTime += reply.RoundtripTime;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Network test failed.");
                    return;
                }
            }

            double averagePing = totalTime / pings;
            Console.WriteLine($"Network Speed Test completed. Average ping to {server}: {averagePing} ms.");
        }
    }
}
