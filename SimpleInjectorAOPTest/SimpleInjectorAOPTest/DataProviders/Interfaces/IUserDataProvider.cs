using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SimpleInjectorAOPTest.DataProviders.Interfaces
{
    public interface IUserDataProvider
    {
        Task<List<Models.User>> GetUsers(int typeID);
    }
}