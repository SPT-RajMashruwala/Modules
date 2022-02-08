using GlobalException.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalException.Repository
{
    public interface IUserRegistrationRepository
    {
        Result AddUser(UserModel userModel);
    }
}
