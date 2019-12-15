using System;
using System.Collections.Generic;
using System.Text;
using AisMKIT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AisMKIT.Data
{
    

   
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Departments> Departments { get; set; }
        public DbSet<ClOKNTypes> ClOKNTypes { get; set; }
        public DbSet<ClServices> ClServices { get; set; }
        public DbSet<ClUchZavedCategory> ClUchZavedCategory { get; set; }
        public DbSet<ClObjProizIskusCategory> ClObjProizIskusCategory { get; set; }
        public DbSet<ClObjProizIskusTypes> ClObjProizIskusTypes { get; set; }
        public DbSet<ClNagradTypes> ClNagradTypes { get; set; }
        public DbSet<ListOfEducations> ListOfEducations { get; set; }        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // начальные данные для StatusForDict
            builder.Entity<StatusForDict>().HasData
                (
                    new StatusForDict[]
                    {
                        new StatusForDict{Id=1, Name="включён" },
                        new StatusForDict{Id=2, Name="отключён" }
                    }
                );
        }
        public DbSet<AisMKIT.Models.DictMediaType> DictMediaType { get; set; }
        public DbSet<AisMKIT.Models.DictLegalForm> DictLegalForm { get; set; }
        public DbSet<AisMKIT.Models.DictLangMediaType> DictLangMediaType { get; set; }
        public DbSet<AisMKIT.Models.DictRegion> DictRegion { get; set; }
        public DbSet<AisMKIT.Models.DictDistrict> DictDistrict { get; set; }
        public DbSet<AisMKIT.Models.DictMediaFreqRelease> DictMediaFreqRelease { get; set; }
        public DbSet<AisMKIT.Models.DictMediaFinSource> DictMediaFinSource { get; set; }
        //Для postgresql
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=AisMKIT;Username=postgres;Password=admin");
        //}
    }
}
