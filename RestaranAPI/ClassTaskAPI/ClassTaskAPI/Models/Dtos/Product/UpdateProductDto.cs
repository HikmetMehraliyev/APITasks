using ClassTaskAPI.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ClassTaskAPI.Models.Dtos.Product
{
    public class UpdateProductDto:BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int RestarantId { get; set; }
        public Restaran Restaurant { get; set; }
    }
}
