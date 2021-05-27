using System;
using System.IO.Ports;

namespace SW12_SerialDemo {
    class Program {
        static void Main(string[] args) {

            SerialPort myPort = new SerialPort("/dev/ttyS0", 115200);
            myPort.Open();
            if (!myPort.IsOpen) {
                Console.WriteLine("Error opening serial port");
                return;
            }

            Console.WriteLine("Port open");

            if (myPort == null) {
                Console.WriteLine("No serial port 7dev/ttyS0");
                return;
            }

            myPort.NewLine = "\r\n";

            while (!Console.KeyAvailable) {
                try {
                    string readed = myPort.ReadLine();
                    myPort.WriteLine(readed);
                    Console.WriteLine(readed);
                }
                catch (Exception ex) {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

        }
    }
}