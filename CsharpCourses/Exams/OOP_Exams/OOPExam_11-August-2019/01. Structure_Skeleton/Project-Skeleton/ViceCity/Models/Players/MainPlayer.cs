using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    class MainPlayer : Player
    {
        private const string name = "Tommy Vercetti";
        private const int lifePoints = 100;

        public MainPlayer()
            : base(name, lifePoints)
        {
        }
    }
}
