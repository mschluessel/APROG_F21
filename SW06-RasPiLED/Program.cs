using System;
using System.Threading;
using System.IO;

namespace SW06_RasPiLED {
    class Program {
        static void Main(string[] args) {

            //Console.WriteLine("Waiting for Debugger");

            //while (!System.Diagnostics.Debugger.IsAttached) {
            //    Thread.Sleep(100);
            //    Console.Write(".");
            //}

            Console.WriteLine("Start LED");

            StreamWriter sw = new StreamWriter("/sys/class/leds/led0/trigger");
            sw.Write("none");
            sw.Flush();
            sw.Close();

            StreamWriter swbri = new StreamWriter("/sys/class/leds/led0/brightness");

            while (true) {
                swbri.Write("1");
                swbri.Flush();
                Thread.Sleep(500);
                swbri.Write("0");
                swbri.Flush();
                Thread.Sleep(500);

                if (Console.KeyAvailable) {
                    break;
                }
            }

            swbri.Close();

            sw = new StreamWriter("/sys/class/leds/led0/trigger");
            sw.Write("mmc0");
            sw.Flush();
            sw.Close();

            Console.WriteLine("Program END");

        }
    }
}
