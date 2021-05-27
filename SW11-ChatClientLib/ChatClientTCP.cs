using ChatClientLib;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SW11_ChatClientLib {
    public class ChatClientTCP : IChatClient {

        TcpClient tcpClient = new TcpClient();

        public ChatClientTCP(string hostname) {
            //start TCP connection
            tcpClient.Connect(hostname, 5555);

            //start thread to check incomming messages form server
            Thread t = new Thread(Run);
            t.Start();
        }

        public void Run() {
            while (true) {
                NetworkStream networkstream = tcpClient.GetStream();
                StreamReader sr = new StreamReader(networkstream);
                StreamWriter sw = new StreamWriter(networkstream);
            }
        }

        public event EventHandler<MessageReceivedEventArgs> MessageReceived;
        public event EventHandler<UserUpdateEventArgs> UserUpdate;

        public void Disconnect() {
            throw new NotImplementedException();
        }

        public bool Login(string user) {
            return false;
        }

        public void SendMessage(string toUser, string message) {
            throw new NotImplementedException();
        }

    }
}
