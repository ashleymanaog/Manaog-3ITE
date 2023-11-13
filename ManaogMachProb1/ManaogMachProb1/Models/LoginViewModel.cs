using System;
using System.ComponentModel.DataAnnotations;

namespace ManaogMachProb1.Models
{
    public class LoginViewModel
    {
        [Display(Name = "User Name")]
        [Required (ErrorMessage = "A username is required")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A password is required")]
        public string? Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

    }
}
