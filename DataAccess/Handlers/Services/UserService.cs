using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using ManeroWebAppMVC.Data;
using DataAccess.Enums;
using DataAccess.Handlers.Services.Abstractions;

namespace DataAccess.Handlers.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;
        private readonly PasswordHasher<IdentityUser> _passwordHasher;

        public UserService(UserRepository repo)
        {
            _repository = repo;
            _passwordHasher = new PasswordHasher<IdentityUser>();
        }

        public async Task<IdentityUser> GetUserAsync(string name)
        {
            var result = await _repository.GetAsync(x => x.UserName == name);
            return result;
        }

        public async Task<StatusMessage> UpdatePasswordAsync(string newPassword, string name)
        {
            var user = await GetUserAsync(name);

            if (user != null)
            {
                // Hash the new password
                var hashedPassword = _passwordHasher.HashPassword(user, newPassword);
                user.PasswordHash = hashedPassword;

                // Save changes to the database
                var result = await _repository.UpdateAsync(user);

                if (result != null)
                {
                    return StatusMessage.Success;
                }
            }

            return StatusMessage.NotFound;
        }
    }
}
