using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW03_Person {
    class Adress {

        public string Street { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }

        public Adress(string street, int zip, string city) {
            Street = street;
            Zip = zip;
            City = city;
        }

        public void Print() {
            Console.WriteLine($"Adress: {Street}, {Zip} {City}");
        }
    }
}
