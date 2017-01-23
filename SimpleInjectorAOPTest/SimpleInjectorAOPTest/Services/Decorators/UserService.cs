using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using SimpleInjectorAOPTest.Models;
using SimpleInjectorAOPTest.Services.Interfaces;

namespace SimpleInjectorAOPTest.Services.Decorators
{
    public class UserService : IUserService
    {
        public IUserService UserServiceConcrete  { get; set; }

        public UserService(IUserService userServiceConcrete)
        {
            UserServiceConcrete = userServiceConcrete;
        }

        public async Task<List<User>> GetUsers(int typeID)
        {
            Debug.WriteLine("SimpleInjectorAOPTest===>Start Decorator");
            var users = await UserServiceConcrete.GetUsers(typeID);
            Debug.WriteLine("SimpleInjectorAOPTest===>End Decorator");
            return users;
        }
    }
}