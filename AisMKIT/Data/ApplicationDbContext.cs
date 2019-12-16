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
            builder.Entity<StatusForDict>().HasData(new StatusForDict[]{
                        new StatusForDict{Id=1, Name="включён" },
                        new StatusForDict{Id=2, Name="отключён" }});

            // начальные данные для 
            builder.Entity<DictMediaType>().HasData(new DictMediaType[]{
                        new DictMediaType{Id=1, NameRus="Печатное периодическое издание", NameKyrg="Басма уйу"},
                        new DictMediaType{Id=2, NameRus="Телеканал", NameKyrg="Телеканал"}});

            // начальные данные для 
            builder.Entity<DictLegalForm>().HasData(new DictLegalForm[]{
                        new DictLegalForm{Id=1, NameRus="Закрытое акционерное общество", NameKyrg="Жабык акционердик коому"},
                        new DictLegalForm{Id=2, NameRus="Общество с ограниченной ответсвенностью", NameKyrg="Жоопкерчилиги чектелген коом"}});

            // начальные данные для 
            builder.Entity<DictLangMediaType>().HasData(new DictLangMediaType[]{
                        new DictLangMediaType{Id=1, NameRus="Русский", NameKyrg="Орусча"},
                        new DictLangMediaType{Id=2, NameRus="Кыргызский", NameKyrg="Кыргызча"}});

            // начальные данные для 
            builder.Entity<DictRegion>().HasData(new DictRegion[]{
                        new DictRegion{Id=1, NameRus="Чуй", NameKyrg="Чуй"},
                        new DictRegion{Id=2, NameRus="Баткен", NameKyrg="Баткен"}});

            // начальные данные для 
            builder.Entity<DictDistrict>().HasData(new DictDistrict[]{
                        new DictDistrict{Id=1, NameRus="Сокулук", NameKyrg="Сокулук"},
                        new DictDistrict{Id=2, NameRus="Рыбалов", NameKyrg="Балыкчы"}});

            // начальные данные для 
            builder.Entity<DictMediaFreqRelease>().HasData(new DictMediaFreqRelease[]{
                        new DictMediaFreqRelease{Id=1, NameRus="Ежемесячно", NameKyrg="Ар бир айда"},
                        new DictMediaFreqRelease{Id=2, NameRus="Еженедельно", NameKyrg="Ар бир жумада"}});

            // начальные данные для 
            builder.Entity<DictMediaFinSource>().HasData(new DictMediaFinSource[]{
                        new DictMediaFinSource{Id=1, NameRus="Государственный", NameKyrg="Мамлекеттик"},
                        new DictMediaFinSource{Id=2, NameRus="Частный", NameKyrg="Жекече"}});

        }
        public DbSet<AisMKIT.Models.DictMediaType> DictMediaType { get; set; }
        public DbSet<AisMKIT.Models.DictLegalForm> DictLegalForm { get; set; }
        public DbSet<AisMKIT.Models.DictLangMediaType> DictLangMediaType { get; set; }
        public DbSet<AisMKIT.Models.DictRegion> DictRegion { get; set; }
        public DbSet<AisMKIT.Models.DictDistrict> DictDistrict { get; set; }
        public DbSet<AisMKIT.Models.DictMediaFreqRelease> DictMediaFreqRelease { get; set; }
        public DbSet<AisMKIT.Models.DictMediaFinSource> DictMediaFinSource { get; set; }
        public DbSet<AisMKIT.Models.ListOfMedia> ListOfMedia { get; set; }
        public DbSet<AisMKIT.Models.DictAgencyPerm> DictAgencyPerm { get; set; }
        public DbSet<AisMKIT.Models.DictControlType> DictControlType { get; set; }
        public DbSet<AisMKIT.Models.DictMediaControlResult> DictMediaControlResult { get; set; }
        public DbSet<AisMKIT.Models.DictMediaSuitPerm> DictMediaSuitPerm { get; set; }
        public DbSet<AisMKIT.Models.ListOfControlMedia> ListOfControlMedia { get; set; }
        //Для postgresql
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=AisMKIT;Username=postgres;Password=admin");
        //}
    }
}
