﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarsCRUD.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "RequiredField")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RequiredField")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
