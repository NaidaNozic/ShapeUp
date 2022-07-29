using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class DayVeza
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Day")]
        public int DayId { get; set; }
        public Day Day { get; set; }
        [ForeignKey("Program1")]
        public int Program1Id { get; set; }
        public Program1 Program1 { get; set; }
        public DayVeza() { }
    }
}
