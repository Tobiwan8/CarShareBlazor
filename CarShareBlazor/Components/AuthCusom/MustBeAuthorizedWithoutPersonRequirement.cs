using Microsoft.AspNetCore.Authorization;

namespace CarShareBlazor.Components.AuthCusom
{
    public class MustBeAuthorizedWithoutPersonRequirement : IAuthorizationRequirement
    {
    }
}
