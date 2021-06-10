using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceAutoApp.Models;

namespace ServiceAutoApp.Data
{
    public class ServiceAutoAppContext : DbContext
    {
        public ServiceAutoAppContext (DbContextOptions<ServiceAutoAppContext> options)
            : base(options)
        {
        }

        public DbSet<ServiceAutoApp.Models.Client> Client { get; set; }

        public DbSet<ServiceAutoApp.Models.Masina> Masina { get; set; }

        public DbSet<ServiceAutoApp.Models.Serviciu> Serviciu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Models.Masina m1 = new Models.Masina()
            {
                ID = new Guid("551E9DAB-B73E-1233-2345-BFAB4A214D9A"),
                TipMasina = "duba",
                Locatia = "Oradea"
            };

            Models.Masina m2 = new Models.Masina()
            {
                ID = new Guid("551E9DAB-B73E-4567-2345-BFAB4A214D9A"),
                TipMasina = "tir",
                Locatia = "Bistrita"
            };
            modelBuilder.Entity<Models.Masina>().HasData(m1);
            modelBuilder.Entity<Models.Masina>().HasData(m2);

            modelBuilder.Entity<Models.Client>().HasData(new Models.Client() { ID = new Guid("551E9DAB-B73E-4322-8200-BFAB4A214D9F"), Nume = "Boldor", Prenume ="Ema", Locatia="Campani", TipDefectiune="pana la roata", TipMasina="vw" });
            modelBuilder.Entity<Models.Client>().HasData(new Models.Client() { ID = new Guid("551E9DAB-B73E-4322-2345-BFAB4A214D9A"), Nume = "Boldor", Prenume ="Sara", Locatia="Campani", TipDefectiune="oglina rupta", TipMasina="audi" });

            modelBuilder.Entity<Models.Serviciu>().HasData(new Models.Serviciu() { ID = new Guid("551E9DAB-B73E-4567-2345-BFAB4A214D9A"), DenumireServiciu="vulcanizare", Pret=1234 , TipMasinaNecesara= m1.TipMasina });
            modelBuilder.Entity<Models.Serviciu>().HasData(new Models.Serviciu() { ID = new Guid("551E9DAB-B73E-6789-2345-BFAB4A214D9A"), DenumireServiciu = "avariere", Pret = 1345, TipMasinaNecesara = m2.TipMasina });

        }

        public DbSet<ServiceAutoApp.Models.Parteneriat> Parteneriat { get; set; }

        //modelBuilder.Entity<Models.Parteneriat>().HasData(new Models.Parteneriat() { ID = new Guid("551E9DAB-B73E-4322-1234-BFAB4A214D9F"), firma = "Audi", piese = "bujii"});
        //modelBuilder.Entity<Models.Parteneriat>().HasData(new Models.Parteneriat() { ID = new Guid("551E9DAB-B73E-4322-6789-BFAB4A214D9A"), firma = "Mercedes", piese = "anvelope"});

    }

}
