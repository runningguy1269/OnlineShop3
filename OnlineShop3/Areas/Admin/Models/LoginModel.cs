using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop3.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter user name !")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter pass word !")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}