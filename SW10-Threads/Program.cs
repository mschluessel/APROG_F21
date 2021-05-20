using System;
using System.Threading;

namespace SW10_Threads {
    class Program {

        public static bool doRun;

        static void Main(string[] args) {

            Console.WriteLine("Main started");

            static void Run() {

                Console.WriteLine("Thread 1 started");
                for (int i = 0; i < 5; i++) {
                    Thread.Sleep(500);
                    Console.WriteLine("Thread 1 is running");
                }
                Console.WriteLine("Thread 1 END");

            }
            static void Run2() {

                Console.WriteLine("Thread 2 started");
                for (int i = 0; i < 5; i++) {
                    Thread.Sleep(500);
                    Console.WriteLine("Thread 2 is running");
                }
                Console.WriteLine("Thread 2 END");

            }

            static void Run3() {

                doRun = true;

                Console.WriteLine("Thread 3 started");
                for (int i = 0; i < 5; i++) {
                    Thread.Sleep(500);
                    Console.WriteLine("Thread 3 is running");
                    if (!doRun) break;
                }
                Console.WriteLine("Thread 3 END");

            }

            Thread t1 = new Thread(new ThreadStart(Run));
            Thread t2 = new Thread(new ThreadStart(Run2));
            Thread t3 = new Thread(new ThreadStart(Run3));

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            Thread.Sleep(1337);
            doRun = false;
            

            Console.WriteLine("Main END");
        }
    }
}
