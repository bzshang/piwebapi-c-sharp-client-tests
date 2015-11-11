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

using SwaggerClientTests.Helpers;

using Xunit;

namespace SwaggerClientTests
{
    public class AssetDatabasesTest
    {
        ApiClient client;
        IAssetDatabasesApi api;

        HttpClient httpClient;

        public AssetDatabasesTest()
        {
            client = new ApiClient(AssetDatabasesResource.Base);
            client.AddDefaultHeader("Cache-Control", "no-cache");
            api = new AssetDatabasesApi(client);

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(AssetDatabasesResource.Base);
            httpClient.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
        }

        [Fact]
        public void Get()
        {
            AssetDatabase assetDatabase = api.GetAssetDatabase(AssetDatabasesResource.WebId);
            string testResponse = JsonConvert.SerializeObject(assetDatabase);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetByPath()
        {
            AssetDatabase assetDatabase = api.GetByPathAssetDatabase(AssetDatabasesResource.Path);
            string testResponse = JsonConvert.SerializeObject(assetDatabase);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases?path={AssetDatabasesResource.Path}")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetAttributeCategories()
        {
            Categories categories = api.GetAttributeCategories(AssetDatabasesResource.WebId);
            string testResponse = JsonConvert.SerializeObject(categories);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/attributecategories")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetElementCategories()
        {
            Categories categories = api.GetElementCategories(AssetDatabasesResource.WebId);

            string output = JsonConvert.SerializeObject(categories);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/elementcategories")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(output, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetElements()
        {
            Elements elements = api.GetElements(
                webId: AssetDatabasesResource.WebId,
                nameFilter: "B*",
                categoryName: "Equipment Assets",
                templateName: "Boiler",
                elementType: "Any",
                searchFullHierarchy: true,
                sortField: "Name",
                sortOrder: "Ascending",
                startIndex: 3,
                maxCount: 5);

            string testResponse = JsonConvert.SerializeObject(elements);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/elements?" +
                "nameFilter=B*&categoryName=Equipment Assets&templateName=Boiler&elementType=Any&searchFullHierarchy=true&sortField=Name&sortOrder=Ascending&startIndex=3&maxCount=5")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetElementTemplates()
        {
            ElementTemplates elementTemplates = api.GetElementTemplates(
                webId: AssetDatabasesResource.WebId,
                query: "*",
                field: "Name",
                sortField: "Name",
                sortOrder: "Ascending",
                maxCount: 10);

            string testResponse = JsonConvert.SerializeObject(elementTemplates);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/elementtemplates?" +
                "query=*&field=Name&sortField=Name&sortOrder=Ascending&maxCount=10")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetEnumerationSets()
        {
            EnumerationSets enumerationSets = api.GetEnumerationSets(AssetDatabasesResource.WebId);
            string testResponse = JsonConvert.SerializeObject(enumerationSets);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/enumerationsets")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetEventFrames()
        {
            EventFrames eventFrames = api.GetEventFrames(
                webId: AssetDatabasesResource.WebId,
                searchMode: "ForwardFromStartTime",
                startTime: "2015-jan-01",
                endTime: null,
                nameFilter: "*",
                referencedElementNameFilter: "*",
                categoryName: "Equipment Assets",
                templateName: "EFTemplate",
                referencedElementTemplateName: "Boiler",
                searchFullHierarchy: true,
                sortField: null,
                sortOrder: null,
                startIndex: 0,
                maxCount: 2);

            string testResponse = JsonConvert.SerializeObject(eventFrames);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/eventframes?" +
                "searchMode=ForwardFromStartTime&startTime=2015-jan-01&nameFilter=*&referencedElementNameFilter=*&categoryName=Equipment Assets&" +
                "templateName=EFTemplate&referencedElementTemplateName=Boiler&searchFullHierarchy=true&startIndex=0&maxCount=2")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetTableCategories()
        {
            Categories categories = api.GetTableCategories(
                webId: AssetDatabasesResource.WebId);

            string testResponse = JsonConvert.SerializeObject(categories);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/tablecategories")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void GetTables()
        {
            Tables tables = api.GetTables(
                webId: AssetDatabasesResource.WebId);

            string testResponse = JsonConvert.SerializeObject(tables);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebId}/tables")
                .Result.Content
                .ReadAsStringAsync().Result;

            Assert.True(String.Equals(testResponse, expectedResponse, StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void CreateAttributeCategory()
        {
            Category testCategory = new Category { Name = $"Test category", Description = "Test description" };
            api.CreateAttributeCategory(AssetDatabasesResource.WebIdCreate, testCategory);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            Category expectedCategory = JsonConvert.DeserializeObject<Category>(expectedResponse);

            Assert.True(String.Equals(testCategory.Name, expectedCategory.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testCategory.Description, expectedCategory.Description, StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateElementCategory()
        {
            Category testCategory = new Category { Name = $"Test category", Description = "Test description" };
            api.CreateElementCategory(AssetDatabasesResource.WebIdCreate, testCategory);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            Category expectedCategory = JsonConvert.DeserializeObject<Category>(expectedResponse);

            Assert.True(String.Equals(testCategory.Name, expectedCategory.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testCategory.Description, expectedCategory.Description, StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateTableCategory()
        {
            Category testCategory = new Category { Name = $"Test category", Description = "Test description" };
            api.CreateTableCategory(AssetDatabasesResource.WebIdCreate, testCategory);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            Category expectedCategory = JsonConvert.DeserializeObject<Category>(expectedResponse);

            Assert.True(String.Equals(testCategory.Name, expectedCategory.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testCategory.Description, expectedCategory.Description, StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateElement()
        {
            Element testElement = new Element { Name = $"Test element", Description = "Test description", CategoryNames = new string[] {"ElementCategory" }.ToList()};
            api.CreateElement(AssetDatabasesResource.WebIdCreate, testElement);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            Element expectedElement = JsonConvert.DeserializeObject<Element>(expectedResponse);

            Assert.True(String.Equals(testElement.Name, expectedElement.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testElement.Description, expectedElement.Description, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testElement.CategoryNames[0], expectedElement.CategoryNames[0], StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateElementTemplate()
        {
            ElementTemplate testElementTemplate = new ElementTemplate { Name = $"Test element", Description = "Test description", CategoryNames = new string[] { "ElementCategory" }.ToList() };
            api.CreateElementTemplate(AssetDatabasesResource.WebIdCreate, testElementTemplate);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            Element expectedElementTemplate = JsonConvert.DeserializeObject<Element>(expectedResponse);

            Assert.True(String.Equals(testElementTemplate.Name, expectedElementTemplate.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testElementTemplate.Description, expectedElementTemplate.Description, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testElementTemplate.CategoryNames[0], expectedElementTemplate.CategoryNames[0], StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateEnumerationSet()
        {
            EnumerationSet testEnumerationSet = new EnumerationSet { Name = $"Test element", Description = "Test description" };
            api.CreateEnumerationSet(AssetDatabasesResource.WebIdCreate, testEnumerationSet);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            Element expectedEnumerationSet = JsonConvert.DeserializeObject<Element>(expectedResponse);

            Assert.True(String.Equals(testEnumerationSet.Name, expectedEnumerationSet.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testEnumerationSet.Description, expectedEnumerationSet.Description, StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateEventFrame()
        {
            EventFrame testEventFrame = new EventFrame { Name = $"Test event frame", Description = "Test description", CategoryNames = new string[] { "ElementCategory" }.ToList(),
                StartTime = "2014-11-01T07:00:00Z", EndTime = "2014-11-02T07:00:00Z", RefElementWebIds = new string[] { AssetDatabasesResource.WebIdEventFrameElement }.ToList(),
            };
            api.CreateEventFrame(AssetDatabasesResource.WebIdCreate, testEventFrame);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            EventFrame expectedEventFrame = JsonConvert.DeserializeObject<EventFrame>(expectedResponse);

            Assert.True(String.Equals(testEventFrame.Name, expectedEventFrame.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testEventFrame.Description, expectedEventFrame.Description, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testEventFrame.CategoryNames[0], expectedEventFrame.CategoryNames[0], StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testEventFrame.StartTime, expectedEventFrame.StartTime, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testEventFrame.EndTime, expectedEventFrame.EndTime, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testEventFrame.RefElementWebIds[0], expectedEventFrame.RefElementWebIds[0], StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void CreateTable()
        {
            Table testTable = new Table { Name = $"Test element", Description = "Test description", CategoryNames = new string[] { "TableCategory" }.ToList(), };
            api.CreateTable(AssetDatabasesResource.WebIdCreate, testTable);

            string webId = client.ResponseHeaders["Location"];

            string expectedResponse = httpClient.GetAsync(webId)
                .Result.Content
                .ReadAsStringAsync().Result;

            Element expectedTable = JsonConvert.DeserializeObject<Element>(expectedResponse);

            Assert.True(String.Equals(testTable.Name, expectedTable.Name, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testTable.Description, expectedTable.Description, StringComparison.InvariantCultureIgnoreCase));
            Assert.True(String.Equals(testTable.CategoryNames[0], expectedTable.CategoryNames[0], StringComparison.InvariantCultureIgnoreCase));

            HttpResponseMessage response = httpClient.DeleteAsync(webId).Result;
        }

        [Fact]
        public void UpdateDatabase()
        {
            AssetDatabase test = new AssetDatabase { Description = "Test description" };
            api.UpdateAssetDatabase(AssetDatabasesResource.WebIdCreate, test);

            string expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebIdCreate}")
                .Result.Content
                .ReadAsStringAsync().Result;

            AssetDatabase expected = JsonConvert.DeserializeObject<AssetDatabase>(expectedResponse);

            Assert.True(String.Equals(test.Description, expected.Description, StringComparison.InvariantCultureIgnoreCase));

            test = new AssetDatabase { Description = "" };
            api.UpdateAssetDatabase(AssetDatabasesResource.WebIdCreate, test);
        }

        [Fact]
        public void DeleteDatabase()
        {
            AssetDatabase test = new AssetDatabase { Name = "ToDelete"};
            string s = JsonConvert.SerializeObject(test);
            HttpContent content = new StringContent(s, Encoding.UTF8, "application/json");

            HttpResponseMessage response = httpClient.PostAsync($"{AssetDatabasesResource.Base}/assetservers/{AssetDatabasesResource.WebIdAssetServer}/assetdatabases", content).Result;

            string webId = response.Headers.Location.ToString().Split('/').Last();

            api.DeleteAssetDatabase(webId);

            HttpResponseMessage expectedResponse = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{webId}").Result;

            Assert.True(String.Equals("NotFound", expectedResponse.StatusCode.ToString(), StringComparison.InvariantCultureIgnoreCase));
        }

        //Fails: Due to https://github.com/swagger-api/swagger-ui/issues/485
        [Fact]
        public void Export()
        {
            string expected = httpClient.GetAsync($"{AssetDatabasesResource.Base}/assetdatabases/{AssetDatabasesResource.WebIdToExport}/export")
                .Result.Content
                .ReadAsStringAsync().Result;

            //406 NotAcceptable
            string test = api.ExportDatabase(AssetDatabasesResource.WebIdAssetServer, null, null, null);

            Assert.True(String.Equals(test, expected, StringComparison.InvariantCultureIgnoreCase));
        }

        //Fails: Need req.AddParameter("text/xml", import, ParameterType.RequestBody) but code-gen uses "application/json".
        //Also, Overload in FileParameter.Create with contentType not being called by code-gen but this doesn't seem to matter.
        [Fact]
        public void Import()
        {
            Stream stream = new FileStream(@"..\..\XML\ToImport.xml", FileMode.Open);
            client.DefaultHeader.Add("Content-Type", "text/xml");
            api.ImportDatabase(AssetDatabasesResource.WebIdToImport, stream, null);

            string webId = client.ResponseHeaders["Location"];

            HttpResponseMessage expectedResponse = httpClient.GetAsync(webId).Result;

            Assert.True(String.Equals("OK", expectedResponse.StatusCode.ToString(), StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
