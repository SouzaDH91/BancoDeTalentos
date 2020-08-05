using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Developer
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Skype { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        public string Portfolio { get; set; }
        public string Disponibility { get; set; }
        public string BestHour { get; set; }
        [Required]
        public double Requirements { get; set; }
    }
}