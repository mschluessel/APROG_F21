using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList {
    class GenericList<T> {
        private object[] data;

        public int Capacity { get { return data.Length; } }
        public int Count { get; private set; }

        public GenericList(int capacity) {
            data = new T[capacity];
            Count = 0;
        }

        public void Add(T elem) {
            return data[Count++] = elem;
        }

        public T this[int idx] {

        }
    }
}
