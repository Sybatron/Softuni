using System;
using System.Collections.Generic;
using System.Text;

namespace P01GenericBoxOfString
{
    public class Box<T>
    {
        T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value.GetType()}: {value}";
        }
    }
}
