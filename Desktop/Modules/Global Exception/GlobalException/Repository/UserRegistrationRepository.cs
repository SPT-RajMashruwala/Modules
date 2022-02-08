using GlobalException.Model;
using GlobalExceptionModuleContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GlobalException.Repository
{
    public class UserRegistrationRepository : IUserRegistrationRepository
    {
        public Result AddUser(UserModel userModel) 
        {
            GlobalExceptionModuleDataContext context = new GlobalExceptionModuleDataContext();
            User u = new User();
            u.UserName = userModel.UserName;
            u.EmailAddress = userModel.EmailAddress;
            var qs = (from obj in context.Users
                      where obj.EmailAddress == userModel.EmailAddress
                      select obj).SingleOrDefault();
            if (qs == null)
            {
                throw new ArgumentException("Email Address Already exists");
            }
            else
            {


                context.Users.InsertOnSubmit(u);
                context.SubmitChanges();
                Result result = new Result()
                {
                    Status = Result.ResultStatus.success,
                    StatusCode = (int)HttpStatusCode.OK,
                    Message = "User Added Successfully"
                };
            return result;
            }
        }
    }
}
