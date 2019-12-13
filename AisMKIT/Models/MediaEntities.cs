using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AisMKIT.Models
{

    public class ListOfMedia
    {
        public int Id { get; set; }

        public string NameKyrg { get; set; }

        public string NameRus { get; set; }

        public string INN { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int DictLangMediaTypeId { get; set; }
        public int DictMediaTypeId { get; set; }
        public string AddressRus { get; set; }
        public string AddressKyrg { get; set; }
        public int DictDistrictId { get; set; }
        public int DictMediaFreqReleaseId { get; set; }
        public int DictMediaFinSourceId { get; set; }
        public DateTime ReregistrationDate { get; set; }
        public DateTime EliminationDate { get; set; }
        public int NumberOfPermission { get; set; }
        public DateTime PermissionDate { get; set; }
        public DateTime DateOfPay { get; set; }

        public string NumOfPermGas { get; set; }
        public DateTime PermGASDate { get; set; }
        public DateTime PermElimGASDate { get; set; }
        public int DictAgencyPermId { get; set; }
        public int UsersId { get; set; }
    }

    public class ListOfMediaHistory
    {

    }

    public class ListOfControlMedia
    {

    }
}
