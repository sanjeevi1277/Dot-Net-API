using APIDevelopment.DTO;

namespace APIDevelopment.Interfaces
{
    public interface IUserDetails
    {
        Task<string> CreateUserDetails(UserDetailsDTO UDD);
    }
}
