using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int bulletsPerBarrel = 10;
        private const int totalBullets = 100;
        private int currentBulletsInBarrel;

        public Pistol(string name)
            : base(name, bulletsPerBarrel, totalBullets)
        {
            this.currentBulletsInBarrel = bulletsPerBarrel;
        }

        public override int Fire()
        {
            int shotedShots = 1;


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
