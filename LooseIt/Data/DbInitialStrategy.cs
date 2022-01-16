using LooseIt.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LooseIt.Data
{
    public class DbInitialStrategy : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            if (!context.Yemekler.Any())
            {
                List<Yemek> yemekler = null;
                yemekler = new List<Yemek>()
                {
                    new Yemek()
                    {
                        YemekAdi="elma",
                        Kalori=50,
                        YemekResim="https://cdn.pixabay.com/photo/2021/01/09/12/58/apple-5902283_960_720.png"

                    }
                };
                foreach (Yemek item in yemekler)
                    context.Yemekler.Add(item);
            }
            context.SaveChanges();
        }
    }
}