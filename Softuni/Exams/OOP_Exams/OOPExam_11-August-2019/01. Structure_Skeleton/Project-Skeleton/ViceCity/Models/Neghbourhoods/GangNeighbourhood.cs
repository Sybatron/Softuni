using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;

namespace ViceCity.Models.Neghbourhoods
{
    class GangNeighbourhood : INeighbourhood
    {

        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            IGun gun = null;
            #region MainPlayer
            while (mainPlayer.GunRepository.Models.Count > 0)
            {
                foreach (var firstGun in mainPlayer.GunRepository.Models)
                {
                    gun = firstGun;
                    break;
                }

                while (true)
                {
                    if (civilPlayers.Count == 0)
                    {
                        return;
                    }
                    if (gun.CanFire)
                    {
                        var dmg = gun.Fire();
                        civilPlayers.First().TakeLifePoints(dmg);

                        if (!civilPlayers.First().IsAlive)
                        {
                            civilPlayers.Remove(civilPlayers.First());
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            #endregion

            #region CivilPlayers
            var currentCivilPlayers = civilPlayers.ToList();
            for (int i = 0; i < civilPlayers.Count; i++)
            {
                var player = currentCivilPlayers[i];

                foreach (var firstGun in player.GunRepository.Models)
                {
                    gun = firstGun;
                    break;
                }

                while (true)
                {
                    if (!mainPlayer.IsAlive)
                    {
                        return;
                    }

                    if (gun.CanFire)
                    {
                        var dmg = gun.Fire();
                        mainPlayer.TakeLifePoints(dmg);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            #endregion
        }
    }
}
