using MyApp.Notifications;
using NSubstitute;

namespace MyApp.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void Should_Send_Email_When_Email_Is_Valid()
        {
            // Arrange
            var mockEmail = Substitute.For<IEmailService>();
            var notification = new Notification(mockEmail);

            // Act
            notification.Notify("test@example.com");

            // Assert
            mockEmail.Received().SendEmail("test@example.com", "Welcome!");
        }
    }
}
