using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarkhanaBook.Models.Login
{
    public class User
    {
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password{ get; set; }
        public string ContactNumber { get; set; }
        public string AlternetContactNumber { get; set; }
        public Models.Common.IntegerNullString Role { get; set; } = new Models.Common.IntegerNullString();
    }
}
