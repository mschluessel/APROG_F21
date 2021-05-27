using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClientLib
{
    public class UserUpdateEventArgs : EventArgs
    {
        public UserUpdateEventArgs(string[] users)
        {
            Users = users;
        }

        public string[] Users { get; }
    }
}
