using APIDevelopment.DTO;
using APIDevelopment.Interfaces;
using Entities;
using Entities.Models;

namespace APIDevelopment.Services
{
    public class UserDetailsServices : IUserDetails
    {
        public readonly ApplicationContext _dbcontext;
        public UserDetailsServices(ApplicationContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<string> CreateUserDetails(UserDetailsDTO UDD)
        {
            UserDetails userDetails = new UserDetails()
            {
                Name = UDD.Name,
                EmailAddress = UDD.Email,
            };

            await _dbcontext.Users.AddAsync(userDetails);
            await _dbcontext.SaveChangesAsync();
            return "UserDetails Added Successfully!";
        }
    }
}
