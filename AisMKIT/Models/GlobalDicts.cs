using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AisMKIT.Models
{

    // Регионы (области)
    public class DictRegion
    {
        public int Id { get; set; }

        [Display(Name = "Регион (кырг.)")]
        public string NameKyrg { get; set; }

        [Display(Name = "Регион (рус.)")]
        public string NameRus { get; set; }

    }

    // Район
    public class DictDistrict
    {

        public int Id { get; set; }

        [Display(Name = "Район (кырг.)")]
        public string NameKyrg { get; set; }

        [Display(Name = "Район (рус.)")]
        public string NameRus { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Регион")]
        public int DictRegionId { get; set; }

        [Display(Name = "Регион")]
        public DictRegion DictRegion { get; set; }

    }

}
