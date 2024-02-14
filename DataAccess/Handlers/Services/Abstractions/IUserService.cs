using DataAccess.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IUserService
    {
        Task<StatusMessage> UpdatePasswordAsync(string newPassword, string name);
        Task<IdentityUser> GetUserAsync(string username);
    }
}
