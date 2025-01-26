using System;

namespace SpeedTestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Speed Test Tool");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Run CPU Speed Test");
                Console.WriteLine("2. Run RAM Speed Test");
                Console.WriteLine("3. Run Disk Speed Test");
                Console.WriteLine("4. Run Network Speed Test");
                Console.WriteLine("5. Exit");

                string? input = Console.ReadLine();  // Declared as nullable

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nRunning CPU Speed Test...");
                        CpuSpeedTest.Run();
                        break;
                    case "2":
                        Console.WriteLine("\nRunning RAM Speed Test...");
                        RamSpeedTest.Run();
                        break;
                    case "3":
                        Console.WriteLine("\nRunning Disk Speed Test...");
                        DiskSpeedTest.Run();
                        break;
                    case "4":
                        Console.WriteLine("\nRunning Network Speed Test...");
                        NetworkSpeedTest.Run();
                        break;
                    case "5":
                        Console.WriteLine("\nExiting...");
                        return;
                    default:
                        Console.WriteLine("\nInvalid option, please try again.");
                        break;
                }

                // Wait for the user to press a key to continue or return to menu
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}
