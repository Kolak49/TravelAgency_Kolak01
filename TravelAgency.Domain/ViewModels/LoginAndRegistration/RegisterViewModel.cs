using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Domain.LoginAndRegistration;
namespace TravelAgency.Domain.LoginAndRegistration
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Укажите имя от 3 до 20 символов")]
        [MaxLength(20, ErrorMessage ="Имя должно иметь длину не более 20 символов")]
        [MinLength(3, ErrorMessage = "Имя должно иметь длину не менее 3 символов")]

        public string Login { get; set; }

        [EmailAddress(ErrorMessage = "Некорректный адресс электронной почты")]
        [Required(ErrorMessage = "Укажите почту")]

        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен иметь длину более 6 символов")]

        public string Passord { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password",ErrorMessage = "Пароли не совпадают")]


        public string PasswordConfirm { get; set; }
    }
}
