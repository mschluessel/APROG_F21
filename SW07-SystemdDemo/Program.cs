using System;
using System.Threading;

namespace SW07_SystemdDemo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Start Service");
            for (int i = 0; i < 10; i++) {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine("Service End");
        }
    }
}