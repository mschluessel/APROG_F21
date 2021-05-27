using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClientLib
{
    public class MessageReceivedEventArgs : EventArgs
    {

        public MessageReceivedEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
