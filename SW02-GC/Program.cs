using System;

namespace SW02_GC {
    class Program {

        static void GC_test() {
            Console.WriteLine($"Used memory: {GC.GetTotalMemory(false)/1024} KBytes");
        }

        static void Main(string[] args) {

            GC_test();

            int[][] jaggedArray = new int[20][];

            GC_test();

            for(int i = 0; i < jaggedArray.Length; i++) {
                jaggedArray[i] = new int[1024 * 1024];
                GC_test();
            }

            GC.Collect();
            Console.WriteLine("GCcolltec");

            GC_test();

            Console.ReadLine();

            Console.WriteLine("Set array-reference to null");
            jaggedArray = null;

            GC.Collect();
            Console.WriteLine("GCcolltec");

            GC_test();

            GC.Collect();

            Console.ReadLine();

        }
    }
}
