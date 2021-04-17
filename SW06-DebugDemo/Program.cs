using System;
using System.Threading;
using Utils;

namespace SW06_DebugDemo {
    class Program {
        static void Main(string[] args) {

            Util.WaitForDebugger();

            //Console.WriteLine("Waiting for Debugger...");
            ////Console.ReadKey();

            //while (!System.Diagnostics.Debugger.IsAttached) {
            //    Thread.Sleep(500);
            //    Console.Write(".");
            //}

            Console.WriteLine("Hello World!");
            for (int i = 0; i < 100; i++) {
                Thread.Sleep(1000);
                Console.Write(".");
            }
        }
    }
}