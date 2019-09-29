using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;

namespace ViceCity.Core
{
    class Controller : IController
    {
        private MainPlayer mainPlayer;
        private List<IPlayer> civilPlayers;
        private GunRepository gunRepository;
        private GangNeighbourhood gangNeighbourhood;

        public Controller()
        {
            mainPlayer = new MainPlayer();
            civilPlayers = new List<IPlayer>();
            gunRepository = new GunRepository();
            gangNeighbourhood = new GangNeighbourhood();
        }
        public string AddGun(string type, string name)
        {
            if (type != "Pistol" && type != "Rifle")
            {
                return "Invalid gun type!";
            }

            if (type == "Pistol")
            {
                Pistol gun = new Pistol(name);
                this.gunRepository.Add(gun);
            }

            if (type == "Rifle")
            {
                Rifle gun = new Rifle(name);
                this.gunRepository.Add(gun);
            }

            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            if (gunRepository.Models.Count == 0)
            {
                return "There are no guns in the queue!";
            }

            var gun = gunRepository.models[0];

            if (name == "Vercetti")
            {
                gunRepository.Remove(gun);
                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }

            if (!civilPlayers.Any(x => x.Name == name))
            {
                return "Civil player with that name doesn't exists!";
            }

            gunRepository.Remove(gun);
            civilPlayers.FirstOrDefault(x => x.Name == name).GunRepository.Add(gun);

            return $"Successfully added {gun.Name} to the Civil Player: {name}";
        }

        public string AddPlayer(string name)
        {
            civilPlayers.Add(new CivilPlayer(name));
            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            var mainPlayerHp = mainPlayer.LifePoints;
            var civilPlayersHp = new List<int>();
            var civilPlayersCount = civilPlayers.Count;

            foreach (var player in civilPlayers)
            {
                civilPlayersHp.Add(player.LifePoints);
            }

            gangNeighbourhood.Action(mainPlayer, civilPlayers);


            if (mainPlayerHp != mainPlayer.LifePoints)
            {
                return FightHappened(civilPlayersCount);
            }

            var index = 0;
            foreach (var player in civilPlayers)
            {
                if (civilPlayersHp[index] != player.LifePoints)
                {
                    return FightHappened(civilPlayersCount);
                }
                index++;
            }
            return "Everything is okay!";

        }

        private string FightHappened(int civilPlayersCount)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"A fight happened:");
            sb.AppendLine($"Tommy live points: {mainPlayer.LifePoints}!");
            sb.AppendLine($"Tommy has killed: {civilPlayersCount - civilPlayers.Count} players!");
            sb.AppendLine($"Left Civil Players: {civilPlayers.Count}!");
            return sb.ToString().TrimEnd();
        }
    }
}
