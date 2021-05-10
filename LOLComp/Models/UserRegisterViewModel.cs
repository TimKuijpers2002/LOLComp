using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class UserRegisterViewModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "You need to fill this in!")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "You need to fill this in!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to fill this in!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public static User ConvertViewModelToModel(UserRegisterViewModel viewmodel)
        {
            var _model = new User(0, viewmodel.Name, viewmodel.Email, viewmodel.Password, "User");
            return _model;
        }
    }
}
