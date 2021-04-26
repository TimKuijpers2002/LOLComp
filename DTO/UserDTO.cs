using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
