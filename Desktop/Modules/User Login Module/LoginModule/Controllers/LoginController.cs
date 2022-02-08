using Devart.Data.Linq.Mapping.Fluent;
using IdentityServer4.Services;
using LoginModule.Model;
using LoginModule.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _accountRepository;
  /*      private readonly IConfiguration _configuration;*/
    /*    private readonly ITokenService tokenService;*/

        public LoginController(ILoginRepository accountRepository /*IConfiguration configuration,*/ /*ITokenService tokenService*/)
        {
            _accountRepository = accountRepository;
       /*     _configuration = configuration;*/
          /*  this.tokenService = tokenService;*/
        }

        [HttpPost("addRole")]
        public async Task<IActionResult> RoleAdded(AddRoleModel roleModel)
        {
            var result = _accountRepository.AddRole(roleModel);
            return Ok(result.Result);
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUPModel userModel)
        {
            //string rname = (string)HttpContext.Items["Rolename"];
            //if (rname == "SuperAdmin")
            //{
            var result = _accountRepository.SignUP(userModel);
            return Ok(result.Result);
            //}
            //return Unauthorized();
        }

        [HttpPost("SIgnIN")]
        public async Task<IActionResult> SignIn([FromBody] SignINModel signINModel)
        {
            var result = _accountRepository.SignIN(signINModel);
            return Ok(result.Result);
        }

     /*   [HttpGet("gettoken")]
        public ActionResult<string> GetToken()
        {*/
          /*  int uid = (int)HttpContext.Items["UserId"];*/
         /*   return Ok(uid);
*/
            //var isClaim = User.Claims.FirstOrDefault(x => x.Type.ToString().Equals(ClaimTypes.Name, StringComparison.InvariantCultureIgnoreCase));
            //if (isClaim != null)
            //{
            //    var id = isClaim.Value;
            //    var name1 = User.Identity.Name;

            //    return Ok(name1);
            //}
            //else
            //{
            //    return BadRequest("no");
            //}
        }
    }

