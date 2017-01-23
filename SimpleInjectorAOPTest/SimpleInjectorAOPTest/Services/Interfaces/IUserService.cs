using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SimpleInjectorAOPTest.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<Models.User>> GetUsers(int typeID);
    }
}