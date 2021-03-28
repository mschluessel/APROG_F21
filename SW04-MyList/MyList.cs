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

        private Type type  = new object().GetType();


        #region Constructor
        public MyList(int Max_objects) {
            data = new object[Max_objects];
            index = 0;
        }

        public MyList(int Max_objects, Type type) {
            data = new object[Max_objects];
            index = 0;
            this.type = type;
        }
        #endregion

        public bool Add(object elem) {
            if (type != new object().GetType() && elem.GetType() != type) {
                return false;
            }
            if (index >= data.Length) {
                Console.WriteLine("List is full!");
                object[] newList = new object[Capacity + Capacity];
                Array.Copy(data, newList, data.Length);
                data = newList;
            }
            data[index++] = elem;
            return true;
        }

        public object Get(int idx) {
            if(idx > index) {
                Console.WriteLine("This index doesn't exist!");
            }
            return data[idx];
        }

    }
}
