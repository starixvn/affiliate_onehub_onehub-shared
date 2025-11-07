using ONEHub.Shared.Models;

namespace ONEHub.Shared.Services.Interfaces;

public interface IUnderMaintenanceService
{
    Task<ScheduleMaintenance> GetUnderMaintenanceInfoAsync();

    Task<ScheduleMaintenance> SyncUnderMaintenanceInfoAsync();

    Task<bool> GetIsUnderMaintenanceByDomainAsync(string domain);
}
