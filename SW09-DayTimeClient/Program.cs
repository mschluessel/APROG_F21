using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SW09_DayTimeClient {
    class Program {
        static void Main(string[] args) {

            //for (int i = 0; i < 3; i++) {
            while (true) {

                TcpClient tcpClient = new TcpClient();
                //tcpClient.Connect("eee-00143.simple.eee.intern", 13);
                tcpClient.Connect("eee-01169.simple.eee.intern", 13);
                //tcpClient.Connect("time-a-b.nist.gov", 13);
                //tcpClient.Connect("time-c-b.nist.gov", 13);



                NetworkStream networkStream = tcpClient.GetStream();



                StreamReader sr = new StreamReader(networkStream);
                StreamWriter sw = new StreamWriter(networkStream);


                string s = sr.ReadToEnd();

                Console.WriteLine("Output: ");
                Console.WriteLine(s);

                sw.WriteLine("Nöööööööö");

                //Thread.Sleep(500);


                tcpClient.Close();

            }

        }
    }
}