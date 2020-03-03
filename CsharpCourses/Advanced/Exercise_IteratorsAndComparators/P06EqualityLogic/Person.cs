using System;
using System.Collections.Generic;
using System.Text;

namespace P06EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;

        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            if (this.name != other.name)
            {
                return this.name.CompareTo(other.name);
            }

            if (this.age != other.age)
            {
                return this.age.CompareTo(other.age);
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            return this.name == ((Person)obj).name && this.age == ((Person)obj).age;
        }

        public override int GetHashCode()
        {
            return (this.age+(457* 43)) * this.name.GetHashCode();
        }
    }
}
