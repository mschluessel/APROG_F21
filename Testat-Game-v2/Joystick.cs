using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;

namespace Testat_Game {
    class Joystick {

        public Joystick() {

        }

        //Setzt die dazugehörigen BCM Pins
        static int BCMPush = 26;
        static int BCMLeft = 6;
        static int BCMRight = 5;

        //weisst GPIO der jostickaktion zu
        public IGpioPin joystickPush = Pi.Gpio[BCMPush];
        public IGpioPin joystickLeft = Pi.Gpio[BCMLeft];
        public IGpioPin joystickRight = Pi.Gpio[BCMRight];


        //Gibt die Joystick position zurück
        public int GetJoystickPosition() {

            if (joystickLeft.Read() == false) {
                return 1;
            }

            if (joystickPush.Read() == false) {
                return 2;
            }

            if (joystickRight.Read() == false) {
                return 3;
            }

            return 0;
        }
    }
}
