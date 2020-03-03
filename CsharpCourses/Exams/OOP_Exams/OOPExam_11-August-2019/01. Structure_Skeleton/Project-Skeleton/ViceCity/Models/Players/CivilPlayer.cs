using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    class CivilPlayer : Player
    {
        private const int lifePoints = 50;

        public CivilPlayer(string name)
            : base(name, lifePoints)
        {
        }
    }
}
