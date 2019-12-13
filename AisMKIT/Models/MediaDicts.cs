using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AisMKIT.Models
{

    // Типы СМИ
    public class DictMediaType
    {
        public int Id;

        [Display(Name = "Наименование вида СМИ (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Наименование вида СМИ (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId;
    }


    // Организационно-правовая форма
    public class DictLegalForm
    {
        public int Id;

        [Display(Name = "Организационно-правовая форма (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Организационно-правовая форма (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId;

    }

    // Язык вещания СМИ
    public class DictLangMediaType
    {
        public int Id;

        [Display(Name = "Язык вещания СМИ (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Язык вещания СМИ (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId;
    }

    // Регионы (области)
    public class DictRegion
    {
        public int Id;

        [Display(Name = "Регион (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Регион (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId;
    }

    // Район
    public class DictDistrict
    {

        public int Id { get; set; }

        [Display(Name = "Район (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Район (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId { get; set; }
        public string City { get; set; }
    }


    // Периодичность выпуска СМИ
    public class DictMediaFreqRelease
    {
        public int Id { get; set; }

        [Display(Name = "Периодичность выпуска (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Периодичность выпуска (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId { get; set; }
    }


    // Источник финансирования
    public class DictMediaFinSource
    {
        public int Id { get; set; }

        [Display(Name = "Источник финансирования (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Источник финансирования (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId { get; set; }
    }

    // Орган выдающий разрещения
    public class DictAgencyPerm
    {
        public int Id { get; set; }

        [Display(Name = "Орган выдающий разрещения (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Орган выдающий разрещения (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId { get; set; }
    }



    // Вид проверки СМИ
    public class DictControlType
    {
        public int Id;

        [Display(Name = "Вид проверки СМИ (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Вид проверки СМИ (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId;

    }

    // Результаты проверки СМИ
    public class DictMediaControlResult
    {
        public int Id { get; set; }

        [Display(Name = "Результаты проверки СМИ (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Результаты проверки СМИ (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId { get; set; }
    }

    // Судебное решение
    public class DictMediaSuitPerm
    {
        public int Id { get; set; }

        [Display(Name = "Судебное решение (Кырг)")]
        public string NameKyrg;

        [Display(Name = "Судебное решение (Русск)")]
        public string NameRus;

        [Display(Name = "Дата ввода записи")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate;

        [Display(Name = "Статус")]
        public Enum Status;

        [Display(Name = "Дата, с которой запись признана неактуальной")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeactiveDate;

        public int UsersId { get; set; }
    }






}
