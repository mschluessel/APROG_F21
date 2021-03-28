using System;

namespace GenericList {
    class Program {
        static void Main(string[] args) {
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            GenericList<string> list2 = new GenericList<string>();
            list2.Add("This is a generic list");


        }
    }
}
