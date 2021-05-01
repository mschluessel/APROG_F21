using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SW09_UDPServer {
    class Program {
        static void Main(string[] args) {

            IPEndPoint epRemote = new IPEndPoint(IPAddress.Any, 1234);
            UdpClient udpClient = new UdpClient(epRemote);

            Console.WriteLine("Waiting for a client ...");
            byte[] data = udpClient.Receive(ref epRemote);

            Console.WriteLine($"Message received from {epRemote}: ");
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));

            udpClient.Close();
        }
    }
}
