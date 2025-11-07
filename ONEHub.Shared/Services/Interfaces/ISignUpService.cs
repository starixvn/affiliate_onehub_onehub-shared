using ONEHub.Shared.Models;

namespace ONEHub.Shared.Services.Interfaces;

public interface ISignUpService
{
    Task<RecaptchaInfo> GetRecaptchaInfoAsync(string langCode, string domain);

    Task<NumberCaptchaResponse> GetNumberCaptchaAsync(string langCode);

    Task SaveNumberCaptchaToCacheAsync(string clientIpAddress, NumberCaptchaData numberCaptcha);

    Task<ExistsEmailResponse> CheckExistsEmailAsync(string email, string langCode);

    Task<AffiliateCheckResponse> CheckAffiliateAsync(string affCode, string langCode);

    Task<ExistsUserNameResponse> CheckExistsUserNameAsync(string username, string langCode);

    Task<SignUpResponse> SignUpAsync(RegisterForm registerForm);
}
