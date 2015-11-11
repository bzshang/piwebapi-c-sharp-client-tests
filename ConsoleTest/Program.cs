using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

using OSIsoft.AF;
using OSIsoft.AF.Diagnostics;
using OSIsoft.AF.Service;
using OSIsoft.AF.Asset;

using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Net.Http.Headers;
using System.Xml;

using RestSharp;
using RestSharp.Extensions;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //PISystem ps = new PISystems()["bshang-pi1"];
            //AFDatabase database = ps.Databases["ImportedDatabase"];
            //PIImportMode importModesParsed = PIImportMode.AllowCreate | PIImportMode.AllowUpdate | PIImportMode.AutoCheckIn;

            //using (XmlReader reader = XmlReader.Create(new FileStream("ToImport.xml", FileMode.Open)))
            //{
            //    database.PISystem.ImportXml(database, importModesParsed, reader, null);
            //    database.PISystem.CheckIn();
            //}


            string import = File.ReadAllText(@"ToImport.xml");
            Stream stream = new FileStream(@"ToImport.xml", FileMode.Open);

            //ApiClient client = new ApiClient("https://bshang-web2/piwebapi");
            //client.AddDefaultHeader("Cache-Control", "no-cache");
            //client.AddDefaultHeader("Content-Type", "text/xml");
            //IAssetDatabasesApi api = new AssetDatabasesApi(client);
            //api.ImportDatabase("D03lhdDwK3_kmigxzMW4fJTQ7FEJOvt1R0Wz02xJo-ziTwQlNIQU5HLVBJMVxJTVBPUlRFRERBVEFCQVNF", stream, null);

            RestClient restClient = new RestClient("https://bshang-web2/piwebapi");
            RestRequest req = new RestRequest("assetdatabases/D03lhdDwK3_kmigxzMW4fJTQ7FEJOvt1R0Wz02xJo-ziTwQlNIQU5HLVBJMVxJTVBPUlRFRERBVEFCQVNF/import", Method.POST);
            //req.AddParameter("text/xml", import, ParameterType.RequestBody);

            byte[] b = stream.ReadAsBytes();
            Action<Stream> act = s => s.Write(b, 0, b.Length);

            req.AddParameter("text/xml", import, ParameterType.RequestBody);
            //req.AddFile("text/xml", act, Path.GetFileName(((FileStream)stream).Name), "text/xml");
            req.AddHeader("Content-Type", "text/xml");
            IRestResponse resp = restClient.Execute(req);
            Console.ReadKey();

            //string import = File.ReadAllText(@"ToImport.xml");
            //HttpClient httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://bshang-web2/piwebapi");
            //HttpContent httpContent = new StringContent(import, Encoding.UTF8,
            //                        "text/xml");
            //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
            //HttpResponseMessage response = httpClient.PostAsync($"https://bshang-web2/piwebapi/assetdatabases/D03lhdDwK3_kmigxzMW4fJTQ7FEJOvt1R0Wz02xJo-ziTwQlNIQU5HLVBJMVxJTVBPUlRFRERBVEFCQVNF/import", httpContent).Result;

            //api.ImportDatabase("D03lhdDwK3_kmigxzMW4fJTQG0TPaxqhRUOEjalPDLrHewQlNIQU5HLVBJMVxUT0VYUE9SVA", import, null);

            //string webId = client.ResponseHeaders["Location"];

            //string s = api.ExportDatabase("D03lhdDwK3_kmigxzMW4fJTQG0TPaxqhRUOEjalPDLrHewQlNIQU5HLVBJMVxUT0VYUE9SVA", null, null, null);


        }
    }
}
