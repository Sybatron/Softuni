using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double PowerMotorcycleCubicCentimeters = 450;
        private int horsePower;

        private const int PowerMotorcycleMinHp = 70;
        private const int PowerMotorcycleMaxHp = 100;
        public override int HorsePower
        {
            get
            {
                return horsePower;
            }

            protected set
            {
                if (value < PowerMotorcycleMinHp || value > PowerMotorcycleMaxHp)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
                horsePower = value;
            }
        }

        public PowerMotorcycle(string model, int horsePower)
: base(model, horsePower, PowerMotorcycleCubicCentimeters)
        {
        }

    }
}
