using System.ComponentModel.DataAnnotations;

namespace ClassTaskAPI.Models.Dtos.Product
{
    public class CreateProductDto
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int RestarantId { get; set; }
        public Restaran Restaurant { get; set; }
    }
}
