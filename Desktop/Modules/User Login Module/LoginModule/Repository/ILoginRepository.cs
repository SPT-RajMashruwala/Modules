using LoginModule.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginModule.Repository
{
    public interface ILoginRepository
    {
        Task<string> AddRole(AddRoleModel roleModel);
        Task<String> SignUP(SignUPModel signUPModel);
        Task<string> SignIN(SignINModel signINModel);
    }
}
