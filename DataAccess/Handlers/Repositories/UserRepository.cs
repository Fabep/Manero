using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ManeroWebAppMVC.Data;

namespace DataAccess.Handlers.Repositories
{
    public class UserRepository : Repository<IdentityUser, ApplicationDbContext>
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
