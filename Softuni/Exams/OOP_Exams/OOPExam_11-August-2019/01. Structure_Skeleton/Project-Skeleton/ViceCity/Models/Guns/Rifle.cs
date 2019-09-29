using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    class Rifle : Gun
    {
        private const int bulletsPerBarrel = 50;
        private const int totalBullets = 500;
        private int currentBulletsInBarrel;

        public Rifle(string name)
            : base(name, bulletsPerBarrel, totalBullets)
        {
            this.currentBulletsInBarrel = bulletsPerBarrel;
        }

        public override int Fire()
        {
            int shotedShots = 5;


            if (currentBulletsInBarrel - shotedShots <= 0)
            {
                shotedShots = currentBulletsInBarrel;
                currentBulletsInBarrel = BulletsPerBarrel;
            }
            else
            {
                currentBulletsInBarrel -= shotedShots;
            }

            this.TotalBullets -= shotedShots;
            return shotedShots;
        }
    }
}
