using System;
using System.IO;

namespace SW09_StreamFileCopy {
    class Program {
        static void Main(string[] args) {

            FileStream fsOut = new FileStream("C:\\tmp\\Test.zip", FileMode.Create);
            FileStream fsIn = new FileStream("C:\\tmp\\Test-Copy.zip", FileMode.Open);

            int data = fsIn.ReadByte();
            while (data >= 0) {
                fsOut.WriteByte((byte)data);
                data = fsIn.ReadByte();
            }

            fsOut.Close();
            fsIn.Close();

            Console.WriteLine(data);

        }
    }
}
