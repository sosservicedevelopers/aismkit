using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
        public string Id { get; set; }
        public string ListOfMediaId { get; set; }
        public string DictControlTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDatePeriod { get; set; }
        public DateTime EndDatePeriod { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PatronicName { get; set; }
        public DateTime ActDateControl { get; set; }
        public string NumberOfWarning { get; set; }
        public DateTime WarningDate { get; set; }
        public DateTime WarningEndDate { get; set; }
        public DateTime DateOfPenalty { get; set; }
        public string DocNumPenalty { get; set; }
        public string PenaltySum { get; set; }
        public DateTime DateOfPenaltyPay { get; set; }
        public DateTime AnulmentDate { get; set; }
        public string NumberOfAnulment { get; set; }
        public DateTime DateOfSuit { get; set; }
        public string NumberOfSuit { get; set; }
        public DateTime DateOfSuitPerm { get; set; }
        public string NumberOfSuitPerm { get; set; }
        public string DictMediaSuitPermId { get; set; }
        public string UsersId { get; set; }
    }

}
