using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW06_Person {
    class Person {

        string first;
        string last;
        Salutation salutation;

        int count = 0;

        static string[] salutations = { "Dear Ms", "Dear Mr", "Dear Mx" };
        // spanish: "Estimada señora", "Estimado señor", "Saludos,"

        public Person( string first, string last, Salutation salutation) {
            this.first = first;
            this.last = last;
            this.salutation = salutation;
            count++;
            Console.WriteLine($"Created instance of class Person.");
        }
      
        public void Print() {
            Console.Write( $"{salutations[(int)salutation]} " );
            Console.WriteLine( $"{first} {last}" );
        }

        public void LanguageToSpanish() {
            // TBD
        }
    }
}
