using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCode
{
    class CustomClass
    {
        public int this[string index]
        {
            get
            {
                return int.Parse(index);
            }
            set
            {
                Console.WriteLine(index + " " + value);
            }
        }
    }
}
