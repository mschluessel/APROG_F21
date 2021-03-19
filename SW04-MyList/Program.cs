using System;

namespace SW04_MyList {
    class Program {
        static void Main(string[] args) {

            MyList List1 = new MyList(10);

            List1.Add(1);
            List1.Add(2);
            List1.Add("Drei");
            List1.Add(4.44);

            for (int i = 0; i < 4; i++) {
                Console.WriteLine($" Element {i} : {List1.Get(i)}");
            }

            int elem0 = (int)List1.Get(1);

            Console.WriteLine(elem0);

        }
    }
}
