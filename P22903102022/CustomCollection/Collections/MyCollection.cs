using CustomCollection.Interfaces;
using CustomCollection.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Collections
{
    class MyCollection<T/*,U*/> : IEnumerable  /*where T : IMyinterface where U : T*/
    {
        T[] _arr;

        public int Count { get => _arr.Length; }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _arr.Length)
                {
                    throw new IndexOutOfRangeException("Gonderilen Index Deyeri Yanlisd");
                }

                return _arr[index];

            }
            set
            {
                if (index < 0 || index >= _arr.Length)
                {
                    throw new IndexOutOfRangeException("Gonderilen Index Deyeri Yanlisd");
                }

                _arr[index] = value;
            }
        }

        public MyCollection()
        {
            _arr = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public T Get(int index)
        {
            return _arr[index];
        }

        public IEnumerator GetEnumerator()
        {
            return _arr.GetEnumerator();
        }
    }
}
