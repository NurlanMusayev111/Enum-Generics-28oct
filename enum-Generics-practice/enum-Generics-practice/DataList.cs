using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_Generics_practice
{
    internal class DataList<T> where T : class
    {

        private T[] _datas;
        public DataList()
        {
            _datas = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length] = item;
        }

        public T[] GetAll()
        {
            //foreach (var item in _datas) 
            //{
            //    Console.WriteLine(item);
            //}

            return _datas;  
        }
    }
}
