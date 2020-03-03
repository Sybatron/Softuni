using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        private List<Astronaut> data;
        private string name;
        private int capacity;

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
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }
        public SpaceStation(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            data = new List<Astronaut>();
        }
        public void Add(Astronaut astronaut)
        {
            if (data.Count < capacity)
            {
                data.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == name)
                {
                    data.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public Astronaut GetOldestAstronaut()
        {
            var oldestIndex = -1;
            var currentAge = int.MinValue;

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Age > currentAge)
                {
                    currentAge = data[i].Age;
                    oldestIndex = i;
                }
            }
            if (oldestIndex != -1)
            {
                return data[oldestIndex];
            }
            return null;
        }
        public Astronaut GetAstronaut(string name)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == name)
                {
                    return data[i];
                }
            }
            return null;
        }
        public string Report()
        {
            var text = new StringBuilder();
            text.Append($"Astronauts working at Space Station {name}:{Environment.NewLine}");
            foreach (var astronaut in data)
            {
                text.Append($"{astronaut.ToString()}{Environment.NewLine}");
            }

            return text.ToString().TrimEnd();
        }

    }
}
