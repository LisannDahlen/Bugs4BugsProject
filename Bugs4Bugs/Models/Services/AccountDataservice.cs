using Bugs4Bugs.Views.Account;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Identity;

namespace Bugs4Bugs.Models.Services
{
    public class AccountDataservice
    {
        UserManager<SiteUser> userManager;
        SignInManager<SiteUser> signInManager;
        RoleManager<IdentityRole> roleManager;

        public AccountDataservice(
            UserManager<SiteUser> userManager,
            SignInManager<SiteUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public async Task SetRole(string roleName)
        {

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            var userId = userManager.GetUserId(signInManager.Context.User);
            var user = await userManager.FindByIdAsync(userId);
            
            if (!await userManager.IsInRoleAsync(user, roleName))
            {
                await userManager.AddToRoleAsync(user, roleName);
            }
            await LogOut();
            await signInManager.SignInAsync(user, isPersistent: false);
        }

        public async Task<string> TryRegisterAsync(RegisterVM viewModel)
        {
            // Todo: Try to create a new user
            var user = new SiteUser
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                UserName = viewModel.UserName,
                Email = viewModel.Email,
                //PasswordHash = viewModel.Password,
            };
            
            
            IdentityResult result = await
                userManager.CreateAsync(user, viewModel.Password);

            bool userWasCreated = result.Succeeded;
            if (userWasCreated)
            {
                await userManager.AddToRoleAsync(user, "User");
                await signInManager.SignInAsync(user, isPersistent: false);
                return null;
            }
            return string.Join(" ", result.Errors.Select(e => e.Description));
        }

        public async Task<string> TryLoginAsync(LoginVM viewModel)
        {
            // Todo: Try to sign user
            SignInResult result = await signInManager.PasswordSignInAsync(
                viewModel.UserName,
                viewModel.Password,
                isPersistent: false,
                lockoutOnFailure: false
                );
            
            bool wasUserSignedIn = result.Succeeded;

            if (wasUserSignedIn)
            {
                return null;
            }

            return "Login failed";
        }

        internal async Task LogOut()
        {
            await signInManager.SignOutAsync();
        }

    }
}
