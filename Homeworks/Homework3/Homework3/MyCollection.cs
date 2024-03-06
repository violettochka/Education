using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class MyCollection<T> : IEnumerable<T>
    {
        private T[] _items;
        public int Capacity { get => _items.Length; }
        public int Count { get; private set; }

        public MyCollection() 
        {
            int defaultCapacity = 8;
            _items = new T[defaultCapacity];
        }

        public void Add(T elem)
        {
            if (Count == Capacity)
            {
                T[] greaterItems = new T[_items.Length * 2];
                Array.Copy(greaterItems, _items, Count);
                _items = greaterItems;
            }
            _items[Count] = elem;
            Count++;
        }

        public T this[int index]
        {
            get 
            { 
                if(index > Capacity || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return _items[index]; 
            }
            set 
            {
                if (index > Capacity || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _items[index] = value;
                ++Count;
            }
        }

        public void Remove(T elem)
        {
            if (_items.Contains(elem))
            {
                _items = _items.Where(el => !Equals(el, elem)).ToArray();
            }
        }

        public int Search(T elem)
        {
            for(int i = 0; i < Capacity; i++)
            {
                if (Equals(elem, _items[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int elem  = 0; elem < Capacity; elem++)
            {
                yield return _items[elem];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
