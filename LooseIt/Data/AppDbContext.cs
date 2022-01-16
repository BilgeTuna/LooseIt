using LooseIt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseIt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=LooseItDb")
        {
            Database.SetInitializer(new DbInitialStrategy());
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Ogun> Ogunler { get; set; }

        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<YemekKategori> YemekKategroiler { get; set; }
    }
}
