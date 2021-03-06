using System;

namespace SW01_Adder {
    class Program {
        static void Main(string[] args) {

            if(args.Length < 2) {
                Console.WriteLine("Nothing to add. Please pass two or more arguments.");
                return;
            }

            int sum = 0;

            Console.WriteLine("############################################################");
            Console.WriteLine("Simple Calculator to add numbers passed on the command line.");
            Console.WriteLine("############################################################");
            Console.WriteLine();

            //convert args to int
            foreach(string s in args) {
                int summand = Convert.ToInt32(s);
                sum += summand;
            }

            //print result
            for(int i = 0; i < args.Length; i++) {
                if(Convert.ToInt32(args[i]) < 0) {
                    Console.Write($"({args[i]}) ");
                }
                else {
                    Console.Write($"{args[i]} ");
                }
                if(i < args.Length - 1) {
                    Console.Write("+ ");
                }
            }

            Console.Write($"= {sum}\n");
        }
    }
}
