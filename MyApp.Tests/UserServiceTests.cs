using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using FluentAssertions;
using MyApp.Users;

namespace MyApp.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void Should_Return_Welcome_Message()
        {
            // Arrange
            var repo = Substitute.For<IUserRepository>();
            repo.GetUserName(1).Returns("Ali");

            // Act
            var service = new UserService(repo);
            var result = service.GetWelcomeMessage(1);

            // Assert
            result.Should().Be("Welcome, Ali");
        }
    }
}
