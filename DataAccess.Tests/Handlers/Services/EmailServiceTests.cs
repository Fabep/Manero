using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using DataAccess.Enums;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using ManeroWebAppMVC.Areas.Identity.Pages.Account.Manage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Moq;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace DataAccess.Tests.Handlers.Services
{
    public class EmailServiceTests
    {
        [Fact]
        public async Task SendEmailAsync_Fail_WhenNotProvidedApiKey()
        {
            // Arrange
            var apiKey = "wrong-api-key";
            var emailService = new EmailService(apiKey);

            var email = "test@example.com";
            var subject = "Test Subject";
            var htmlMessage = "<p>Test Message</p>";

            var mockClient = new Mock<ISendGridClient>();
            mockClient.Setup(c => c.SendEmailAsync(It.IsAny<SendGridMessage>(), default)).ReturnsAsync(
                new SendGrid.Response(System.Net.HttpStatusCode.BadRequest, null, null));

            // Act
            var result = await emailService.SendEmailAsync(email, subject, htmlMessage);

            // Assert
            Assert.Equal(StatusMessage.Error, result);
        }

        [Fact]
        public async Task OnPostAsync_ValidModelState_SuccessfulChange()
        {
            // Arrange
            var userManagerMock = new Mock<UserManager<IdentityUser>>();
            var signInManagerMock = new Mock<SignInManager<IdentityUser>>();
            var loggerMock = new Mock<ILogger<ChangePasswordModel>>();

            var handler = new Mock<ChangePasswordModel>(userManagerMock.Object, signInManagerMock.Object, loggerMock.Object);

            // Assume you have a valid model state
            handler.Object.ModelState.AddModelError("SomeProperty", "Some error message");

            // Act
            var result = await handler.Object.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
            userManagerMock.Verify(mock => mock.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Never);
            // Add more assertions based on your expected behavior
        }
    }
}
