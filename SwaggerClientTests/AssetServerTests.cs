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
    public class AssetServerTests
    {
        ApiClient client;
        AssetServersApi api;

        HttpClient httpClient;

        public AssetServerTests()
        {
            client = new ApiClient(Resource.Base);
            client.AddDefaultHeader("Cache-Control", "no-cache");
            api = new AssetServersApi(client);

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Resource.Base);
            httpClient.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
        }

        [Fact]
        public void GetAssetServer()
        {
            AssetServer assetServer = api.GetAssetServer(Resource.WebIdAssetServer);
            string testResponse = JsonConvert.SerializeObject(assetServer);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/assetservers/{Resource.WebIdAssetServer}")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetByNameAssetServer()
        {
            AssetServer assetServer = api.GetByNameAssetServer(@"bshang-pi1");
            string testResponse = JsonConvert.SerializeObject(assetServer);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/assetservers?name=bshang-pi1")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetDatabases()
        {
            AssetDatabases databases = api.GetDatabases(Resource.WebIdAssetServer);
            string testResponse = JsonConvert.SerializeObject(databases);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/assetservers/{Resource.WebIdAssetServer}/assetdatabases")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetUnitClasses()
        {
            UnitClasses unitClasses = api.GetUnitClasses(Resource.WebIdAssetServer);
            string testResponse = JsonConvert.SerializeObject(unitClasses);

            string expectedResponse = httpClient.GetAsync($"{Resource.Base}/assetservers/{Resource.WebIdAssetServer}/unitclasses")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void CreateAssetDatabase()
        {
            AssetDatabase test = new AssetDatabase { Name = "New Database", Description = "Hello world" };
            api.CreateAssetDatabase(Resource.WebIdAssetServer, test);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            AssetDatabase expected = JsonConvert.DeserializeObject<AssetDatabase>(expectedResponse);

            Assert.True(String.Equals(test.Name, expected.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(test.Description, expected.Description, StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateUnitClass()
        {
            UnitClass test = new UnitClass { Name = "New Unit Class", Description = "Hello world", CanonicalUnitName = "test", CanonicalUnitAbbreviation  = "test abbr" };
            api.CreateUnitClass(Resource.WebIdAssetServer, test);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            AssetDatabase expected = JsonConvert.DeserializeObject<AssetDatabase>(expectedResponse);

            Assert.True(String.Equals(test.Name, expected.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(test.Description, expected.Description, StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }


    }
}
