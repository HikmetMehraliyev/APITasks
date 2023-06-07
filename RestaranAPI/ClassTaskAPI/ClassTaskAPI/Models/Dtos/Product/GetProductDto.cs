using System.ComponentModel.DataAnnotations;

namespace ClassTaskAPI.Models.Dtos.Product
{
    public class GetProductDto
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
