using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;

        public bool IsAlive => LifePoints == 0;
        //•	GunRepository - IRepository<Gun>
        //o   Generic repository of all player's guns
        public IRepository<IGun> GunRepository { get; set; }

        private int lifePoints;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), $"Player's name cannot be null or a whitespace");
                }
                name = value;
            }
        }

        public int LifePoints
        {
            get
            {
                return lifePoints;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Player life points cannot be below zero!");
                }
                lifePoints = value;
            }
        }

        public Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;

        }

        public void TakeLifePoints(int points)
        {
            if (LifePoints - points < 0)
            {
                LifePoints = 0;
            }
            else
            {
                LifePoints -= points;
            }
        }
    }
}
