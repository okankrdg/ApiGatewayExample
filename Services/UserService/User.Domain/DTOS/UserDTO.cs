using System;

namespace User.Domain.DTOS
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age => BirthDate.HasValue ? DateTime.Now.Year - BirthDate.Value.Year : (int?)null;
    }
}
