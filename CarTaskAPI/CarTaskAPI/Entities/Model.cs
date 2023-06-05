using System.ComponentModel.DataAnnotations;

namespace CarTaskAPI.Entities
{
    public class Model
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required,MaxLength(255)]
        public string Description { get; set; }
        public int ModelYear { get; set; }
        public string DailyPrice { get; set; }
        public int BrandId { get; set; }
        public List<Brand> Brand { get; set; }
        public int ColorId { get; set; }
        public List<Color> Color { get; set; }
    }
}
