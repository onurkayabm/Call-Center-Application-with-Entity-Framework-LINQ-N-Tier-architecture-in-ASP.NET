using CallCenter.DAL.Manager;
using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL.Controller
{
    public class IlceController
    {
        IlceManagement _ilceManagement;
        public IlceController()
        {
            _ilceManagement = new IlceManagement();
        }
        public void AddEntity(Ilce item)
        {
            _ilceManagement.AddEntity(item);
        }

        public void DeleteEntity(Ilce item)
        {
            _ilceManagement.DeleteEntity(item);
        }
        public void UpdateEntity(Ilce item)
        {
            _ilceManagement.UpdateEntity(item);
        }
    }
}
