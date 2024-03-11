using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryImplementation
{
    public class Dict<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private const int DEFAULT_SIZE = 32;
        LinkedList<KeyValuePair<TKey, TValue>>[] elems;
        public int Count { get; private set; }
        public int Capacity => elems.Length;
        public Dict()
        {
            elems = new LinkedList<KeyValuePair<TKey, TValue>>[DEFAULT_SIZE];
        }

        public void Add(TKey key, TValue value)
        {
            int hash = HashKey(key);

            if (elems[hash] == null)
            {
                elems[hash] = new LinkedList<KeyValuePair<TKey, TValue>>();

            }

            bool keyExists = elems[hash].Any(pair => pair.Key.Equals(key));
            if (keyExists)
            {
                throw new InvalidOperationException("This key already exists");
            }

            var pair = new KeyValuePair<TKey, TValue>(key, value);
            elems[hash].AddLast(pair);
            Count++;

            if (Count >= Capacity * 0.85)
            {
                ResizeAndReAdd();
            }
        }

        private void ResizeAndReAdd()
        {
            var cloneValues = elems;
            elems = new LinkedList<KeyValuePair<TKey, TValue>>[Capacity * 2];
            Count = 0;
            foreach (var collection in cloneValues)
            {
                if (collection != null)
                {
                    foreach (var pair in collection)
                    {
                        Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        public TValue Find(TKey key)
        {
            var hash = HashKey(key);
            if (elems[hash] == null)
            {
                return default(TValue);
            }
            var collection = elems[hash];

            return collection.SingleOrDefault(pair => pair.Key.Equals(key)).Value;

        }

        public bool Remove(TKey key)
        {
            var hash = HashKey(key);
            if (elems[hash] == null)
            {
                return false;
            }
            var ifExists = elems[hash].SingleOrDefault(pair => pair.Key.Equals(key));
            if (ifExists.Equals(null))
            {
                return false;
            }
            elems[hash].Remove(ifExists);
            Count--;

            return true;
        }

        public bool Contains(TKey key)
        {
            var hash = HashKey(key);
            if (elems[hash] == null)
            {
                return false;
            }
            var collection = elems[hash];

            return collection.Any(pair => pair.Key.Equals(key));
        }

        private int HashKey(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % Capacity;
        }


        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var collection in elems)
            {
                if (collection != null)
                {
                    foreach (var pair in collection)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

