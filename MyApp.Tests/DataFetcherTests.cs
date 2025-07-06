using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using FluentAssertions;
using MyApp.Asyncs;

namespace MyApp.Tests
{
    public class DataFetcherTests
    {
        [Fact]
        public async Task Should_Return_Formatted_Data()
        {
            // Arrange
            var remote = Substitute.For<IRemoteService>();
            remote.FetchDataAsync().Returns(Task.FromResult("123"));

            // Act
            var fetcher = new DataFetcher(remote);
            var result = await fetcher.GetFormattedData();

            // Assert
            result.Should().Be("[DATA]: 123");
        }

        [Fact]
        public async Task Should_Return_Status_Message()
        {
            // Arrange
            var remote = Substitute.For<IRemoteService>();
            remote.GetStatusCodeAsync().Returns(Task.FromResult(500));

            // Act
            var fetcher = new DataFetcher(remote);
            var result = await fetcher.GetStatusMessage();

            // Assert
            result.Should().Be("FAIL");
        }
    }
}
