using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SimpleInjectorAOPTest.Services.Interfaces;

namespace SimpleInjectorAOPTest.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        public IUserService UserService { get; set; }
        public TestController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpGet]
        [Route("users")]
        public async Task<IHttpActionResult> Users()
        {
            var users = await UserService.GetUsers(1);
            return Ok(users);
        }
    }
}
