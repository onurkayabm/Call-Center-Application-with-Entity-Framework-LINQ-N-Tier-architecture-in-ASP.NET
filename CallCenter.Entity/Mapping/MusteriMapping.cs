using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.Entity.Mapping
{
    public class MusteriMapping : EntityTypeConfiguration<Musteri>
    {
        public MusteriMapping()
        {
            ToTable("Musteriler");

            HasMany(musteri => musteri.Adresler)
                .WithRequired(adres => adres.Musteri)
                .HasForeignKey(x => x.MusteriID);

            HasMany(musteri => musteri.Telefonlar)
                .WithRequired(telefon => telefon.Musteri)
                .HasForeignKey(x => x.MusteriID);

            HasMany(musteri => musteri.Mailler)
                .WithRequired(mail => mail.Musteri)
                .HasForeignKey(x => x.MusteriID);
        }
    }
}
