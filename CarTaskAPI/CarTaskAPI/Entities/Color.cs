using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace CarTaskAPI.Entities
{
    public class Color
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
    }
}
