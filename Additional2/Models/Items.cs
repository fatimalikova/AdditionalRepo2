using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional2.Models
{
    internal class Items
    {
        public int Id
        {
            get
            {
                return ++_counter;
            }
            set
            {
                if (value > 0)
                {
                    _counter = value;
                }
            }
        }
        private static int _counter = 0;
        public string Name { get; set; }

        public Color Color { get; set; }
    }
}
