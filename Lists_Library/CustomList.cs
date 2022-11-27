using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Library
{
    public class CustomList<T>
    {
        const int initialCapacity = 1;

        T[] _customList;
        int _size;

        public CustomList(int capacity = initialCapacity)
        {
            _customList = new T[capacity];
        }

        public int Count()
        {
            return _size;
        }

        public int Capacity
        {
            get
            {
                return _customList.Length;
            }
            set
            {
                if(value < _size)
                {
                    value = _size;
                }

                if (value != _customList.Length)
                {
                    T[] newElements = new T[value];
                    Array.Copy(_customList, 0, newElements, 0, _size);
                    _customList = newElements;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                return _customList[index];
            }
            set
            {
                _customList[index] = value;
            }
        }

        public void AddItem(T item)
        {
            if(_size == Capacity)
            {
                Capacity = _size + 1;
            }

            _customList[_size] = item;
            _size++;
        }
    }
}
