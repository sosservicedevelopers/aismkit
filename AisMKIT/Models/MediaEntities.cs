using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AisMKIT.Models
{
    public class MediaEntities { }
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
        public DateTime DateTime;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;
    }

    public class DictLegalForm
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime DateTime;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;

    }

    public class DictMediaType
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime DateTime;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;

    }

    public class DictRegion
    {
        public int Id;
        public string NameKyrg;
        public string NameRus;
        public DateTime DateTime;
        public Enum Status;
        public DateTime DeactiveDate;
        public int UsersId;
    }

}
