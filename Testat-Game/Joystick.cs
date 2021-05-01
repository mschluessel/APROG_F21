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

        static int BCMPush = 26;
        static int BCMLeft = 6;
        static int BCMRight = 5;

        IGpioPin joystickPush = Pi.Gpio[BCMPush];
        IGpioPin joystickLeft = Pi.Gpio[BCMLeft];
        IGpioPin joystickRight = Pi.Gpio[BCMRight];

        public int GetJoystickPosition() {

            if (joystickLeft.Read()) {
                return 1;
            }

            if (joystickPush.Read()) {
                return 2;
            }

            if (joystickRight.Read()) {
                return 3;
            }

            return 0;
        }
    }
}
