using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class SavedVeza
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        [ForeignKey("Program1")]
        public int Program1Id { get; set; }
        public Program1 Program1 { get; set; }
        public SavedVeza() { }

    }
}
