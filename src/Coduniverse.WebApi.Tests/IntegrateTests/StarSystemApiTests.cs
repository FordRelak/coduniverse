using Coduniverse.WebApi.Models;
using System.Net;
using System.Net.Http.Json;
using Xunit;

namespace Coduniverse.WebApi.Tests.IntegrateTests
{
    public class StarSystemApiTests
    {
        private readonly HttpClient _client;

        public StarSystemApiTests()
        {
            var server = new TestWebApplication();
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET", "cc4c7511-e0d4-44c8-9b4e-e76aa607b8f1")]
        public async Task Get_Api_Valid(string method, string id)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), $"/api/StarSystem/{id}");

            var response = await _client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("GET", "30df21b6-43fa-4cb1-89c7-b4ce6228c491")]
        public async Task Get_Api_Error(string method, string id)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), $"/api/StarSystem/{id}");

            var response = await _client.SendAsync(request);

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Theory]
        [InlineData("/api/StarSystem")]
        public async Task Update_Api_Error(string url)
        {
            var content = JsonContent.Create(new StarSystemInput
            {
                Age = 1,
            });

            var response = await _client.PostAsync(url, content);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory]
        [InlineData("/api/StarSystem")]
        public async Task Update_Api_Ok(string url)
        {
            var content = JsonContent.Create(new StarSystemInput
            {
                Age = 1,
                Name = "1"
            });

            var response = await _client.PostAsync(url, content);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Theory]
        [InlineData("GET")]
        public async Task Get_Method_Error(string method)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), $"/api/UncorrectMethod");

            var response = await _client.SendAsync(request);

            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        }
    }
}