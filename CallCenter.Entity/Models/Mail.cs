using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Model
{
    public class Mail
    {
        public int MailID { get; set; }
        public string MailAdresi{ get; set; }
        //FK
        public int MusteriID { get; set; }

        //Navigation
        public virtual Musteri Musteri { get; set; }
    }
}
