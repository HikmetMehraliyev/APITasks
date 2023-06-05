using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ClassTaskAPI.Utilities.Exceptions;

public class NotFoundDataException:Exception
{
    public NotFoundDataException():base() { }
    public NotFoundDataException(string message):base(message) { }
}
