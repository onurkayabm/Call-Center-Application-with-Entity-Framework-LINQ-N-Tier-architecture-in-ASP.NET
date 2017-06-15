using CallCenter.DAL.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.Entity.Model;

namespace CallCenter.DAL.Manager
{

    public class TelefonManagement : ITelefon
    {
        CallCenterEntities _entities;
        public TelefonManagement()
        {
            _entities = new CallCenterEntities();
        }
        public void AddEntity(Telefon item)
        {
            _entities.Telefonlar.Add(item);
            _entities.SaveChanges();
        }

        public void DeleteEntity(Telefon item)
        {
            _entities.Telefonlar.Remove(_entities.Telefonlar.Find(item.TelefonID));
            _entities.SaveChanges();
        }

        public void UpdateEntity(Telefon item)
        {
            throw new NotImplementedException();
        }
    }
}
