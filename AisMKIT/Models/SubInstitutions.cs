using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AisMKIT.Models
{
    public class ListOfSubInstitutions
    {
    
        public int Id { get; set; }

        [Display(Name = "Наименование (рус.)")]
        public string NameRus { get; set; }

        [Display(Name = "Наименование (кырг.)")]
        public string NameKyrg { get; set; }

        [Display(Name = "ИНН")]
        public string INN { get; set; }

        [Display(Name = "Вид")]
        public int DictTypeOfSubId { get; set; }

        [Display(Name = "Вид")]
        public DictTypeOfSub DictTypeOfSub { get; set; } 

        [Display(Name = "Факс")]
        public string Fax { get; set; }

        [Display(Name = "Электронная почта")]
        public string Email { get; set; }

        [Display(Name = "Дата основания")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfCreated { get; set; }

        [Display(Name = "Краткая информация")]
        public string BriefInfo { get; set; }

        [Display(Name = "Регион")]
        public int DictRegionId { get; set; }
        [Display(Name = "Регион")]
        public DictRegion DictRegion { get; set; }

        [Display(Name = "Район")]
        public int DictDistrictId { get; set; }
        [Display(Name = "Район")]
        public DictDistrict DictDistrict { get; set; }

        [Display(Name = "Адрес (Руск)")]
        public string AddressRus { get; set; }

        [Display(Name = "Адрес (Кырг)")]
        public string AddressKyrg { get; set; }

    }

    public class DictTypeOfSub
    {
        public int Id { get; set; }

        [Display(Name = "Наименование вида (кырг.)")]
        public string NameKyrg { get; set; }

        [Display(Name = "Наименование вида (рус.)")]
        public string NameRus { get; set; }
    }


}
