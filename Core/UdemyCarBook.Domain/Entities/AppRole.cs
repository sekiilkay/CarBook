using Microsoft.AspNetCore.Identity;

namespace UdemyCarBook.Domain.Entities
{
    public class AppRole
    {
        public int Id { get; set; }
        public string AppRoleName { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
