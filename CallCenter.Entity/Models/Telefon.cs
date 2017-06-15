using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Model
{
    public class Telefon
    {
        public int TelefonID { get; set; }
        public string TelefonNumarasi { get; set; }
        //FK
        public int MusteriID { get; set; }

        //Navigation
        public virtual Musteri Musteri { get; set; }
    }
}
