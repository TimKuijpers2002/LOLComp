using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "You need to fill this in!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to fill this in!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public static User ConvertViewModelToModel(UserLoginViewModel viewmodel)
        {
            var _model = new User(0, "null", viewmodel.Email, viewmodel.Password, "null");
            return _model;
        }
    }
}
