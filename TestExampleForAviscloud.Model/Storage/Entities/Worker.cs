using System;
using System.ComponentModel.DataAnnotations;

namespace TestExampleForAviscloud.Model.Storage.Entities
{
    public class Worker
    {
        [Display(Name = "ID работника")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Укажите ФИО работника")]
        [Display(Name = "ФИО работника")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите адрес электронной почты работника")]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите пол работника")]
        [Display(Name = "Пол")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Укажите дату рождения работника")]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                var worker = (Worker)obj;

                return Name != worker.Name && Email != worker.Email;
            }

            return false;
        }
    }
}
