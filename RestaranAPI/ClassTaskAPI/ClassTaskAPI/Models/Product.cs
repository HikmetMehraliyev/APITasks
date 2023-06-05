using ClassTaskAPI.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ClassTaskAPI.Models;

public class Product:BaseAuditibleEntity
{
	[Required,MaxLength(50)]
	public string Name { get; set; }
	public double Price { get; set; }
	public int RestarantId { get; set; }
	public Restaran Restaurant { get; set; }
}
