using Microsoft.AspNetCore.Identity;

namespace News.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Address { get; set; }
    }
}
