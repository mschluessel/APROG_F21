using System;

namespace SW06_Exceptions {
    class Program {
        static void Main(string[] args) {
            int number = 0;

            while (true) {
                try {
                    Console.WriteLine("Enter a positive Number");
                    number = int.Parse(Console.ReadLine());
                    if (number < 0) {
                        throw new ArgumentOutOfRangeException($"{number} is not positive");
                    }
                    Console.WriteLine("It worked.");
                    break;
                }
                catch (OverflowException e) {
                    Console.WriteLine("Something went wrong.");
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Try again.");
                }
                catch (FormatException e) {
                    Console.WriteLine("Something went wrong.");
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Try again.");
                }

                Console.WriteLine($"Number is: {number}");
                Console.WriteLine("Program End");
            }
        }
    }
}
