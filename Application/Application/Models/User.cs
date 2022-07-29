using Microsoft.AspNetCore.Identity;

namespace Application.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string KorisnickoIme { get; set; }
        public string UserEmail { get; set; }
    }
}
