using System;
using System.IO;

namespace SW09_TextReaderStream {
    class Program {
        static void Main(string[] args) {

            TextReader reader = File.OpenText("C:\\tmp\\src.txt");
            //string s = reader.ReadLine();
            //string s2 = reader.ReadLine();
            string s3 = reader.ReadToEnd();

            reader.Close();

            //Console.WriteLine(s);
            //Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
