using System;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;
using System.Threading;
using Utils;

namespace Testat_Game {
    public class CatchTheBlinkys {

        public void PlayBlinky() {

            //Init GPIO
            Pi.Init<BootstrapWiringPi>();

            //Objecte erstellen
            HighscoreList hlist = new HighscoreList();
            LED led = new LED();
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            Joystick joyStick = new Joystick();


            Console.WriteLine("------------------------");
            Console.WriteLine("Catch The BlinkyS");
            Console.WriteLine("------------------------\n\n");

            //Spiel infos
            Console.WriteLine("Reagiere möglist schnell und bewege den Joystick in die richtige Richtung ");
            Console.WriteLine("LED2 (Gelb) = Joystick nach links");
            Console.WriteLine("LED3 (Grün) = Joystick drücken");
            Console.WriteLine("LED4 (Blau) = Joystick nach rechts");
            Console.WriteLine("Die LED1 (Rot) gibt dir ein 3 Sekunden Countdown wenn das Spiel beginnt");

            while (true) //Solange true bis nicht weiter gespielt werden will
            {
                Console.WriteLine("\nBist du bereit? press enter");

                while (Console.ReadKey().Key != ConsoleKey.Enter) {
                    Thread.Sleep(100);
                }

                Console.WriteLine();

                //Start Countdown
                for (int i = 0; i < 3; i++) {
                    Thread.Sleep(400);
                    led.ledRed.PinMode = GpioPinDriveMode.Output;
                    led.ledRed.Write(true);
                    Thread.Sleep(600);
                    led.ledRed.Write(false);
                }

                //GPIO drive mode setzen
                joyStick.joystickPush.PinMode = GpioPinDriveMode.Input;
                joyStick.joystickLeft.PinMode = GpioPinDriveMode.Input;
                joyStick.joystickRight.PinMode = GpioPinDriveMode.Input;

                s.Reset();  //Reset Zeitmessung

                s.Start();  //Start Zeitmessung


                //Lässt zufällig 10 mal eine LED blinken
                for (int i = 0; i < 10; i++) {
                    int n = led.GetLED();
                    int j = joyStick.GetJoystickPosition();

                    while (n != j)                              //Überprüft ob Joystickposition mit dem LED übereinstimmt
                    {
                        j = joyStick.GetJoystickPosition();
                    }

                    led.SetLEDOff();

                }

                s.Stop();                                       //Stop Zeitmessung
                TimeSpan timeSpan = s.Elapsed;                  //Differenz berechnen
                Console.WriteLine($"\nTime: {timeSpan.Seconds}s {timeSpan.Milliseconds}ms\n");

                //hlist.CheckHighscore(timeSpan);
                hlist.HighscoreAdd(timeSpan);

                //Highscoreliste ausgeben
                hlist.PrintHighscoreList();

                //nochmals Spielen
                Console.WriteLine("\nNochmals spielen? J/n");

                //Beendet Programm, wenn nicht mehr gespielt werden will
                if (Console.ReadKey().Key == ConsoleKey.N) {
                    return;
                }

            }
        }
    }
}
