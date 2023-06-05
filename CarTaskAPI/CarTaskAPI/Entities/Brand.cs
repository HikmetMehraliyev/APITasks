using System.ComponentModel.DataAnnotations;

namespace CarTaskAPI.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
    }
}
