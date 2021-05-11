using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
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
        public string Role { get; set; }
    }
}

