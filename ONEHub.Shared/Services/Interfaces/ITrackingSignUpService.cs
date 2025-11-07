using ONEHub.Shared.Commands;
using ONEHub.Shared.Models;

namespace ONEHub.Shared.Services.Interfaces;

public interface ITrackingSignUpService
{
    Task WriteLogSignUp(SignUpRequest signUpRequest);

    Task<CommandResult> WriteLogSignUpToDatabase(SignUpRequest signUpRequest);
}
