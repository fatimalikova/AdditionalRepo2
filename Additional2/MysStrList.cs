using Additional2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional2
{
    internal class MyList<T,U>
      // where T : class
      // where T : struct
      // where T : new() // T must have a parameterless constructor
      // where T : IComparable<T> // T must implement IComparable<T>
      // where T : BaseEntity
      // where T : U
      where T : class, U, new()
    {

        private T[] _items;

        public MyList()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = item;

        }

        public int Count { get { return _items.Length; } }
        public void Clear()
        {
            _items = new T[0];
        }

        public void GetAll()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return _items[index];
        }
    }
}
