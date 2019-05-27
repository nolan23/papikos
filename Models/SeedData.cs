using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PapiKos.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PapiKosContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PapiKosContext>>()))
            {
                // Look for any movies.
                if (context.Owner.Any())
                {
                    return;   // DB has been seeded
                }
                var kamars = new Kamar[]
                {
                    new Kamar{Gambar="Home.png",
                        UkuranKamar="10x10",
                        HargaKamar="Rp 1.000.000",
                        StatusKamar="Available",
                        DeskripsiKamar="Bagus",
                        // InformasiTambahan=new List<string>(){"Satu.jpg","Dua.jpg"},
                        }
                };

                var kos = new Kos[]
                {
                    new Kos{
                        NamaKos="ParlilitanKos",
                        JumlahKamar=1,
                        DeskripsiTambahan="Kos nya bagus",
                        Alamat="Parlilitan masuk ke dalam",
                        Kamars=new List<Kamar>(kamars),

                    }
                };
                foreach (Kos o in kos)
                {
                    context.Kos.Add(o);
                }

                var owners = new Owner[]
                {
                    new Owner{
                        Nama="Roby",
                        NomorTelephone="082362738123",
                        Email="robyparapat@google.com",
                        Kos = new List<Kos>(kos)
                    }
                };

                foreach (Owner o in owners)
                {
                    context.Owner.Add(o);
                }
                context.SaveChanges();
                var owner = context.Owner.Single(c=>c.Nama=="Roby");
                var k = context.Kos.Single(c=>c.NamaKos=="ParlilitanKos");
                k.Owner=owner;
                context.Kos.Update(k);
                context.SaveChanges();

            }
        }
    }
}