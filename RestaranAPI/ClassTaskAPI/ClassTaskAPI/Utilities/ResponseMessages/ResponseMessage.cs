using System.Net;

namespace ClassTaskAPI.Utilities.ResponseMessages;

public class ResponseMessage
{
    public HttpStatusCode StatusCode { get; set; }
    public string? Message { get; set; }
    public object? Data { get; set; }
}
