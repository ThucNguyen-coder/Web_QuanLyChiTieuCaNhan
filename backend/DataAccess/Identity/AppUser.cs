using Microsoft.AspNetCore.Identity;

namespace DataAccess.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}