using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AisMKIT.Models
{

    // Типы СМИ
    public class DictMediaType
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime CreateDate;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;
    }


    // Организационно-правовая форма
    public class DictLegalForm
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime CreateDate;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;

    }

    // Язык вещания СМИ
    public class DictLangMediaType
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime CreateDate;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;
    }

    // Регионы (области)
    public class DictRegion
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime CreateDate;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;
    }

    // Район
    public class DictDistrict
    {

        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public Enum Status { get; set; }
        public DateTime DeactiveDate { get; set; }
        public int UsersId { get; set; }
        public string City { get; set; }
    }


    // Периодичность выпуска СМИ
    public class DictMediaFreqRelease
    {
        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public Enum Status { get; set; }
        public DateTime DeactiveDate { get; set; }
        public int UsersId { get; set; }
    }


    // Источник финансирования
    public class DictMediaFinSource
    {
        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public Enum Status { get; set; }
        public DateTime DeactiveDate { get; set; }
        public int UsersId { get; set; }
    }

    // Орган выдающий разрещения
    public class DictAgencyPerm
    {
        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public Enum Status { get; set; }
        public DateTime DeactiveDate { get; set; }
        public int UsersId { get; set; }
    }



    // Вид проверки СМИ
    public class DictControlType
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime DateTime;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;

    }

    // Результаты проверки СМИ
    public class DictMediaControlResult
    {
        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public Enum Status { get; set; }
        public DateTime DeactiveDate { get; set; }
        public int UsersId { get; set; }
    }

    // Судебное решение
    public class DictMediaSuitPerm
    {
        public int Id { get; set; }
        public string NameKyrg { get; set; }
        public string NameRus { get; set; }
        public DateTime CreateDate { get; set; }
        public Enum Status { get; set; }
        public DateTime DeactiveDate { get; set; }
        public int UsersId { get; set; }
    }






}
