using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5a.Models
{
    public class LoginModel
    {
        public string Name { get; set; }

        //[RegularExpression("open sesame", ErrorMessage = "Must enter correct password")]
        public string Password { get; set; }
    }
}
