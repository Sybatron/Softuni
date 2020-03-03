using System;
using System.Collections.Generic;
using System.Text;

namespace P05GenericCountMethodStrings
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

        public bool IsGreater(T compareValue)
        {
            if (this.value.ToString().Length > compareValue.ToString().Length
                || (this.value.ToString().CompareTo(compareValue.ToString()) == 1))
            {
                return true;
            }
            return false;
        }
    }
}
