using CallCenter.DAL.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.Entity;

namespace CallCenter.DAL.Manager
{
    public class MusteriManagement:IMusteri
    {
        CallCenterEntities _entities;

        public MusteriManagement()
        {
            _entities = new CallCenterEntities();
        }

        public void AddEntity(Musteri item)
        {
            _entities.Musteriler.Add(item);
            _entities.SaveChanges();
        }

        public void DeleteEntity(Musteri item)
        {
            _entities.Musteriler.Remove(_entities.Musteriler.Find(item.MusteriID));
            _entities.SaveChanges();
        }

        public ICollection<Musteri> GetAllEntities()
        {
            return _entities.Musteriler.OrderBy(x=>x.MusteriAdi).ToList();
        }

        public Musteri GetByID(int id)
        {
            return _entities.Musteriler.Find(id);
        }

        public void UpdateEntity(Musteri item)
        {
            throw new NotImplementedException();
        }
    }
}
