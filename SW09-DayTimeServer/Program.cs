using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SW09_DayTimeServer {
    class Program {
        static void Main(string[] args) {

            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 13);
            TcpListener tcpListener = new TcpListener(iPEndPoint);

            tcpListener.Start();

            while (true) {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Console.WriteLine($"Client Connected: {tcpClient.Client.RemoteEndPoint}");

                NetworkStream networkStream = tcpClient.GetStream();
                StreamWriter sw = new StreamWriter(networkStream);

                string datetime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

                sw.WriteLine("Helloooooo");
                sw.WriteLine(datetime);

                for(int i = 0; i < 10; i++) {
                    sw.WriteLine("Looooooooooooop");
                }

                sw.Close();
                tcpClient.Close();
            }

        }
    }
}
