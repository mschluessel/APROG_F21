using System;
using System.Collections.Generic;

namespace SW06_Person {
    class Program {
        static void Main( string[] args ) {

            List<Person> list = new List<Person>();
            list.Add( new Person( "Agatha", "Christie", Salutation.female ) );
            list.Add( new Person( "Pablo", "Picasso", Salutation.male ) );
            list.Add( new Person( "Miley", "Cyrus", Salutation.neutral ) );

            foreach( Person p in list ) {
                p.Print();
            }

            // switch language to Spanish and print again
            // LanguageToSpanish(); // <= implement this method in class Person

            foreach( Person p in list ) {
                p.Print();
            }


        }
    }
}
