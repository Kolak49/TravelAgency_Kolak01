﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Domain.LoginAndRegistration;

namespace TravelAgency.Domain.LoginAndRegistration
{
    public class LoginViewModel
    {
        [Required(ErrorMessage= "Введите почту")]
        [EmailAddress(ErrorMessage = "Некорректный адресс электронной почты")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль" )]
        public string Passord { get; set; }

    }
}
