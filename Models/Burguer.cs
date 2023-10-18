using System.ComponentModel.DataAnnotations;

namespace CrudPractica.Models
{
    public class Burguer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, 99.99)]
        public decimal Price  { get; set; }
    }
}
