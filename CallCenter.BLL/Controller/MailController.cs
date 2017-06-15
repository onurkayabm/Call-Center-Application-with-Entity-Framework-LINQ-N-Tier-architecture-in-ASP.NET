using CallCenter.DAL.Manager;
using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.BLL.Controller
{
    public class MailController
    {
        MailManagement _mailManagement;
        public MailController()
        {
            _mailManagement = new MailManagement();
        }
        public void AddEntity(Mail item)
        {
            _mailManagement.AddEntity(item);
        }
        public void DeleteEntity(Mail item)
        {
            _mailManagement.DeleteEntity(item);
        }

        public void UpdateEntity(Mail item)
        {
            _mailManagement.UpdateEntity(item);
        }
    }
}
