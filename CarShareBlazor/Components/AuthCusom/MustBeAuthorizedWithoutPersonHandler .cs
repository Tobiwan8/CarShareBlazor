using CarShareBlazor.Data;
using CarShareBlazor.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace CarShareBlazor.Components.AuthCusom
{
    public class MustBeAuthorizedWithoutPersonHandler : AuthorizationHandler<MustBeAuthorizedWithoutPersonRequirement>
    {
        private readonly UserManager<UserModel> _userManager;

        public MustBeAuthorizedWithoutPersonHandler(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, MustBeAuthorizedWithoutPersonRequirement requirement)
        {
            // Check if the user is authenticated
            if (!context.User.Identity!.IsAuthenticated)
            {
                context.Fail(); // User is not authenticated
                return;
            }

            // Get the user ID of the currently logged-in user
            var userID = context.User.FindFirstValue("UserID");
            if (string.IsNullOrEmpty(userID))
            {
                context.Fail(); // User ID not found
                return;
            }

            // Check if the user has a PersonModel linked to their UserModel
            var user = await _userManager.FindByIdAsync(userID);
            if (user == null)
            {
                context.Fail(); // User not found
                return;
            }

            // Your logic to check if the user has a linked PersonModel
            // For example, check if the user has a linked PersonModel in the database
            CheckIfUserHasPerson checkPerson = new();
            var hasPerson = checkPerson.CheckIfUserHasPersonAsync(Convert.ToInt32(userID));

            if (hasPerson is null)
            {
                context.Fail(); // User is not authorized (already has a linked PersonModel)
                return;
            }

            context.Succeed(requirement); // User meets the requirement
        }
    }
}
