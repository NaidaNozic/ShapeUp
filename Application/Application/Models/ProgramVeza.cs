using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ProgramVeza
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Program1")]
        public int Program1Id { get; set; }
        public Program1 Program1 { get; set; }
        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public ProgramVeza() { }
    }
}
