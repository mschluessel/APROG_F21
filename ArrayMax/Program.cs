using System;

namespace ArrayMax {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("#########");
            Console.WriteLine("Max Array");
            Console.WriteLine("#########");
            Console.WriteLine();

            int compare = 0;

            //input for size of array
            Console.WriteLine("Please enter the size of the array:");
            string size_str = Console.ReadLine();
            if(size_str == null) {
                Console.WriteLine("Please enter a number");
                return;
            }

            int.TryParse(size_str, out int size);

            if(size <= 0) {
                Console.WriteLine("Nothing to do.");
                return;
            }

            //create array
            int[] array = new int[size];
            Console.WriteLine($"Size of array is {size}");

            //fill array
            int counter = 0;
            do {
                Console.WriteLine($"Input value to store in array at index {counter}:");
                array[counter] = Convert.ToInt32(Console.ReadLine());
                counter++;
            } while(counter < size);

            //print content from array and evaluate greatest value
            Console.Write("[ ");
            foreach(int i in array) {
                Console.Write(i + " ");
                if(Convert.ToInt32(i) > compare) {
                    compare = Convert.ToInt32(i);
                }
            }
            Console.WriteLine("]");

            //print greatest value
            Console.WriteLine($"The largest value is {compare}");
        }
    }
}
