using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_Generics_practice
{
    internal class Person : BaseEntity
    {
        private object value1;
        private object value2;
        private object value3;

        public Person(object value1, object value2, object value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        
    }
}
