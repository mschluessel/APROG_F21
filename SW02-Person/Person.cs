using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW02_Person {
    class Person {

        #region members
        private string firstName;
        private string lastName;
        private int age;
        private Gender gender;
        #endregion

        #region constructor
        public Person(string first, string last, int age, Gender gen) {
            firstName = first;
            lastName = last;
            this.age = age;
            gender = gen;
        }

        public Person(string first, string last, Gender gen) : this(first, last, -1, gen) { }
        #endregion

        public void Print() {
            Console.WriteLine($"{firstName} {lastName}");
        }

        static string[] salutation = new string[] { "Mister", "Miss", "Unknown Salutation" };

        public void Print( bool withSalutation)
        {
            if( withSalutation && age >= 16)
            {
                Console.WriteLine(salutation[(int)gender] + " ");
            }
            Print();
        }

        public void IncrementAge() {
            age++;
            Console.WriteLine("Happy Birthday!");
        }

    }
}
