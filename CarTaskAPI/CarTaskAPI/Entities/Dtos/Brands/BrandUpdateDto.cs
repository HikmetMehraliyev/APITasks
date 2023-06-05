using System.ComponentModel.DataAnnotations;

namespace CarTaskAPI.Entities.Dtos.Brands
{
    public class BrandUpdateDto
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
