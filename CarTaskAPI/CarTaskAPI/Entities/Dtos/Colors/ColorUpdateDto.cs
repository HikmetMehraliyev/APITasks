using System.ComponentModel.DataAnnotations;

namespace CarTaskAPI.Entities.Dtos.Colors
{
    public class ColorUpdateDto
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
