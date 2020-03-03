using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;

        private int bulletsPerBarrel;

        private int totalBullets;

        //o The initial BulletsPerBarrel count is the actual capacity of the barrel!
        //•	CanFire – calculated property, which returns bool
        public bool CanFire => totalBullets > 0;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Name cannot be null or a white space!");
                }
                name = value;
            }
        }

        public int BulletsPerBarrel
        {
            get
            {
                return bulletsPerBarrel;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Bullets cannot be below zero!");
                }
                bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get
            {
                return totalBullets;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Total bullets cannot be below zero!");
                }
                totalBullets = value;
            }
        }

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
        }

        public abstract int Fire();


    }
}
