using GlobalException.Model;
using GlobalException.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalException.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRegistrationRepository userRegistration;

        public UserController(IUserRegistrationRepository userRegistration)
        {
            this.userRegistration = userRegistration;
        }

        [HttpPost("")]
        public  async Task<IActionResult> AddNewUser(UserModel userModel) 
        {
            var result = userRegistration.AddUser(userModel);
            return Ok(result);
        }

    }
}
