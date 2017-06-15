using CallCenter.DAL.Manager;
using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL.Controller
{
    public class TelefonController
    {
        TelefonManagement _telefonManagement;
        public TelefonController()
        {
            _telefonManagement = new TelefonManagement();
        }
        public void AddEntity(Telefon item)
        {
            _telefonManagement.AddEntity(item);
        }
        public void DeleteEntity(Telefon item)
        {
            _telefonManagement.DeleteEntity(item);
        }
        public void UpdateEntity(Telefon item)
        {
            _telefonManagement.DeleteEntity(item);
        }
    }
}
