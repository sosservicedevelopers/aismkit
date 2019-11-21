using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AisMKIT.Models
{
    public class Departments
    {
        public int Id { get; set; }
        [Display(Name="Наименование")]
        [Required(ErrorMessage ="Наименование департамента обязательна")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contacts { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
