using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW03_Person {
    class Person {

        #region members
        private string firstName;
        private string lastName;
        public int Age { get; set; }
        private Gender gender;
        #endregion

        #region constructor
        public Person(string first, string last, int age, Gender gen) {
            firstName = first;
            lastName = last;
            this.Age = age;
            gender = gen;
        }

        public Person(string first, string last, Gender gen) : this(first, last, -1, gen) { }
        #endregion

        public Adress Adress { get; set; }

        //public int Age {
        //    get { return age; }
        //    set { age = value; }
        //}

        public void Print() {
            Console.WriteLine($"{firstName} {lastName}");
            Adress.Print();
        }

        static string[] salutation = new string[] { "Mister", "Miss", "Unknown Salutation" };

        public void Print(bool withSalutation) {
            if (withSalutation && Age >= 16) {
                Console.WriteLine(salutation[(int)gender] + " ");
            }
            Print();
        }

        public void IncrementAge() {
            Age++;
            Console.WriteLine("Happy Birthday!");
        }

        public bool IsOlder(Person other) {
            return this.Age > other.Age;
        }

    }
}
