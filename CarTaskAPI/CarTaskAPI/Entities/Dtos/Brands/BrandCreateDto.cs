using System.ComponentModel.DataAnnotations;

namespace CarTaskAPI.Entities.Dtos.Brands
{
    public class BrandCreateDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
