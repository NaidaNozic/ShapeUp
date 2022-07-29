using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Reps { get; set; }
        public string Description { get; set; }
        public Workout() { }
    }
}
