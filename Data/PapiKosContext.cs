using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PapiKos.Models;

namespace PapiKos.Models
{
    public class PapiKosContext : DbContext
    {
        public PapiKosContext(DbContextOptions<PapiKosContext> options) : base(options)
        {

        }
        public DbSet<PapiKos.Models.Kos> Kos { get; set; }
        public DbSet<PapiKos.Models.Kamar> Kamar{get;set;}
        public DbSet<PapiKos.Models.Account> Account{get;set;}
        public DbSet<PapiKos.Models.Owner> Owner{get;set;}
    }
}