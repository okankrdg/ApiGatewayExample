using System;
using User.Domain.DTOS;
using User.Domain.Services;

namespace User.Infastructure.Services
{
    public class UserService : IUserService
    {
        public UserDTO GetUserByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            var dto = new UserDTO
            {
                Name = "Okan Can",
                Surname = "Karadağ",
                BirthDate = new DateTime(1997, 10, 9),
                Username = username
            };
            return dto;
        }
    }
}
