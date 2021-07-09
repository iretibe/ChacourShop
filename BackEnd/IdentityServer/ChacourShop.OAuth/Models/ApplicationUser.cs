using Microsoft.AspNetCore.Identity;

namespace ChacourShop.OAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
