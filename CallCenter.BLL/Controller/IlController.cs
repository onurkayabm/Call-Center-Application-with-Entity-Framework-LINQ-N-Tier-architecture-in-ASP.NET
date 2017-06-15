using CallCenter.DAL.Manager;
using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL.Controller
{
    public class IlController
    {
        IlManagement _ilManagement;

        public IlController()
        {
            _ilManagement = new IlManagement();
        }

        public void AddEntity(Il item)
        {
            _ilManagement.AddEntity(item);
        }

        public void DeleteEntity(Il item)
        {
            _ilManagement.DeleteEntity(item);
        }

        public void UpdateEntity(Il item)
        {
            _ilManagement.UpdateEntity(item);
        }
    }
}
