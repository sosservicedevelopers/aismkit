using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AisMKIT.Models
{
    public class EduInstitution
    {
        public int Id { get; set; }

        [Display(Name = "ИНН")]
        [Required(ErrorMessage = "ИНН обязательна")]
        public string INN { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование категории обязательна")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Адрес обязательна")]
        public string Address { get; set; }

        [Display(Name = "Доменое имя")]
        public string DomenNames { get; set; }

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


        [Display(Name = "Категория")]
        public int DictEduCategoryId { get; set; }
        [Display(Name = "Категория")]
        public DictEduCategory DictEduCategory { get; set; }

        // список факультетов 
        public IEnumerable<Faculty> ListFaculties { get; set; }

    }

    public class ListsEduInstitutions
    {
        public EduInstitution EduInstitution { get; set; }
        public IEnumerable<Faculty> Faculties { get; set; }
        public IEnumerable<FacultySpecialty> FacultySpecialties { get; set; }
        public IEnumerable<EmplPosHistory> EmplPosHistories { get; set; }
        public IEnumerable<EmplEducationalUnit> EmplEducationalUnits { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Specialty> Specialties { get; set; }
        public IEnumerable<EducationalUnit> EducationalUnits { get; set; }

    }


    // Здесь все дополнительные модели для модели Учебные Заведения
    //Категории учебных заведений
    public class DictEduCategory
{
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование категории обязательна")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Desciption { get; set; }
    }

    // Модель Факультет
    public class Faculty
    {
        public int Id { get; set; }

        [Display(Name = "Наименование факультета")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        // внешний ключ это Учебное заведение

        [Display(Name = "Учебное заведение")]
        public int? EduInstitutionId { get; set; }

        [Display(Name = "Учебное заведение")]
        public EduInstitution EduInstitution { get; set; }
    }

    // модель Специальность
    public class Specialty
    {
        public int Id { get; set; }

        [Display(Name = "Специальность")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
    }

    // модель-промежуточный для Факультет-Специальность 
    public class FacultySpecialty
    {
        public int Id { get; set; }


        [Display(Name = "Специальность")]
        public int? SpecialtyId { get; set; }
        [Display(Name = "Специальность")]
        public Specialty Specialty { get; set; }


        [Display(Name = "Факультет")]
        public int? FacultyId { get; set; }

        [Display(Name = "Факультет")]
        public Faculty Faculty { get; set; }
    }

    // модель Сотрудник
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string FirstName { get; set; }


        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }


        [Display(Name = "ФИО")]
        public string FullName { get { return FirstName + " " + SecondName; } set { } }

    }

    // модель Должность
    public class Position
    {
        public int Id { get; set; }

        [Display(Name = "Должность")]
        public string Name { get; set; }
    }

    // модель-промежуточный для Сотрудник-Должность
    public class EmplPosHistory
    {
        public int Id { get; set; }

        [Display(Name = "Сотрудник")]
        public int? EmployeeId { get; set; }

        [Display(Name = "Сотрудник")]
        public Employee Employee { get; set; }


        [Display(Name = "Должность")]
        public int? PositionId { get; set; }

        [Display(Name = "Должность")]
        public Position Position { get; set; }

        [Display(Name = "Начало работы")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime WorkStartDate { get; set; }

        [Display(Name = "Конец работы")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime WorkEndDate { get; set; }



        [Display(Name = "Факультет")]
        public int? FacultyId { get; set; }

        [Display(Name = "Факультет")]
        public Faculty Faculty { get; set; }
    }


    // модель Подразделение (Учебного заведения)
    public class EducationalUnit
    {
        public int Id { get; set; }

        [Display(Name = "Подразделение")]
        public string Name { get; set; }
    }

    // модель-промежуточный для Сотрудник-Подразделение
    public class EmplEducationalUnit
    {
        public int Id { get; set; }

        [Display(Name = "Сотрудник")]
        public int? EmployeeId { get; set; }
        [Display(Name = "Сотрудник")]
        public Employee Employee { get; set; }

        [Display(Name = "Подразделение")]
        public int? EducationalUnitId { get; set; }
        [Display(Name = "Подразделение")]
        public EducationalUnit EducationalUnit { get; set; }


        [Display(Name = "Начало работы")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime WorkStartDate { get; set; }

        [Display(Name = "Конец работы")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime WorkEndDate { get; set; }

        [Display(Name = "Факультет")]
        public int? FacultyId { get; set; }
        [Display(Name = "Факультет")]
        public Faculty Faculty { get; set; }
    }

}
