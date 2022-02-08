using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginModule.Model
{
    public class SignINModel
    {
        [Required(ErrorMessage = "UserName required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
        public string RefreshToken { get; set; }
    }
}
