using System;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;
using System.Threading;


namespace Testat_Game {
    class Program {
        static void Main(string[] args) {

            Pi.Init<BootstrapWiringPi>();

            Console.WriteLine("Catch The BlinkyS");
            //Spiel infos


            LED led = new LED();
            HighscoreList hlist = new HighscoreList();
            

            int i = led.GetLED();
            Console.WriteLine($"LED: {i}");

            hlist.HighscoreAdd(2.454);
            hlist.HighscoreAdd(4.57);
            hlist.HighscoreAdd(1);
            hlist.HighscoreAdd(1.1);

            hlist.PrintHighscoreList();

            Thread.Sleep(5000);

            led.SetLEDOff();

            Console.WriteLine("Program END");

            




        }
    }
}