using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AisMKIT.Models
{
    // Реестр и схожие таблицы
    // Реестр ТЗУ
    public class ListOfTheatrical
    {
        public int Id { get; set; }

        [Display(Name = "Наименование ТЗУ (рус.)")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string NameRus { get; set; }

        [Display(Name = "Наименование ТЗУ (кырг.)")]
        public string NameKyrg { get; set; }

        [Display(Name = "Организационно-правовая форма")]
        public int? DictTheatricalLegalFormId { get; set; }

        [Display(Name = "Организационно-правовая форма")]
        public DictTheatricalLegalForm DictTheatricalLegalForm { get; set; }

        [Display(Name = "ИНН")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string INN { get; set; }

        [Display(Name = "Фамилия директора")]
        public string LastNameDirector { get; set; }

        [Display(Name = "Имя директора")]
        public string FirstNameDirector { get; set; }

        [Display(Name = "Отчество директора")]
        public string PatronicNameDirector { get; set; }

        [Display(Name = "Фамилия худ. руков.")]
        public string LastNameOfArtsDirector { get; set; }

        [Display(Name = "Имя худ. руков.")]
        public string FirstNameOfArtsDirector { get; set; }

        [Display(Name = "Отчество худ. руков.")]
        public string PatronicNameOfArtsDirector { get; set; }

        [Display(Name = "Количество штатных единиц")]
        public int? NumEmployees { get; set; }

        [Display(Name = "Источник финансирования")]
        public int? DictTheatricalFinSourceId { get; set; }

        [Display(Name = "Источник финансирования")]
        public DictTheatricalFinSource DictTheatricalFinSource { get; set; }

        [Display(Name = "Дата перерегистрации")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ReregistrationDate { get; set; }

        [Display(Name = "Дата ликвидации")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DeactiveDate { get; set; }

    }

    // Таблица Членов художественного совета
    public class ListOfCouncilTheatrical
    {
        public int Id { get; set; }

        
        [Display(Name = "Театрально-зрелищное учреждение")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public int ListOfTheatricalId { get; set; }

        [Display(Name = "Театрально-зрелищное учреждение")]
        public ListOfTheatrical ListOfTheatrical { get; set; }


        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string LastNameOfArts { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string FirstNameOfArts { get; set; }

        [Display(Name = "Отчество")]
        public string PatronicNameOfArts { get; set; }

        [Display(Name = "Дата включения в худ. совет ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateInArtCouncil { get; set; }

        [Display(Name = "Дата выхода из худ. совета")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateOutArtCouncil { get; set; }
    }

    public class ArtsCouncilTheatricalHistory
    {

    }

    // Репартуары
    public class ListOfEventsTheatrical
    {
        public int Id { get; set; }

        [Display(Name = "Театрально-зрелищное учреждение")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public int ListOfTheatricalId { get; set; }

        [Display(Name = "Театрально-зрелищное учреждение")]
        public ListOfTheatrical ListOfTheatrical { get; set; }

        [Display(Name = "Год")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string Year { get; set; }

        [Display(Name = "Месяц")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string Month { get; set; }

        [Display(Name = "День")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string DayOfMonth { get; set; }

        [Display(Name = "Время")]
        public string Time { get; set; }

        [Display(Name = "Наименование мероприятия")]
        [Required(ErrorMessage = "Обязательно заполните")]
        public string NameOfEvent { get; set; }

        [Display(Name = "Наименование зала")]
        public string NameOfHall { get; set; }
    }


    // Справочники

    // Организационно-правовая форма
    public class DictTheatricalLegalForm
    {
        public int Id { get; set; }

        [Display(Name = "Организационно-правовая форма (Кырг)")]
        public string NameKyrg { get; set; }

        [Display(Name = "Организационно-правовая форма (Русск)")]
        public string NameRus { get; set; }

    }

    // Источник финансирования
    public class DictTheatricalFinSource
    {
        public int Id { get; set; }

        [Display(Name = "Источник финансирования (Кырг)")]
        public string NameKyrg { get; set; }

        [Display(Name = "Источник финансирования (Русск)")]
        public string NameRus { get; set; }

    }
}
