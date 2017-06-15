using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenter.Entity.Model;

namespace CallCenter.Entity
{
    public class Musteri
    {
        public Musteri()
        {
            Adresler = new HashSet<Adres>();
            Telefonlar = new HashSet<Telefon>();
            Mailler = new HashSet<Mail>();
        }
        public int MusteriID { get; set; }
        public string MusteriTC { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }

        //Navigation
        public virtual ICollection<Adres> Adresler{ get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<Mail> Mailler { get; set; }

    }
}
