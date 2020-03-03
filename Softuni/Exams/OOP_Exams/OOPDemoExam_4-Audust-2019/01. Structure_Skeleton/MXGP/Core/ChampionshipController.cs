using MXGP.Core.Contracts;
using MXGP.Models.Motorcycles;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Races;
using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories;
using MXGP.Repositories.Contracts;
using System;
using System.Linq;
using System.Text;

namespace MXGP.Core
{
    class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<IRider> riderRepository;
        private readonly IRepository<IMotorcycle> motorcycleRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            this.riderRepository = new RiderRepository();
            this.motorcycleRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            var rider = this.riderRepository.GetByName(riderName);
            var motorcycle = this.motorcycleRepository.GetByName(motorcycleModel);

            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }
            if (motorcycle == null)
            {
                throw new InvalidOperationException($"Motorcycle {motorcycleModel} could not be found.");
            }

            rider.AddMotorcycle(motorcycle);

            return $"Rider {rider.Name} received motorcycle {motorcycle.Model}.";
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            var race = this.raceRepository.GetByName(raceName);
            var rider = this.riderRepository.GetByName(riderName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            race.AddRider(rider);

            return $"Rider {rider.Name} added in {race.Name} race.";

        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            var motorcycle = this.motorcycleRepository.GetByName(model);

            if (motorcycle != null)
            {
                throw new ArgumentException($"Motorcycle {model} is already created.");
            }

            if (type == "Speed")
            {
                motorcycle = new SpeedMotorcycle(model, horsePower);
            }
            else if (type == "Power")
            {
                motorcycle = new PowerMotorcycle(model, horsePower);
            }

            this.motorcycleRepository.Add(motorcycle);

            return $"{motorcycle.GetType().Name} {model} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            var race = this.raceRepository.GetByName(name);

            if (race != null)
            {
                throw new InvalidOperationException($"Race {name} is already created.");
            }

            race = new Race(name, laps);

            this.raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string CreateRider(string riderName)
        {
            var rider = riderRepository.GetByName(riderName);

            if (rider != null)
            {
                throw new ArgumentException($"Rider {rider.Name} is already created.");
            }
            rider = new Rider(riderName);
            riderRepository.Add(rider);

            return $"Rider {rider.Name} is created";
        }

        public string StartRace(string raceName)
        {
            var race = this.raceRepository.GetByName(raceName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (race.Riders.Count < 3)
            {
                throw new InvalidOperationException($"Race {race.Name} cannot start with less than 3 participants.");
            }

            var riders = race.Riders
                .OrderByDescending(x => x.Motorcycle.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToList();

            var sb = new StringBuilder();
            sb.AppendLine($"Rider {riders[0]} wins {race.Name} race.");
            sb.AppendLine($"Rider {riders[1]} is second in {race.Name} race.");
            sb.AppendLine($"Rider {riders[2]} is third in {race.Name} race.");


            raceRepository.Remove(race);
            return sb.ToString().TrimEnd();
        }
    }
}
