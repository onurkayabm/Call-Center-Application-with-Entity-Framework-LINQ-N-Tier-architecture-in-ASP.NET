using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Mapping
{
    public class IlMapping : EntityTypeConfiguration<Il>
    {
        public IlMapping()
        {
            ToTable("Iller");
            HasMany(ilce => ilce.Ilceler)
                .WithRequired(il => il.Il)
                .HasForeignKey(x => x.IlID);
        }
    }
}
