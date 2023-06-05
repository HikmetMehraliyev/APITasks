using System.ComponentModel.DataAnnotations;

namespace CarTaskAPI.Entities.Dtos.Colors
{
    public class ColorCreateDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
