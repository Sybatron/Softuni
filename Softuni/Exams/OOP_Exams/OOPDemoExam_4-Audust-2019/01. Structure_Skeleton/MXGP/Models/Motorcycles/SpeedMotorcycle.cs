using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const double SpeedMotorcycleCubicCentimeters = 125;
        private int horsePower;

        private const int SpeedMotorcycleMinHp = 50;
        private const int SpeedMotorcycleMaxHp = 69;

        public override int HorsePower
        {
            get
            {
                return horsePower;
            }

            protected set
            {
                if (value < SpeedMotorcycleMinHp || value > SpeedMotorcycleMaxHp)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
                horsePower = value;
            }
        }

        public SpeedMotorcycle(string model, int horsePower)
: base(model, horsePower, SpeedMotorcycleCubicCentimeters)
        {
        }
    }
}
