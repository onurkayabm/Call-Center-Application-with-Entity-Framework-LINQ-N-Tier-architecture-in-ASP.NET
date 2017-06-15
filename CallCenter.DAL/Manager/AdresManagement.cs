using CallCenter.DAL.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.Entity.Model;

namespace CallCenter.DAL.Manager
{
    public class AdresManagement : IAdres
    {
        CallCenterEntities _entities;
        public AdresManagement()
        {
            _entities = new CallCenterEntities();
        }
        public void AddEntity(Adres item)
        {
            _entities.Adresler.Add(item);
            _entities.SaveChanges();
        }

        public void DeleteEntity(Adres item)
        {
            _entities.Adresler.Remove(_entities.Adresler.Find(item.AdresID));
            _entities.SaveChanges();
        }

        public void UpdateEntity(Adres item)
        {
            throw new NotImplementedException();
        }
    }
}
