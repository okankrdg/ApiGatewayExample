using User.Domain.DTOS;

namespace User.Domain.Services
{
    public interface IUserService
    {
        UserDTO GetUserByUsername(string username);
    }
}
