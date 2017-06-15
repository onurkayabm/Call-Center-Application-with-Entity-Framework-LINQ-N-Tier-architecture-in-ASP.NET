using CallCenter.DAL.Manager;
using CallCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL.Controller
{
    public class MusteriController
    {
        MusteriManagement _musteriManagement;
        public MusteriController()
        {
            _musteriManagement = new MusteriManagement();
        }

        public void AddEntity(Musteri item)
        {
            _musteriManagement.AddEntity(item);
        }
        public void DeleteEntity(Musteri item)
        {
            _musteriManagement.DeleteEntity(item);
        }

        public void UpdateEntity(Musteri item)
        {
            _musteriManagement.UpdateEntity(item);
        }
        public ICollection<Musteri> GetAllEntities()
        {
            return _musteriManagement.GetAllEntities();
        }
        public Musteri GetByIDEntities(int id)
        {
            return _musteriManagement.GetByID(id);
        }
    }
}
