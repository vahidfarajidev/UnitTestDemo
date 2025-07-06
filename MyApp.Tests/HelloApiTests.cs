using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace MyApp.Tests
{
    public class HelloApiTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public HelloApiTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_Should_ReturnHelloWorld_When_Called()
        {
            var response = await _client.GetAsync("/api/hello");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("Hello, World!", content);
        }
    }
}
