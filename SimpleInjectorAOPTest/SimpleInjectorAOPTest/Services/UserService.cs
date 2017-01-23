using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SimpleInjectorAOPTest.DataProviders.Interfaces;
using SimpleInjectorAOPTest.Models;
using SimpleInjectorAOPTest.Services.Interfaces;

namespace SimpleInjectorAOPTest.Services
{
    public class UserService : IUserService
    {
        public IUserDataProvider UserDataProvider { get; set; }
        public UserService(IUserDataProvider userDataProvider)
        {
            UserDataProvider = userDataProvider;
        }
        public async Task<List<User>> GetUsers(int typeID)
        {
            Debug.WriteLine("SimpleInjectorAOPTest===>Start Concreate");
            var users = await UserDataProvider.GetUsers(typeID);
            Debug.WriteLine("SimpleInjectorAOPTest===>End Concreate");
            return users;
        }
    }
}