﻿using Bugs4Bugs.Views.Account;
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


        public async Task<string> TryRegisterAsync(RegisterVM viewModel)
        {
            // Todo: Try to create a new user
            var user = new SiteUser
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                UserName = viewModel.UserName,
                Email = viewModel.Email,
                PasswordHash = viewModel.Password,
            };

            IdentityResult result = await
                userManager.CreateAsync(user, viewModel.Password);

            bool wasUserCreated = result.Succeeded;
            if (wasUserCreated)
            {
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

        internal void LogOut()
        {
            signInManager.SignOutAsync();
        }

    }
}
