using System;
using System.Threading;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;
using Utils;

namespace SW07_GPIO {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("RasPi is ready");


            //Util.WaitForDebugger();

            Console.WriteLine("Start GPIO Program");

            Pi.Init<BootstrapWiringPi>();
            Console.WriteLine("Init GPIO");
            Console.WriteLine();
            Console.WriteLine("Signal           Raspi Pin   GPIO       BCIM");
            Console.WriteLine("--------------------------------------------");

            IGpioPin ledBlue = Pi.Gpio[12];                     //Wert für Pin wird direkt angegeben
            IGpioPin ledRed = Pi.Gpio[21];
            //IGpioPin led = Pi.Gpio[BcmPin.Gpio12];        //Wert für Pin wird über GPIO bezeichnung übergeben
            ledBlue.PinMode = GpioPinDriveMode.Output;
            ledRed.PinMode = GpioPinDriveMode.Output;
            Console.WriteLine("BLUE LED         PIN 32      GPIO 26    12");
            Console.WriteLine("BLUE RED         PIN 40      GPIO 29    21");

            ledRed.Write(true);

            //for (int i = 0; i < 2; i++) {
            //    led.Write(true);
            //    Thread.Sleep(1000);
            //    led.Write(false);
            //    Thread.Sleep(1000);
            //}

            IGpioPin buttonPin = Pi.Gpio[26];
            Console.WriteLine("JOYSTICK PUSH    PIN 37      GPIO 25    26");
            buttonPin.PinMode = GpioPinDriveMode.Input;
            buttonPin.InputPullMode = GpioPinResistorPullMode.PullUp;
            bool state = buttonPin.Read();

            Console.WriteLine();
            Console.WriteLine("Push the Joystick button to light the blue LED (D4)");
            while (true) {
                state = buttonPin.Read();
                ledBlue.Write(!state);
            }
        }
    }
}
