using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleInjectorAOPTest.DataProviders.Interfaces;
using SimpleInjectorAOPTest.Models;

namespace SimpleInjectorAOPTest.DataProviders
{
    public class UserDataProvider : IUserDataProvider
    {
        public async Task<List<User>> GetUsers(int typeID)
        {
            var users = new List<User>();
            for (var i = 0; i <= 10000; i++)
            {
                var user = new User();
                user.FirstName = "Joe" + i;
                user.LastName = "Banken" + i;
                user.ID = i;
                user.BirthDate = new DateTime(1986,1,1);
                user.TypeID = i % 2 >= 1 ? 1 : 2;
                users.Add(user);
            }

            return users;
        }
    }
}