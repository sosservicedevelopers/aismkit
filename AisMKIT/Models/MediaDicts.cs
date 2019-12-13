using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AisMKIT.Models
{

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

}
