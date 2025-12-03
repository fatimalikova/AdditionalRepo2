using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional2
{
    internal class MyIntList
    {

        private int[] _items;

        public MyIntList()
        {
            _items = new int[0];
        }

        public void Add(int item)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = item;

        }

        public int Count { get { return _items.Length; } }
        public void Clear()
        {
            _items = new int[0];
        }

        public void GetAll()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public int Get(int index)
        {
            if (index < 0 || index >= _items.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return _items[index];
        }
    }
}
