﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuLNU.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле електронна пошта є обов'язковим")]
        [EmailAddress(ErrorMessage = "Введене поле не є правильним для електронної пошти")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Введене поле не є правильним для електронної пошти")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле пароль є обов'язковим")]
        [MinLength(8, ErrorMessage ="Поле пароль повинне містити щонайменше 8 символів!")]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
