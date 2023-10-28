using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_Generics_practice.Helpers
{
    internal class Intlist
    {

        private int[] _ints;

        public Intlist() 
        {
            _ints = new int[0];
        }


        public void Add(int item) 
        {
            Array.Resize(ref _ints, _ints.Length + 1);
            _ints[_ints.Length - 1] = item;
        }

        public void GetAll()
        {
            foreach(var item in _ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
