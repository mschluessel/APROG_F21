using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;

namespace Testat_Game {
    class LED {

        public LED() {

        }

        //static int BCMRed = 21;
        static int BCMYellow = 20;
        static int BCMGreen = 16;
        static int BCMBlue = 12;

        private int prevLed;

                        
        //IGpioPin ledRed = Pi.Gpio[BCMRed];
        IGpioPin ledYellow = Pi.Gpio[BCMYellow];
        IGpioPin ledGreen = Pi.Gpio[BCMGreen];
        IGpioPin ledBlue = Pi.Gpio[BCMBlue];


        private void SetLEDOn(int led) {


            switch (led) {
                case 1: ledYellow.PinMode = GpioPinDriveMode.Output; ledYellow.Write(true); break;
                case 2: ledGreen.PinMode = GpioPinDriveMode.Output; ledGreen.Write(true); break;
                case 3: ledBlue.PinMode = GpioPinDriveMode.Output; ledBlue.Write(true); Console.WriteLine($"LED {led} is on"); break;
                default: Console.WriteLine($"Something went wrong!! LED: {led}"); break;
            }

        }

        public void SetLEDOff() {
                ledYellow.PinMode = GpioPinDriveMode.Output; ledYellow.Write(false);
                ledGreen.PinMode = GpioPinDriveMode.Output; ledGreen.Write(false);
                ledBlue.PinMode = GpioPinDriveMode.Output; ledBlue.Write(false);
        }

        public int GetLED() {

            //generate random number between 1 and 4 (1, 2 or 3)
            Random rand = new Random();
            int randNumber = rand.Next(1, 4);
            randNumber = 3;

            //set random choosen LED
            Console.WriteLine($"LED {randNumber} on");
            SetLEDOn(randNumber);


            return randNumber;
        }
    }
}