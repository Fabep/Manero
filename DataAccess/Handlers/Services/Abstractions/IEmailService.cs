using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IEmailService
    {
        Task<StatusMessage> SendEmailAsync(string email, string htmlContent, string subject);
    }
}
