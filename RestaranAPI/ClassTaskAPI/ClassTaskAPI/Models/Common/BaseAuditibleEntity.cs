namespace ClassTaskAPI.Models.Common;

public class BaseAuditibleEntity:BaseEntity
{
	public DateTime CreatedAt { get; set; }
	public DateTime? UpdateAt { get; set; }
}
