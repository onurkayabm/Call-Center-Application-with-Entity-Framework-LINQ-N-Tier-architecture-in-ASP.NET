using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Model
{
    public class Adres
    {
        public int AdresID { get; set; }
        public string Adresi { get; set; }
        //FK
        public int MusteriID { get; set; }
        //FK
        public int? IlceID { get; set; }

        //Navigation
        public virtual Musteri Musteri { get; set; }
        public virtual Ilce Ilce { get; set; }

    }
}
