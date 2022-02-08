using IdentityServer4.Models;
using LOGINContext;
using LoginModule.Model;
using LoginModule.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace LoginModule.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenServices _tokenService;

        public LoginRepository(IConfiguration configuration, ITokenServices tokenService)
        {
            _configuration = configuration;
            _tokenService = tokenService;
         
        }


        //To add new role
        public async Task<string> AddRole(AddRoleModel roleModel)
        {
            using (LOGINDataContext context = new LOGINDataContext())
            {
                Role role = new Role();
                role.RoleName = roleModel.RoleName;
                var check = context.Roles.FirstOrDefault(x => x.RoleName == roleModel.RoleName);

                if (check != null)
                {
                    return "Role Already Exist";
                }
                else
                {
                    context.Roles.InsertOnSubmit(role);
                    context.SubmitChanges();
                    return "Roles Added Successfully";
                    
                }
            }
        }

        //To register user details
        public async Task<String> SignUP(SignUPModel signUPModel)
        {
            LOGINDataContext context = new LOGINDataContext();
            User user = new User();
            Role role = new Role();
            var query = (from user1 in context.Users
                         join r1 in context.Roles
                         on user1.RoleID equals r1.RoleID
                         where user1.EmailAddress == signUPModel.EmailAddress && user1.UserName == signUPModel.UserName
                         select new
                         {
                             r1.RoleName
                         }).Count();
            if (query != 0)
            {
                throw new ArgumentException("User Already Exists");
            }
            else
            {
                user.UserName = signUPModel.UserName;
                user.Password = signUPModel.Password;
                user.RoleID = 2;
                user.EmailAddress = signUPModel.EmailAddress;
                context.Users.InsertOnSubmit(user);
                context.SubmitChanges();
                return "SignUP Successfully";
            }
        }

        public  async Task<string > SignIN(SignINModel signINModel)
        {
            LOGINDataContext context = new LOGINDataContext();
            User user = new User();
            Role role = new Role();

            var res = (from u1 in context.Users
                       where u1.EmailAddress == signINModel.EmailAddress && u1.Password == signINModel.Password
                       join r1 in context.Roles
                       on u1.RoleID equals r1.RoleID into Login
                       from l1 in Login
                       select new
                       {
                           UserID = u1.UserID,
                           RoleID = u1.RoleID,
                           RoleName = l1.RoleName,
                       }).FirstOrDefault();
            if (res != null)
            {
                var authclaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,signINModel.EmailAddress),
                    new Claim (ClaimTypes.Role,res.RoleName),
                    new Claim (ClaimTypes .Sid ,res.UserID .ToString()),
                    new Claim (JwtRegisteredClaimNames.Jti,Guid.NewGuid ().ToString ()),
                };
                var jwtToken = _tokenService.GenerateAccessToken(authclaims);
                var refreshToken = _tokenService.GenerateRefreshToken();
                Refreshtoken refreshToken1 = new Refreshtoken();
                refreshToken1.RefreshToken= refreshToken;
                context.Refreshtokens.InsertOnSubmit(refreshToken1);
                context.SubmitChanges();

                UsersRefreshToken userRefreshToken = new UsersRefreshToken();
                userRefreshToken.UserID = res.UserID;
                userRefreshToken.RefreshTokenID= refreshToken1.RefreshTokenID;
                context.UsersRefreshTokens.InsertOnSubmit(userRefreshToken);
                context.SubmitChanges();

                return $"Login(SIGN IN) Successful,JWTToken : {jwtToken}";
                
                //return new ObjectResult(new
                //{
                //    token = jwtToken,
                //    refreshToken = refreshToken
                //});
            }
            else
            {
                throw new ArgumentException("Please Enter valid login details");
            }
        }

    }
}
