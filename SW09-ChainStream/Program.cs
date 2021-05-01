using System;
using System.IO;
using System.IO.Compression;

namespace SW09_ChainStream {
    class Program {

        static string file = "C:\\tmp\\encrypted_text.bin";

        static void Main(string[] args) {

            string str = "Hello World";

            FileStream f = new FileStream(file, FileMode.Create);
            GZipStream gz = new GZipStream(f, CompressionMode.Compress);
            BinaryWriter bn = new BinaryWriter(gz);

            bn.Write(str);

            f.Close();

            FileStream fin = new FileStream(file, FileMode.Create);
            GZipStream gzin = new GZipStream(fin, CompressionMode.Decompress);
            BinaryReader bnin = new BinaryReader(gzin);

            Console.WriteLine(bnin.ReadString());


        }
    }
}