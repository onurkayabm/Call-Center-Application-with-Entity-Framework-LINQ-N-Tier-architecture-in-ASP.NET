using CallCenter.DAL.Manager;
using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL.Controller
{
    public class AdresController
    {
        AdresManagement _adresManagement;
        public AdresController()
        {
            _adresManagement = new AdresManagement();
        }
        public void AddEntity(Adres item)
        {
            _adresManagement.AddEntity(item);
        }
        public void DeleteEntity(Adres item)
        {
            _adresManagement.DeleteEntity(item);
        }
        public void UpdateEntity(Adres item)
        {
            _adresManagement.UpdateEntity(item);
        }


    }
}
