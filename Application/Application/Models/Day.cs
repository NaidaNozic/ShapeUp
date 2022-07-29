using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Day
    {
        [Key]
        public int Id { get; set; }
        public WeekDays Days { get; set; }
        public string User { get; set; }
        public Day() { }
    }
}
