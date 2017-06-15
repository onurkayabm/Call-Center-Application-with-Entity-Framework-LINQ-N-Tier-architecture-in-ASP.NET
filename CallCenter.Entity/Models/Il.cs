using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Model
{
    public class Il
    {
        public Il()
        {
            Ilceler = new HashSet<Ilce>();
        }
        public int IlID { get; set; }
        public string IlAdi { get; set; }

        //Navigation
        public virtual ICollection<Ilce> Ilceler { get; set; }
    }
}
