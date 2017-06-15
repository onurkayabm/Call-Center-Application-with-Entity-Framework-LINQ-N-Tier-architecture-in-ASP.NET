using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Mapping
{
    public class IlceMapping : EntityTypeConfiguration<Ilce>
    {
        public IlceMapping()
        {
            ToTable("Ilceler");
            HasMany(ilce => ilce.Adresler)
                .WithOptional(adres => adres.Ilce)
                .HasForeignKey(x => x.IlceID);
        }
    }
}
