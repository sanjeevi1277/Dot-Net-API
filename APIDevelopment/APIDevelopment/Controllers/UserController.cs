using APIDevelopment.DTO;
using APIDevelopment.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIDevelopment.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly ApplicationContext _dbcontext;
        private readonly IUserDetails _userdetails;
        public UserController(ApplicationContext dbcontext, IUserDetails userdetails)
        {
            _dbcontext = dbcontext;
            _userdetails = userdetails;
        }
        [HttpPost]
        [Route("createuser")]
        public Task<string> CreateUser(UserDetailsDTO user)
        {
            var res = _userdetails.CreateUserDetails(user);
            return res;
        }

    }
}
