using ONEHub.Shared.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace ONEHub.Shared.Services;

public class CacheKeyService : ICacheKeyService
{
    private readonly string applicationName;

    public CacheKeyService(IConfiguration configuration)
    {
        applicationName = configuration["fanex.caching.redis:ApplicationName"] ?? "Aff.12B.LandingPage.Dev";
    }

    public string GetLandingPageKey(string pageCode)
    {
        return $"{applicationName}:{CacheKey.LandingPage}_{pageCode}";
    }

    public string GetLandingPagePreviewKey(string pageCode, int pageId)
    {
        return $"{applicationName}:{CacheKey.LandingPagePreview}_{pageCode}_{pageId}";
    }

    public string GetAllLandingPageVersionKey()
    {
        return $"{applicationName}:{CacheKey.AllLandingPageVersion}";
    }

    public string GetSignUpKey()
    {
        return $"{applicationName}:{CacheKey.SignUp}";
    }

    public string GetRecaptchaInfoKey(string langCode, string domain)
    {
        return $"{applicationName}:{CacheKey.RecaptchaInfo}_{langCode}_{domain}";
    }

    public string GetUnderMaintainInfoKey()
    {
        return $"{applicationName}:{CacheKey.UnderMaintainInfo}";
    }

    public string GetNumberCaptchaKey()
    {
        return $"{applicationName}:{CacheKey.NumberCaptcha}";
    }
}

