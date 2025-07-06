using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Tests
{
    public class MiddlewareTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public MiddlewareTests(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task Get_Should_Add_CustomHeader_When_Called()
        {
            // Act
            var response = await _httpClient.GetAsync("/api/hello");

            response.EnsureSuccessStatusCode();

            Assert.True(response.Headers.Contains("X-Custom-Header"));

            var headerValue = response.Headers.GetValues("X-Custom-Header").FirstOrDefault();

            Assert.Equal("HelloFromMiddleware", headerValue);
        }
    }
}
