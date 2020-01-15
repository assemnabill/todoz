using Microsoft.AspNetCore.Identity;

namespace ToDoz.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomTag { get; set; }
    }
}