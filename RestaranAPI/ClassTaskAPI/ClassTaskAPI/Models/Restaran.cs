using ClassTaskAPI.Models.Common;

namespace ClassTaskAPI.Models;

public class Restaran:BaseAuditibleEntity
{
	public string Name { get; set; }
	public List<Product> Product { get; set; }
}
