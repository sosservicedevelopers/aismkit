using System;
using System.Collections.Generic;
using System.Text;
using AisMKIT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AisMKIT.Data
{



    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //public class ApplicationDbContext : DbContext

    //public class ApplicationDbContext : IdentityDbContext<User>
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Departments> Departments { get; set; }
     

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
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
            builder.Entity<DictMediaFreqRelease>().HasData(new DictMediaFreqRelease[]{
                        new DictMediaFreqRelease{Id=1, NameRus="Ежемесячно", NameKyrg="Ар бир айда"},
                        new DictMediaFreqRelease{Id=2, NameRus="Еженедельно", NameKyrg="Ар бир жумада"}});

            // начальные данные для 
            builder.Entity<DictMediaFinSource>().HasData(new DictMediaFinSource[]{
                        new DictMediaFinSource{Id=1, NameRus="Государственный", NameKyrg="Мамлекеттик"},
                        new DictMediaFinSource{Id=2, NameRus="Частный", NameKyrg="Жекече"}});


            // начальные данные для 
            builder.Entity<DictAgencyPerm>().HasData(new DictAgencyPerm[]{
                        new DictAgencyPerm{Id=1, NameRus="МВД", NameKyrg="ИИМ"},
                        new DictAgencyPerm{Id=2, NameRus="ГКНБ", NameKyrg="МКНБ"}});

            // начальные данные для 
            builder.Entity<DictControlType>().HasData(new DictControlType[]{
                        new DictControlType{Id=1, NameRus="Плановая", NameKyrg="Пландык"},
                        new DictControlType{Id=2, NameRus="Неплановая", NameKyrg="Пландык эмес"}});

            // начальные данные для 
            builder.Entity<DictMediaControlResult>().HasData(new DictMediaControlResult[]{
                        new DictMediaControlResult{Id=1, NameRus="Без нарушений", NameKyrg=""},
                        new DictMediaControlResult{Id=2, NameRus="Вынесено предупреждение", NameKyrg=""},
                        new DictMediaControlResult{Id=3, NameRus="Наложен штраф", NameKyrg=""},
                        new DictMediaControlResult{Id=4, NameRus="Отзыв разрешения", NameKyrg=""}});


            // начальные данные для 
            builder.Entity<DictMediaSuitPerm>().HasData(new DictMediaSuitPerm[]{
                        new DictMediaSuitPerm{Id=1, NameRus="В пользу лицензиата", NameKyrg=""},
                        new DictMediaSuitPerm{Id=2, NameRus="В пользу лицензиара", NameKyrg=""}});



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
        public DbSet<AisMKIT.Models.DictTheatricalLegalForm> DictTheatricalLegalForm { get; set; }
        public DbSet<AisMKIT.Models.DictTheatricalFinSource> DictTheatricalFinSource { get; set; }
        public DbSet<AisMKIT.Models.ListOfTheatrical> ListOfTheatrical { get; set; }
        public DbSet<AisMKIT.Models.ListOfCouncilTheatrical> ListOfCouncilTheatrical { get; set; }
        public DbSet<AisMKIT.Models.ListOfEventsTheatrical> ListOfEventsTheatrical { get; set; }


        // Реестр Учебных заведений
        public DbSet<AisMKIT.Models.EduInstitution> EduInstitutions { get; set; }

        // дополнительные модели для реестра Учебные заведения
        // список факультетов
        public DbSet<AisMKIT.Models.Faculty> Faculties { get; set; }
        // список сотрудников
        public DbSet<AisMKIT.Models.Employee> Employees { get; set; }

        public DbSet<AisMKIT.Models.EmplPosHistory> EmplPosHistories { get; set; }

        public DbSet<AisMKIT.Models.Position> Positions { get; set; }

        public DbSet<AisMKIT.Models.Specialty> Specialties { get; set; }

        public DbSet<AisMKIT.Models.FacultySpecialty> FacultySpecialties { get; set; }

        public DbSet<AisMKIT.Models.EducationalUnit> EducationalUnits { get; set; }

        public DbSet<AisMKIT.Models.EmplEducationalUnit> EmplEducationalUnits { get; set; }

        public DbSet<AisMKIT.Models.DictEduCategory> DictEduCategories { get; set; }

        // Список выданных гос. сертификатов к фильмам за 2019 
        public DbSet<AisMKIT.Models.ListISRCFilms> listISRCFilms { get; set; }

        // Список выданных гос. сертификатов к фильмам за 2019 
        public DbSet<AisMKIT.Models.ListOfMonument> ListOfMonument { get; set; }

        // Список выданных гос. сертификатов к фильмам за 2019 
        public DbSet<AisMKIT.Models.DictTypeOfMonument> DictTypeOfMonument { get; set; }

        // Список выданных гос. сертификатов к фильмам за 2019 
        public DbSet<AisMKIT.Models.DictTypeOfSub> DictTypeOfSub { get; set; }

        // Список выданных гос. сертификатов к фильмам за 2019 
        public DbSet<AisMKIT.Models.ListOfSubInstitutions> ListOfSubInstitutions { get; set; }

        // Список выданных гос. сертификатов к фильмам за 2019 
        public DbSet<AisMKIT.Models.DictDistribTerritoryMedia> DictDistribTerritoryMedia { get; set; }

        // Список выданных гос. сертификатов к фильмам за 2019 
        public DbSet<AisMKIT.Models.DictAffiliationOfMonument> DictAffiliationOfMonument { get; set; }
    }
}
