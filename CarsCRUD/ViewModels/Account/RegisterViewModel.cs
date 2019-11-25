using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarsCRUD.ViewModels
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage = "RequiredField")]
        [EmailAddress (ErrorMessage = "MustContainsEmail")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RequiredField")]
        [Display(Name = "BirthYear")]
        public int Year { get; set; }

        [Required(ErrorMessage = "RequiredField")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "RequiredField")]
        [Compare("Password", ErrorMessage = "Match")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public string PasswordConfirm { get; set; }
    }
}