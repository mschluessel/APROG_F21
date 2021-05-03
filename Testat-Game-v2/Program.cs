using System;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;
using System.Threading;
using Utils;


namespace Testat_Game {
    class Program {
        static void Main(string[] args) {

            //Wait for debugger
            Util.WaitForDebugger();

            CatchTheBlinkys CTB = new CatchTheBlinkys();

            bool i = true;

            while (i) {

                Console.WriteLine("Welches Spiel möchtest du Spielen? Gib die entsprechende Zahl an.");
                Console.WriteLine("Um das Programm zu beenden drücke q");
                Console.WriteLine();
                Console.WriteLine("1. Catch the BlinkyS");
                Console.WriteLine("...More following soon");
                Console.WriteLine();

                string input = Console.ReadLine();

                switch (input) {
                    case "1": CTB.PlayBlinky(); break;
                    case "q": i = false;  break; 
                    default: Console.WriteLine("Dieses Spiel gibt es nicht"); break;

                }

            }

            Console.WriteLine("\nProgram END");






        }
    }
}