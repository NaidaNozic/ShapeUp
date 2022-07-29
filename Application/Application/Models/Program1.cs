
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Program1
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Type { get; set; }
        public int Reps { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Likes { get; set; }
        public int Saved { get; set; }
        public string User { get; set; }
        public Program1() { }
    }
}
