using System;

namespace SW04_Enviroment {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"Current Directory....: {Environment.CurrentDirectory}");

            Console.WriteLine($"Is 64 Bit OS.........: {Environment.Is64BitOperatingSystem}");

            Console.WriteLine($"OS Version...........: {Environment.OSVersion.ToString()}");

            Console.WriteLine($"Processor Count......: {Environment.ProcessorCount}");

            int result = (Environment.TickCount & Int32.MaxValue)/60000;
            Console.WriteLine($"Runtime in miuntes...: {result}");

            Console.WriteLine($"Current User.........: {Environment.UserName}");

            Console.WriteLine($"Thread ID............: {Environment.CurrentManagedThreadId}");

            Console.WriteLine($"CLR Version..........: {Environment.Version}");

            string[] drives = Environment.GetLogicalDrives();
            Console.WriteLine($"Logical Drives.......: {String.Join(" ", drives)}");

            Console.WriteLine();
            Console.WriteLine($"Value of enviroment Variable PROCESSOR_IDENTIFIER:");
            Console.WriteLine(Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
        }
    }
}
