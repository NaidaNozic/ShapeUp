using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string KorisnickoIme { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ApplicationUser() { }
    }
}
