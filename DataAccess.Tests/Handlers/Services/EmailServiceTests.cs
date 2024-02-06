using System.Threading;
using System.Threading.Tasks;
using DataAccess.Enums;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using Moq;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace DataAccess.Tests.Handlers.Services
{
    public class EmailServiceTests
    {
        private IEmailService _sut;

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
    }
}
