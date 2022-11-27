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

        T[] _elements;
        int _size;

        public CustomList(int capacity = initialCapacity)
        {
            _elements= new T[capacity];
        }

        public int Count()
        {
            return _size;
        }

        public int Capacity
        {
            get
            {
                return _elements.Length;
            }
            set
            {
                if(value < _size)
                {
                    value = _size;
                }

                if (value != _elements.Length)
                {
                    T[] newElements = new T[value];
                    Array.Copy(_elements, 0, newElements, 0, _size);
                    _elements = newElements;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                return _elements[index];
            }
            set
            {
                _elements[index] = value;
            }
        }

        public void AddItem(T item)
        {
            if(_size == Capacity)
            {
                Capacity = _size + 1;
            }

            _elements[_size] = item;
            _size++;
        }
    }
}
