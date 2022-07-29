using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class FollowingVeza
    {
        [Key]
        public int Id { get; set; }
        public string Original { get; set; }
        public string Following { get; set; }
        public FollowingVeza(){}
    }
}
