using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Model
{
    public class Ilce
    {
        public Ilce()
        {
            Adresler = new HashSet<Adres>();
        }
        public int IlceID { get; set; }
        //FK
        public int IlID { get; set; }
        public string IlceAdi { get; set; }

        //Navigation

        public virtual Il Il{ get; set; }
        public virtual ICollection<Adres> Adresler{ get; set; }

    }
}
