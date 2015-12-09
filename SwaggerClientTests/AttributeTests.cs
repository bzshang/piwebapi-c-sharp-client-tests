using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

using Newtonsoft.Json;

using Xunit;

namespace PIWebAPICSharpClientTests
{
    public class AttributeTests
    {
        ApiClient client;
        IAttributeApi api;

        HttpClient httpClient;

        public AttributeTests()
        {
            client = new ApiClient(Resource.Base);
            client.AddDefaultHeader("Cache-Control", "no-cache");
            api = new AttributeApi(client);

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Resource.Base);
            httpClient.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
        }

        [Fact]
        public void GetAttribute()
        {
            AFWebAttribute attribute = api.GetAttribute(Resource.WebIdAttribute);
            string testResponse = JsonConvert.SerializeObject(attribute);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/attributes/{Resource.WebIdAttribute}")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetByPathAttribute()
        {
            AFWebAttribute attribute = api.GetByPathAttribute(Resource.WebIdAttribute);
            string testResponse = JsonConvert.SerializeObject(attribute);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/attributes/{Resource.WebIdAttribute}")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void UpdateAttribute()
        {
            AFWebAttribute test = new AFWebAttribute { Description = "hello" };
            api.UpdateAttribute(Resource.WebIdPatchAttribute, test);
            string testResponse = JsonConvert.SerializeObject(test);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/attributes/{Resource.WebIdPatchAttribute}")
                .Result.Content
                .ReadAsStringAsync().Result;

            AFWebAttribute expected = JsonConvert.DeserializeObject<AFWebAttribute>(expectedResponse);

            Assert.True(String.Equals(test.Description, expected.Description, StringComparison.InvariantCultureIgnoreCase));

            test = new AFWebAttribute { Description = "" };
            api.UpdateAttribute(Resource.WebIdPatchAttribute, test);
        }

        [Fact]
        public void DeleteAttribute()
        {
            AFWebAttribute test = new AFWebAttribute { Name = "ToDelete" };
            string s = JsonConvert.SerializeObject(test);
            HttpContent content = new StringContent(s, Encoding.UTF8, "application/json");

            HttpResponseMessage response = httpClient.PostAsync($"{Resource.Base}/elements/{Resource.WebIdTestElement}/attributes", content).Result;

            string webId = response.Headers.Location.ToString().Split('/').Last();

            Assert.True(String.Equals("Created", response.StatusCode.ToString(), StringComparison.InvariantCultureIgnoreCase));

            api.DeleteAttribute(webId);

            HttpResponseMessage expectedResponse = httpClient.GetAsync($"{Resource.Base}/attributes/{webId}").Result;

            Assert.True(String.Equals("NotFound", expectedResponse.StatusCode.ToString(), StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetAttributes()
        {
            Categories test = api.GetAttributes(Resource.WebIdFuelAttribute);
            string testResponse = JsonConvert.SerializeObject(test);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/attributes/{Resource.WebIdFuelAttribute}/categories")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetAttributeCategories()
        {
            Categories test = api.GetCategories(Resource.WebIdFuelAttribute);
            string testResponse = JsonConvert.SerializeObject(test);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/attributes/{Resource.WebIdFuelAttribute}/categories")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
