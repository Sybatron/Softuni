using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        public List<IGun> models = new List<IGun>();
        public IReadOnlyCollection<IGun> Models => models;

        public GunRepository()
        {
        }

        public void Add(IGun model)
        {
            if (!models.Contains(model))
            {
                models.Add(model);
            }
        }

        public IGun Find(string name)
        {
            var gun = models.FirstOrDefault(x => x.Name == name);
            return gun;
        }

        public bool Remove(IGun model)
        {
            if (models.Contains(model))
            {
                models.Remove(model);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCount()
        {
            return models.Count;
        }
    }
}
