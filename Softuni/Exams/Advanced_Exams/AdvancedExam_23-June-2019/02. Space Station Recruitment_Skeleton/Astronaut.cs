using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        private string name;
        private int age;
        private string country;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }

        public Astronaut(string name, int age, string country)
        {
            this.name = name;
            this.age = age;
            this.country = country;
        }

        public override string ToString()
        {
            return $"Astronaut: {name}, {age} ({country})";
        }
    }
}
