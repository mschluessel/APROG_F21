using System;
using System.IO;


// AUFGABE AUS APROG_Labs-SW10.pdf

namespace DelegateAppl {

    class PrintString {
        static FileStream fs;
        static StreamWriter sw;

        // delegate declaration
        public delegate void printStringDelegate(string s);

        // this method prints to the console
        public static void WriteToScreen(string str) {
            Console.WriteLine("The String is: {0}", str);
        }

        // this method prints to a file
        public static void WriteToFile(string s) {
            fs = new FileStream("message.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void sendString(printStringDelegate ps) {
            ps("Hello World");
        }

        static void Main(string[] args) {

            // printStringDelegate ps1 = new printStringDelegate(WriteToScreen);
            // printStringDelegate ps2 = new printStringDelegate(WriteToFile);
            printStringDelegate ps1 = WriteToScreen;
            printStringDelegate ps2 = WriteToFile;

            sendString(ps1);
            sendString(ps2);
        }
    } // end class PrintString
} // end namespace
