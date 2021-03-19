using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW04_MyList {
    class MyList {

        #region Members
        private object[] data;
        private int index;
        #endregion

        #region Properties
        public int Capacity { get { return data.Length;  } }
        public int Count { get; set; }
        #endregion

        #region Constructor
        public MyList(int Max_objects) {
            data = new object[Max_objects];
            index = 0;
        }
        #endregion

        public void Add(object elem) {
            if (index >= data.Length) {
                Console.WriteLine("List is full!");
                object[] newList = new object[Capacity + Capacity];
                Array.Copy(newList, data, data.Length);
                data = newList;
                return;
            }
            data[index++] = elem;
            return;
        }

        public object Get(int idx) {
            if(idx > index) {
                Console.WriteLine("This index doesn't exist!");
            }
            return data[idx];
        }

    }
}
