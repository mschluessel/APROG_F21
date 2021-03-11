using System;

namespace SW03_Person
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Marvin", "Schluessel", 22, Gender.Male);

            Person p2 = new Person("Marie", "Muster", 42, Gender.Female);

            Adress a1 = new Adress("Dorfstrasse 3", 6000, "Luzern");

            p1.Adress = a1;
            p1.Print(true);

            p2.Adress = new Adress("Bahnhofplatz 5", 7000, "Chur");
            p2.Print();


            if (p2.IsOlder(p1)) {
                p2.Print(true);
                Console.WriteLine("is older than");
                p1.Print(true);
            }


            p1.Age = 33;
            //p1.Print();
            //Console.WriteLine($"Age: {p1.Age}");

            //p.Print(true);

            //p.IncrementAge();

            //p.Print();

        }
    }
}
