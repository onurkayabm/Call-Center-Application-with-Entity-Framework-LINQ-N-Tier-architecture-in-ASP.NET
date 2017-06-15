using CallCenter.DAL.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.Entity.Model;

namespace CallCenter.DAL.Manager
{
    public class MailManagement : IMail
    {
        CallCenterEntities _entities;
        public MailManagement()
        {
            _entities = new CallCenterEntities();
        }
        public void AddEntity(Mail item)
        {
            _entities.Mailler.Add(item);
            _entities.SaveChanges();
        }

        public void DeleteEntity(Mail item)
        {
            _entities.Mailler.Remove(_entities.Mailler.Find(item.MailID));
            _entities.SaveChanges();
        }

        public void UpdateEntity(Mail item)
        {
            throw new NotImplementedException();
        }
    }
}
