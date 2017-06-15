using CallCenter.Entity;
using CallCenter.Entity.Mapping;
using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL
{
    public class CallCenterEntities:DbContext
    {
        public CallCenterEntities()
        {

        }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Il> Iller { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Mail> Mailler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Telefon> Telefonlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdresMapping());
            modelBuilder.Configurations.Add(new IlceMapping());
            modelBuilder.Configurations.Add(new IlMapping());
            modelBuilder.Configurations.Add(new MailMapping());
            modelBuilder.Configurations.Add(new TelefonMapping());
            modelBuilder.Configurations.Add(new MusteriMapping());
        }

    }
}
