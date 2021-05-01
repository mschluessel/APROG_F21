using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SW09_UDPClient {
    class Program {
        static void Main(string[] args) {

            UdpClient udpClient = new UdpClient();

            udpClient.Connect("eee-01167.simple.eee.intern", 1234);

            while (true) {
                byte[] data = Encoding.ASCII.GetBytes("Hello");
                udpClient.Send(data, data.Length);
                Thread.Sleep(1000);
            }

            udpClient.Close();

        }
    }
}
