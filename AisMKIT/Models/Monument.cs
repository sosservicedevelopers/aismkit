using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AisMKIT.Models
{
    public class ListOfMonument
    {
        public int Id { get; set; }

        [Display(Name = "Наименование памятника")]
        public string Name { get; set; }

        [Display(Name = "Типологическая принадлежность")]
        public int DictTypeOfMonumentId { get; set; }
        [Display(Name = "Типологическая принадлежность")]
        public DictTypeOfMonument DictTypeOfMonument { get; set; }

        [Display(Name = "Датировка памятника")]
        public string DateOfMonument { get; set; }

        [Display(Name = "Регион")]
        public int DictRegionId { get; set; }
        [Display(Name = "Регион")]
        public DictRegion DictRegion { get; set; }

        [Display(Name = "Район")]
        public int DictDistrictId { get; set; }
        [Display(Name = "Район")]
        public DictDistrict DictDistrict { get; set; }

        [Display(Name = "Адрес (местонахождение памятника)")]
        public string Address { get; set; }
    }

    public class DictTypeOfMonument
    {
        public int Id { get; set; }


        [Display(Name = "Наимование типа (кырг.)")]
        public string NameKyrg { get; set; }

        [Display(Name = "Наимование типа (рус.)")]
        public string NameRus { get; set; }

    }

}
