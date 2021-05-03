using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;

namespace Testat_Game
{
    class LED
    {

        public LED()
        {

        }

        //Setzt die dazugehörigen BCM Pins
        public static int BCMRed = 21;
        static int BCMYellow = 20;
        static int BCMGreen = 16;
        static int BCMBlue = 12;

        //variable um die vorherig zufällig ausgewählte LED zu merken
        private int prevLed;

        //weisst GPIO der LED Farbe zu
        public IGpioPin ledRed = Pi.Gpio[BCMRed];
        public IGpioPin ledYellow = Pi.Gpio[BCMYellow];
        public IGpioPin ledGreen = Pi.Gpio[BCMGreen];
        public IGpioPin ledBlue = Pi.Gpio[BCMBlue];


        //Schaltet LED an, welche mit dem int mitgegeben wird
        private void SetLEDOn(int led)
        {


            switch (led)
            {
                case 1: ledYellow.PinMode = GpioPinDriveMode.Output; ledYellow.Write(true); break;
                case 2: ledGreen.PinMode = GpioPinDriveMode.Output; ledGreen.Write(true); break;
                case 3: ledBlue.PinMode = GpioPinDriveMode.Output; ledBlue.Write(true); break;
            }

        }

        //Schaltet alle LEDs ab
        public void SetLEDOff()
        {
            ledYellow.PinMode = GpioPinDriveMode.Output; ledYellow.Write(false);
            ledGreen.PinMode = GpioPinDriveMode.Output; ledGreen.Write(false);
            ledBlue.PinMode = GpioPinDriveMode.Output; ledBlue.Write(false);
        }

        //Gibt eine zufällige LED (als int) zurück
        public int GetLED()
        {

            //generate random number between 1 and 4 (1, 2 or 3)
            Random rand = new Random();
            int randNumber = rand.Next(1, 4);

            while (randNumber == prevLed)                   //wählt solange zufällig eine LED aus bis es nicht die gleiche ist wie zuvor
            {
                randNumber = rand.Next(1, 4);
            }

            prevLed = randNumber;                           //merkt sich die LED

            //set random choosen LED
            Console.WriteLine($"LED {randNumber} on");
            SetLEDOn(randNumber);


            return randNumber;
        }
    }
}
