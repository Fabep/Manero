using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Enums;
using DataAccess.Handlers.Services.Abstractions;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace DataAccess.Handlers.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _apiKey;
        private readonly IConfiguration _config;
        public EmailService(string apiKey) 
        {
            _apiKey = apiKey;
        }    
        public async Task<StatusMessage> SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(_apiKey);
            var from = new EmailAddress("lawe.zangena@edu.huddinge.se", "Lawe Zangena");
            var to = new EmailAddress(email, "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlMessage);
            var response = await client.SendEmailAsync(msg);

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                return StatusMessage.Success;
            }
            else
            {
                return StatusMessage.Error;
            }
        }
    }
}
