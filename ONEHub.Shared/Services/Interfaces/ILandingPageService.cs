using ONEHub.Shared.Models;

namespace ONEHub.Shared.Services.Interfaces;

public interface ILandingPageService
{
    Task<LandingPage?> GetLandingPage(string pageCode, bool? refresh, bool? isPreview, int? pageId = null);

    Task<IEnumerable<LandingPage>> GetAllLandingPages(bool isPreview);

    Task SyncAllLandingPageToCache();
}
