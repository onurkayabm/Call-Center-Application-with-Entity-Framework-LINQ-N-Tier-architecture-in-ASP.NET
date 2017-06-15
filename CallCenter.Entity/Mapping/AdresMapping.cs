using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Mapping
{
    public class AdresMapping : EntityTypeConfiguration<Adres>
    {
        public AdresMapping()
        {
            ToTable("Adresler");
        }
    }
}
