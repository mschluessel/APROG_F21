using System;

namespace SW02_Person {
    
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Person p = new Person("Marvin", "Schluessel", 22, Gender.Male);

            Person p2 = new Person("Hans", "Muster", 42, Gender.Other);

            //entfällt durch den Konstruktor
            //p.InitPerson("Marvin", "Schluessel", 22, Gender.Male);

            p.Print(true);

            p.IncrementAge();

            p.Print();

        }
    }
}
