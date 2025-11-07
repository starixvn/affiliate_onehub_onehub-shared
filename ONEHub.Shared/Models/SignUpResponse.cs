namespace ONEHub.Shared.Models;

public class SignUpResponse : BaseResponse
{
    public IEnumerable<string>? Cookies { get; set; }

    public string NumberCaptCha { get; set; }
}
