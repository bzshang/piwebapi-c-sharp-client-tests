using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAssetDatabasesApi
    {
        
        /// <summary>
        /// Retrieve an Asset Database by path.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="path">The path to the database.</param>
        /// <returns>AssetDatabase</returns>
        AssetDatabase GetByPathAssetDatabase (string path);
  
        /// <summary>
        /// Retrieve an Asset Database by path.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="path">The path to the database.</param>
        /// <returns>AssetDatabase</returns>
        System.Threading.Tasks.Task<AssetDatabase> GetByPathAssetDatabaseAsync (string path);
        
        /// <summary>
        /// Retrieve an Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>AssetDatabase</returns>
        AssetDatabase GetAssetDatabase (string webId);
  
        /// <summary>
        /// Retrieve an Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>AssetDatabase</returns>
        System.Threading.Tasks.Task<AssetDatabase> GetAssetDatabaseAsync (string webId);
        
        /// <summary>
        /// Delete an asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns></returns>
        void DeleteAssetDatabase (string webId);
  
        /// <summary>
        /// Delete an asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task DeleteAssetDatabaseAsync (string webId);
        
        /// <summary>
        /// Update an asset database by replacing items in its definition.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <param name="body">A partial database containing the desired changes.</param>
        /// <returns></returns>
        void UpdateAssetDatabase (string webId, AssetDatabase body);
  
        /// <summary>
        /// Update an asset database by replacing items in its definition.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <param name="body">A partial database containing the desired changes.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task UpdateAssetDatabaseAsync (string webId, AssetDatabase body);
        
        /// <summary>
        /// Retrieve attribute categories for a given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        Categories GetAttributeCategories (string webId);
  
        /// <summary>
        /// Retrieve attribute categories for a given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        System.Threading.Tasks.Task<Categories> GetAttributeCategoriesAsync (string webId);
        
        /// <summary>
        /// Create an attribute category at the Asset Database root.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the attribute category.</param>
        /// <param name="body">The new attribute category definition.</param>
        /// <returns></returns>
        void CreateAttributeCategory (string webId, Category body);
  
        /// <summary>
        /// Create an attribute category at the Asset Database root.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the attribute category.</param>
        /// <param name="body">The new attribute category definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateAttributeCategoryAsync (string webId, Category body);
        
        /// <summary>
        /// Retrieve element categories for a given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        Categories GetElementCategories (string webId);
  
        /// <summary>
        /// Retrieve element categories for a given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        System.Threading.Tasks.Task<Categories> GetElementCategoriesAsync (string webId);
        
        /// <summary>
        /// Create an element category at the Asset Database root.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the element category.</param>
        /// <param name="body">The new element category definition.</param>
        /// <returns></returns>
        void CreateElementCategory (string webId, Category body);
  
        /// <summary>
        /// Create an element category at the Asset Database root.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the element category.</param>
        /// <param name="body">The new element category definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateElementCategoryAsync (string webId, Category body);
        
        /// <summary>
        /// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the current resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param>
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
        /// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
        /// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
        /// <param name="elementType">Specify that returned elements must have this type. The default type is &#39;Any&#39;.</param>
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>Elements</returns>
        Elements GetElements (string webId, string nameFilter, string categoryName, string templateName, string elementType, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount);
  
        /// <summary>
        /// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the current resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param>
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
        /// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
        /// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
        /// <param name="elementType">Specify that returned elements must have this type. The default type is &#39;Any&#39;.</param>
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>Elements</returns>
        System.Threading.Tasks.Task<Elements> GetElementsAsync (string webId, string nameFilter, string categoryName, string templateName, string elementType, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount);
        
        /// <summary>
        /// Create a child element.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the parent on which to create the element.</param>
        /// <param name="body">The new element definition.</param>
        /// <returns></returns>
        void CreateElement (string webId, Element body);
  
        /// <summary>
        /// Create a child element.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the parent on which to create the element.</param>
        /// <param name="body">The new element definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateElementAsync (string webId, Element body);
        
        /// <summary>
        /// Retrieve element templates based on the specified criteria. By default, all element templates in the specified Asset Database are returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database to search.</param>
        /// <param name="query">The query string used for finding objects. The default is no query string.</param>
        /// <param name="field">Specifies which of the object&#39;s properties are searched. The default is &#39;Name&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>ElementTemplates</returns>
        ElementTemplates GetElementTemplates (string webId, string query, string field, string sortField, string sortOrder, int? maxCount);
  
        /// <summary>
        /// Retrieve element templates based on the specified criteria. By default, all element templates in the specified Asset Database are returned.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database to search.</param>
        /// <param name="query">The query string used for finding objects. The default is no query string.</param>
        /// <param name="field">Specifies which of the object&#39;s properties are searched. The default is &#39;Name&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>ElementTemplates</returns>
        System.Threading.Tasks.Task<ElementTemplates> GetElementTemplatesAsync (string webId, string query, string field, string sortField, string sortOrder, int? maxCount);
        
        /// <summary>
        /// Create an element template at the Asset Database root.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the element template.</param>
        /// <param name="body">The new element template definition.</param>
        /// <returns></returns>
        void CreateElementTemplate (string webId, ElementTemplate body);
  
        /// <summary>
        /// Create an element template at the Asset Database root.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the element template.</param>
        /// <param name="body">The new element template definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateElementTemplateAsync (string webId, ElementTemplate body);
        
        /// <summary>
        /// Retrieve enumeration sets for given asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>EnumerationSets</returns>
        EnumerationSets GetEnumerationSets (string webId);
  
        /// <summary>
        /// Retrieve enumeration sets for given asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>EnumerationSets</returns>
        System.Threading.Tasks.Task<EnumerationSets> GetEnumerationSetsAsync (string webId);
        
        /// <summary>
        /// Create an enumeration set at the Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the enumeration set.</param>
        /// <param name="body">The new enumeration set definition.</param>
        /// <returns></returns>
        void CreateEnumerationSet (string webId, EnumerationSet body);
  
        /// <summary>
        /// Create an enumeration set at the Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the enumeration set.</param>
        /// <param name="body">The new enumeration set definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateEnumerationSetAsync (string webId, EnumerationSet body);
        
        /// <summary>
        /// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param>
        /// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the &#39;Backward*&#39; or &#39;Forward*&#39; values, none of endTime, sortField, or sortOrder may be specified. The default is &#39;Overlapped&#39;.</param>
        /// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*-8h&#39;.</param>
        /// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*&#39; if searchMode is not one of the &#39;Backward*&#39; or &#39;Forward*&#39; values.</param>
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
        /// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
        /// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
        /// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
        /// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame&#39;s referenced elements collection that derives from the template. Specify this parameter by name.</param>
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>EventFrames</returns>
        EventFrames GetEventFrames (string webId, string searchMode, string startTime, string endTime, string nameFilter, string referencedElementNameFilter, string categoryName, string templateName, string referencedElementTemplateName, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount);
  
        /// <summary>
        /// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param>
        /// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the &#39;Backward*&#39; or &#39;Forward*&#39; values, none of endTime, sortField, or sortOrder may be specified. The default is &#39;Overlapped&#39;.</param>
        /// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*-8h&#39;.</param>
        /// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*&#39; if searchMode is not one of the &#39;Backward*&#39; or &#39;Forward*&#39; values.</param>
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
        /// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
        /// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
        /// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
        /// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame&#39;s referenced elements collection that derives from the template. Specify this parameter by name.</param>
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>EventFrames</returns>
        System.Threading.Tasks.Task<EventFrames> GetEventFramesAsync (string webId, string searchMode, string startTime, string endTime, string nameFilter, string referencedElementNameFilter, string categoryName, string templateName, string referencedElementTemplateName, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount);
        
        /// <summary>
        /// Create an event frame as a child of the specified parent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the parent on which to create the event frame.</param>
        /// <param name="body">The new event frame definition.</param>
        /// <returns></returns>
        void CreateEventFrame (string webId, EventFrame body);
  
        /// <summary>
        /// Create an event frame as a child of the specified parent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the parent on which to create the event frame.</param>
        /// <param name="body">The new event frame definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateEventFrameAsync (string webId, EventFrame body);
        
        /// <summary>
        /// Export the asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <param name="exportMode">Indicates the type of export to perform.</param>
        /// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param>
        /// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param>
        /// <returns>string</returns>
        string ExportDatabase (string webId, List<string> exportMode, string startTime, string endTime);
  
        /// <summary>
        /// Export the asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <param name="exportMode">Indicates the type of export to perform.</param>
        /// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param>
        /// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param>
        /// <returns>string</returns>
        System.Threading.Tasks.Task<string> ExportDatabaseAsync (string webId, List<string> exportMode, string startTime, string endTime);
        
        /// <summary>
        /// Import an asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the asset server.</param>
        /// <param name="textXml">The XML of AF database</param>
        /// <param name="importMode">Indicates the type of import to perform. The default is &#39;AllowCreate | AllowUpdate | AutoCheckIn&#39;. Multiple import modes may be specified by using multiple instances of importMode.</param>
        /// <returns></returns>
        void ImportDatabase (string webId, Stream textXml, List<string> importMode);
  
        /// <summary>
        /// Import an asset database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the asset server.</param>
        /// <param name="textXml">The XML of AF database</param>
        /// <param name="importMode">Indicates the type of import to perform. The default is &#39;AllowCreate | AllowUpdate | AutoCheckIn&#39;. Multiple import modes may be specified by using multiple instances of importMode.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task ImportDatabaseAsync (string webId, Stream textXml, List<string> importMode);
        
        /// <summary>
        /// Retrieve table categories for a given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        Categories GetTableCategories (string webId);
  
        /// <summary>
        /// Retrieve table categories for a given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        System.Threading.Tasks.Task<Categories> GetTableCategoriesAsync (string webId);
        
        /// <summary>
        /// Create a table category on the Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the table category.</param>
        /// <param name="body">The new table category definition.</param>
        /// <returns></returns>
        void CreateTableCategory (string webId, Category body);
  
        /// <summary>
        /// Create a table category on the Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database in which to create the table category.</param>
        /// <param name="body">The new table category definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateTableCategoryAsync (string webId, Category body);
        
        /// <summary>
        /// Retrieve tables for given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Tables</returns>
        Tables GetTables (string webId);
  
        /// <summary>
        /// Retrieve tables for given Asset Database.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Tables</returns>
        System.Threading.Tasks.Task<Tables> GetTablesAsync (string webId);
        
        /// <summary>
        /// Create a table on the Asset Database.
        /// </summary>
        /// <remarks>
        /// Create a table on the Asset Database.
        /// </remarks>
        /// <param name="webId">The ID of the parent on which to create the table.</param>
        /// <param name="body">The new table definition.</param>
        /// <returns></returns>
        void CreateTable (string webId, Table body);
  
        /// <summary>
        /// Create a table on the Asset Database.
        /// </summary>
        /// <remarks>
        /// Create a table on the Asset Database.
        /// </remarks>
        /// <param name="webId">The ID of the parent on which to create the table.</param>
        /// <param name="body">The new table definition.</param>
        /// <returns></returns>
        System.Threading.Tasks.Task CreateTableAsync (string webId, Table body);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssetDatabasesApi : IAssetDatabasesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDatabasesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AssetDatabasesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDatabasesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetDatabasesApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Retrieve an Asset Database by path. 
        /// </summary>
        /// <param name="path">The path to the database.</param> 
        /// <returns>AssetDatabase</returns>            
        public AssetDatabase GetByPathAssetDatabase (string path)
        {
            
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling GetByPathAssetDatabase");
            
    
            var path_ = "/assetdatabases";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (path != null) queryParams.Add("path", ApiClient.ParameterToString(path)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetByPathAssetDatabase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetByPathAssetDatabase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDatabase) ApiClient.Deserialize(response, typeof(AssetDatabase));
        }
    
        /// <summary>
        /// Retrieve an Asset Database by path. 
        /// </summary>
        /// <param name="path">The path to the database.</param>
        /// <returns>AssetDatabase</returns>
        public async System.Threading.Tasks.Task<AssetDatabase> GetByPathAssetDatabaseAsync (string path)
        {
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling GetByPathAssetDatabase");
            
    
            var path_ = "/assetdatabases";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (path != null) queryParams.Add("path", ApiClient.ParameterToString(path)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetByPathAssetDatabase: " + response.Content, response.Content);

            return (AssetDatabase) ApiClient.Deserialize(response, typeof(AssetDatabase));
        }
        
        /// <summary>
        /// Retrieve an Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <returns>AssetDatabase</returns>            
        public AssetDatabase GetAssetDatabase (string webId)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetAssetDatabase");
            
    
            var path_ = "/assetdatabases/{webId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAssetDatabase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAssetDatabase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDatabase) ApiClient.Deserialize(response, typeof(AssetDatabase));
        }
    
        /// <summary>
        /// Retrieve an Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>AssetDatabase</returns>
        public async System.Threading.Tasks.Task<AssetDatabase> GetAssetDatabaseAsync (string webId)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetAssetDatabase");
            
    
            var path_ = "/assetdatabases/{webId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAssetDatabase: " + response.Content, response.Content);

            return (AssetDatabase) ApiClient.Deserialize(response, typeof(AssetDatabase));
        }
        
        /// <summary>
        /// Delete an asset database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <returns></returns>            
        public void DeleteAssetDatabase (string webId)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling DeleteAssetDatabase");
            
    
            var path_ = "/assetdatabases/{webId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAssetDatabase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAssetDatabase: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an asset database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteAssetDatabaseAsync (string webId)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling DeleteAssetDatabase");
            
    
            var path_ = "/assetdatabases/{webId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAssetDatabase: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Update an asset database by replacing items in its definition. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <param name="body">A partial database containing the desired changes.</param> 
        /// <returns></returns>            
        public void UpdateAssetDatabase (string webId, AssetDatabase body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling UpdateAssetDatabase");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAssetDatabase");
            
    
            var path_ = "/assetdatabases/{webId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAssetDatabase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAssetDatabase: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an asset database by replacing items in its definition. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <param name="body">A partial database containing the desired changes.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task UpdateAssetDatabaseAsync (string webId, AssetDatabase body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling UpdateAssetDatabase");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateAssetDatabase");
            
    
            var path_ = "/assetdatabases/{webId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAssetDatabase: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve attribute categories for a given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <returns>Categories</returns>            
        public Categories GetAttributeCategories (string webId)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetAttributeCategories");
            
    
            var path_ = "/assetdatabases/{webId}/attributecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAttributeCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAttributeCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Categories) ApiClient.Deserialize(response, typeof(Categories));
        }
    
        /// <summary>
        /// Retrieve attribute categories for a given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        public async System.Threading.Tasks.Task<Categories> GetAttributeCategoriesAsync (string webId)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetAttributeCategories");
            
    
            var path_ = "/assetdatabases/{webId}/attributecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAttributeCategories: " + response.Content, response.Content);

            return (Categories) ApiClient.Deserialize(response, typeof(Categories));
        }
        
        /// <summary>
        /// Create an attribute category at the Asset Database root. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the attribute category.</param> 
        /// <param name="body">The new attribute category definition.</param> 
        /// <returns></returns>            
        public void CreateAttributeCategory (string webId, Category body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateAttributeCategory");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAttributeCategory");
            
    
            var path_ = "/assetdatabases/{webId}/attributecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAttributeCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAttributeCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create an attribute category at the Asset Database root. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the attribute category.</param>
        /// <param name="body">The new attribute category definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateAttributeCategoryAsync (string webId, Category body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateAttributeCategory");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAttributeCategory");
            
    
            var path_ = "/assetdatabases/{webId}/attributecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAttributeCategory: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve element categories for a given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <returns>Categories</returns>            
        public Categories GetElementCategories (string webId)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetElementCategories");
            
    
            var path_ = "/assetdatabases/{webId}/elementcategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElementCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElementCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Categories) ApiClient.Deserialize(response, typeof(Categories));
        }
    
        /// <summary>
        /// Retrieve element categories for a given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        public async System.Threading.Tasks.Task<Categories> GetElementCategoriesAsync (string webId)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetElementCategories");
            
    
            var path_ = "/assetdatabases/{webId}/elementcategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElementCategories: " + response.Content, response.Content);

            return (Categories) ApiClient.Deserialize(response, typeof(Categories));
        }
        
        /// <summary>
        /// Create an element category at the Asset Database root. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the element category.</param> 
        /// <param name="body">The new element category definition.</param> 
        /// <returns></returns>            
        public void CreateElementCategory (string webId, Category body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateElementCategory");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateElementCategory");
            
    
            var path_ = "/assetdatabases/{webId}/elementcategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElementCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElementCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create an element category at the Asset Database root. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the element category.</param>
        /// <param name="body">The new element category definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateElementCategoryAsync (string webId, Category body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateElementCategory");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateElementCategory");
            
    
            var path_ = "/assetdatabases/{webId}/elementcategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElementCategory: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the current resource. 
        /// </summary>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param> 
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param> 
        /// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param> 
        /// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param> 
        /// <param name="elementType">Specify that returned elements must have this type. The default type is &#39;Any&#39;.</param> 
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param> 
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param> 
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param> 
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param> 
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param> 
        /// <returns>Elements</returns>            
        public Elements GetElements (string webId, string nameFilter, string categoryName, string templateName, string elementType, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetElements");
            
    
            var path_ = "/assetdatabases/{webId}/elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (nameFilter != null) queryParams.Add("nameFilter", ApiClient.ParameterToString(nameFilter)); // query parameter
            if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
            if (templateName != null) queryParams.Add("templateName", ApiClient.ParameterToString(templateName)); // query parameter
            if (elementType != null) queryParams.Add("elementType", ApiClient.ParameterToString(elementType)); // query parameter
            if (searchFullHierarchy != null) queryParams.Add("searchFullHierarchy", ApiClient.ParameterToString(searchFullHierarchy)); // query parameter
            if (sortField != null) queryParams.Add("sortField", ApiClient.ParameterToString(sortField)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (startIndex != null) queryParams.Add("startIndex", ApiClient.ParameterToString(startIndex)); // query parameter
            if (maxCount != null) queryParams.Add("maxCount", ApiClient.ParameterToString(maxCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Elements) ApiClient.Deserialize(response, typeof(Elements));
        }
    
        /// <summary>
        /// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the current resource. 
        /// </summary>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param>
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
        /// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
        /// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
        /// <param name="elementType">Specify that returned elements must have this type. The default type is &#39;Any&#39;.</param>
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>Elements</returns>
        public async System.Threading.Tasks.Task<Elements> GetElementsAsync (string webId, string nameFilter, string categoryName, string templateName, string elementType, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetElements");
            
    
            var path_ = "/assetdatabases/{webId}/elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (nameFilter != null) queryParams.Add("nameFilter", ApiClient.ParameterToString(nameFilter)); // query parameter
            if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
            if (templateName != null) queryParams.Add("templateName", ApiClient.ParameterToString(templateName)); // query parameter
            if (elementType != null) queryParams.Add("elementType", ApiClient.ParameterToString(elementType)); // query parameter
            if (searchFullHierarchy != null) queryParams.Add("searchFullHierarchy", ApiClient.ParameterToString(searchFullHierarchy)); // query parameter
            if (sortField != null) queryParams.Add("sortField", ApiClient.ParameterToString(sortField)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (startIndex != null) queryParams.Add("startIndex", ApiClient.ParameterToString(startIndex)); // query parameter
            if (maxCount != null) queryParams.Add("maxCount", ApiClient.ParameterToString(maxCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElements: " + response.Content, response.Content);

            return (Elements) ApiClient.Deserialize(response, typeof(Elements));
        }
        
        /// <summary>
        /// Create a child element. 
        /// </summary>
        /// <param name="webId">The ID of the parent on which to create the element.</param> 
        /// <param name="body">The new element definition.</param> 
        /// <returns></returns>            
        public void CreateElement (string webId, Element body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateElement");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateElement");
            
    
            var path_ = "/assetdatabases/{webId}/elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElement: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a child element. 
        /// </summary>
        /// <param name="webId">The ID of the parent on which to create the element.</param>
        /// <param name="body">The new element definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateElementAsync (string webId, Element body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateElement");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateElement");
            
    
            var path_ = "/assetdatabases/{webId}/elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElement: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve element templates based on the specified criteria. By default, all element templates in the specified Asset Database are returned. 
        /// </summary>
        /// <param name="webId">The ID of the database to search.</param> 
        /// <param name="query">The query string used for finding objects. The default is no query string.</param> 
        /// <param name="field">Specifies which of the object&#39;s properties are searched. The default is &#39;Name&#39;.</param> 
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param> 
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param> 
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param> 
        /// <returns>ElementTemplates</returns>            
        public ElementTemplates GetElementTemplates (string webId, string query, string field, string sortField, string sortOrder, int? maxCount)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetElementTemplates");
            
    
            var path_ = "/assetdatabases/{webId}/elementtemplates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
            if (field != null) queryParams.Add("field", ApiClient.ParameterToString(field)); // query parameter
            if (sortField != null) queryParams.Add("sortField", ApiClient.ParameterToString(sortField)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (maxCount != null) queryParams.Add("maxCount", ApiClient.ParameterToString(maxCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElementTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElementTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ElementTemplates) ApiClient.Deserialize(response, typeof(ElementTemplates));
        }
    
        /// <summary>
        /// Retrieve element templates based on the specified criteria. By default, all element templates in the specified Asset Database are returned. 
        /// </summary>
        /// <param name="webId">The ID of the database to search.</param>
        /// <param name="query">The query string used for finding objects. The default is no query string.</param>
        /// <param name="field">Specifies which of the object&#39;s properties are searched. The default is &#39;Name&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>ElementTemplates</returns>
        public async System.Threading.Tasks.Task<ElementTemplates> GetElementTemplatesAsync (string webId, string query, string field, string sortField, string sortOrder, int? maxCount)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetElementTemplates");
            
    
            var path_ = "/assetdatabases/{webId}/elementtemplates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
            if (field != null) queryParams.Add("field", ApiClient.ParameterToString(field)); // query parameter
            if (sortField != null) queryParams.Add("sortField", ApiClient.ParameterToString(sortField)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (maxCount != null) queryParams.Add("maxCount", ApiClient.ParameterToString(maxCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetElementTemplates: " + response.Content, response.Content);

            return (ElementTemplates) ApiClient.Deserialize(response, typeof(ElementTemplates));
        }
        
        /// <summary>
        /// Create an element template at the Asset Database root. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the element template.</param> 
        /// <param name="body">The new element template definition.</param> 
        /// <returns></returns>            
        public void CreateElementTemplate (string webId, ElementTemplate body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateElementTemplate");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateElementTemplate");
            
    
            var path_ = "/assetdatabases/{webId}/elementtemplates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create an element template at the Asset Database root. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the element template.</param>
        /// <param name="body">The new element template definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateElementTemplateAsync (string webId, ElementTemplate body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateElementTemplate");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateElementTemplate");
            
    
            var path_ = "/assetdatabases/{webId}/elementtemplates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateElementTemplate: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve enumeration sets for given asset database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <returns>EnumerationSets</returns>            
        public EnumerationSets GetEnumerationSets (string webId)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetEnumerationSets");
            
    
            var path_ = "/assetdatabases/{webId}/enumerationsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEnumerationSets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEnumerationSets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EnumerationSets) ApiClient.Deserialize(response, typeof(EnumerationSets));
        }
    
        /// <summary>
        /// Retrieve enumeration sets for given asset database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>EnumerationSets</returns>
        public async System.Threading.Tasks.Task<EnumerationSets> GetEnumerationSetsAsync (string webId)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetEnumerationSets");
            
    
            var path_ = "/assetdatabases/{webId}/enumerationsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEnumerationSets: " + response.Content, response.Content);

            return (EnumerationSets) ApiClient.Deserialize(response, typeof(EnumerationSets));
        }
        
        /// <summary>
        /// Create an enumeration set at the Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the enumeration set.</param> 
        /// <param name="body">The new enumeration set definition.</param> 
        /// <returns></returns>            
        public void CreateEnumerationSet (string webId, EnumerationSet body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateEnumerationSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateEnumerationSet");
            
    
            var path_ = "/assetdatabases/{webId}/enumerationsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEnumerationSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEnumerationSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create an enumeration set at the Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the enumeration set.</param>
        /// <param name="body">The new enumeration set definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateEnumerationSetAsync (string webId, EnumerationSet body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateEnumerationSet");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateEnumerationSet");
            
    
            var path_ = "/assetdatabases/{webId}/enumerationsets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEnumerationSet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours. 
        /// </summary>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param> 
        /// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the &#39;Backward*&#39; or &#39;Forward*&#39; values, none of endTime, sortField, or sortOrder may be specified. The default is &#39;Overlapped&#39;.</param> 
        /// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*-8h&#39;.</param> 
        /// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*&#39; if searchMode is not one of the &#39;Backward*&#39; or &#39;Forward*&#39; values.</param> 
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param> 
        /// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param> 
        /// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param> 
        /// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param> 
        /// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame&#39;s referenced elements collection that derives from the template. Specify this parameter by name.</param> 
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param> 
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param> 
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param> 
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param> 
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param> 
        /// <returns>EventFrames</returns>            
        public EventFrames GetEventFrames (string webId, string searchMode, string startTime, string endTime, string nameFilter, string referencedElementNameFilter, string categoryName, string templateName, string referencedElementTemplateName, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetEventFrames");
            
    
            var path_ = "/assetdatabases/{webId}/eventframes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (searchMode != null) queryParams.Add("searchMode", ApiClient.ParameterToString(searchMode)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (nameFilter != null) queryParams.Add("nameFilter", ApiClient.ParameterToString(nameFilter)); // query parameter
            if (referencedElementNameFilter != null) queryParams.Add("referencedElementNameFilter", ApiClient.ParameterToString(referencedElementNameFilter)); // query parameter
            if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
            if (templateName != null) queryParams.Add("templateName", ApiClient.ParameterToString(templateName)); // query parameter
            if (referencedElementTemplateName != null) queryParams.Add("referencedElementTemplateName", ApiClient.ParameterToString(referencedElementTemplateName)); // query parameter
            if (searchFullHierarchy != null) queryParams.Add("searchFullHierarchy", ApiClient.ParameterToString(searchFullHierarchy)); // query parameter
            if (sortField != null) queryParams.Add("sortField", ApiClient.ParameterToString(sortField)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (startIndex != null) queryParams.Add("startIndex", ApiClient.ParameterToString(startIndex)); // query parameter
            if (maxCount != null) queryParams.Add("maxCount", ApiClient.ParameterToString(maxCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventFrames: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventFrames: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventFrames) ApiClient.Deserialize(response, typeof(EventFrames));
        }
    
        /// <summary>
        /// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours. 
        /// </summary>
        /// <param name="webId">The ID of the resource to use as the root of the search.</param>
        /// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the &#39;Backward*&#39; or &#39;Forward*&#39; values, none of endTime, sortField, or sortOrder may be specified. The default is &#39;Overlapped&#39;.</param>
        /// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*-8h&#39;.</param>
        /// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame&#39;s startTime or endTime. The default is &#39;*&#39; if searchMode is not one of the &#39;Backward*&#39; or &#39;Forward*&#39; values.</param>
        /// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
        /// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
        /// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
        /// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
        /// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame&#39;s referenced elements collection that derives from the template. Specify this parameter by name.</param>
        /// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is &#39;false&#39;.</param>
        /// <param name="sortField">The field or property of the object used to sort the returned collection. The default is &#39;Name&#39;.</param>
        /// <param name="sortOrder">The order that the returned collection is sorted. The default is &#39;Ascending&#39;.</param>
        /// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
        /// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
        /// <returns>EventFrames</returns>
        public async System.Threading.Tasks.Task<EventFrames> GetEventFramesAsync (string webId, string searchMode, string startTime, string endTime, string nameFilter, string referencedElementNameFilter, string categoryName, string templateName, string referencedElementTemplateName, bool? searchFullHierarchy, string sortField, string sortOrder, int? startIndex, int? maxCount)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetEventFrames");
            
    
            var path_ = "/assetdatabases/{webId}/eventframes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (searchMode != null) queryParams.Add("searchMode", ApiClient.ParameterToString(searchMode)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            if (nameFilter != null) queryParams.Add("nameFilter", ApiClient.ParameterToString(nameFilter)); // query parameter
            if (referencedElementNameFilter != null) queryParams.Add("referencedElementNameFilter", ApiClient.ParameterToString(referencedElementNameFilter)); // query parameter
            if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
            if (templateName != null) queryParams.Add("templateName", ApiClient.ParameterToString(templateName)); // query parameter
            if (referencedElementTemplateName != null) queryParams.Add("referencedElementTemplateName", ApiClient.ParameterToString(referencedElementTemplateName)); // query parameter
            if (searchFullHierarchy != null) queryParams.Add("searchFullHierarchy", ApiClient.ParameterToString(searchFullHierarchy)); // query parameter
            if (sortField != null) queryParams.Add("sortField", ApiClient.ParameterToString(sortField)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (startIndex != null) queryParams.Add("startIndex", ApiClient.ParameterToString(startIndex)); // query parameter
            if (maxCount != null) queryParams.Add("maxCount", ApiClient.ParameterToString(maxCount)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEventFrames: " + response.Content, response.Content);

            return (EventFrames) ApiClient.Deserialize(response, typeof(EventFrames));
        }
        
        /// <summary>
        /// Create an event frame as a child of the specified parent. 
        /// </summary>
        /// <param name="webId">The ID of the parent on which to create the event frame.</param> 
        /// <param name="body">The new event frame definition.</param> 
        /// <returns></returns>            
        public void CreateEventFrame (string webId, EventFrame body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateEventFrame");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateEventFrame");
            
    
            var path_ = "/assetdatabases/{webId}/eventframes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEventFrame: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEventFrame: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create an event frame as a child of the specified parent. 
        /// </summary>
        /// <param name="webId">The ID of the parent on which to create the event frame.</param>
        /// <param name="body">The new event frame definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateEventFrameAsync (string webId, EventFrame body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateEventFrame");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateEventFrame");
            
    
            var path_ = "/assetdatabases/{webId}/eventframes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEventFrame: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Export the asset database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <param name="exportMode">Indicates the type of export to perform.</param> 
        /// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param> 
        /// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param> 
        /// <returns>string</returns>            
        public string ExportDatabase (string webId, List<string> exportMode, string startTime, string endTime)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling ExportDatabase");
            
    
            var path_ = "/assetdatabases/{webId}/export";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/xml"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (exportMode != null) queryParams.Add("exportMode", ApiClient.ParameterToString(exportMode)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ExportDatabase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExportDatabase: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response, typeof(string));
        }
    
        /// <summary>
        /// Export the asset database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <param name="exportMode">Indicates the type of export to perform.</param>
        /// <param name="startTime">The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param>
        /// <param name="endTime">The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export.</param>
        /// <returns>string</returns>
        public async System.Threading.Tasks.Task<string> ExportDatabaseAsync (string webId, List<string> exportMode, string startTime, string endTime)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling ExportDatabase");
            
    
            var path_ = "/assetdatabases/{webId}/export";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/xml"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (exportMode != null) queryParams.Add("exportMode", ApiClient.ParameterToString(exportMode)); // query parameter
            if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ExportDatabase: " + response.Content, response.Content);

            return (string) ApiClient.Deserialize(response, typeof(string));
        }
        
        /// <summary>
        /// Import an asset database. 
        /// </summary>
        /// <param name="webId">The ID of the asset server.</param> 
        /// <param name="textXml">The XML of AF database</param> 
        /// <param name="importMode">Indicates the type of import to perform. The default is &#39;AllowCreate | AllowUpdate | AutoCheckIn&#39;. Multiple import modes may be specified by using multiple instances of importMode.</param> 
        /// <returns></returns>            
        public void ImportDatabase (string webId, Stream textXml, List<string> importMode)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling ImportDatabase");
            
            // verify the required parameter 'textXml' is set
            if (textXml == null) throw new ApiException(400, "Missing required parameter 'textXml' when calling ImportDatabase");
            
    
            var path_ = "/assetdatabases/{webId}/import";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (importMode != null) queryParams.Add("importMode", ApiClient.ParameterToString(importMode)); // query parameter
            
            
            if (textXml != null) fileParams.Add("text/xml", ApiClient.ParameterToFile("text/xml", textXml));
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ImportDatabase: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ImportDatabase: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Import an asset database. 
        /// </summary>
        /// <param name="webId">The ID of the asset server.</param>
        /// <param name="textXml">The XML of AF database</param>
        /// <param name="importMode">Indicates the type of import to perform. The default is &#39;AllowCreate | AllowUpdate | AutoCheckIn&#39;. Multiple import modes may be specified by using multiple instances of importMode.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task ImportDatabaseAsync (string webId, Stream textXml, List<string> importMode)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling ImportDatabase");
            // verify the required parameter 'textXml' is set
            if (textXml == null) throw new ApiException(400, "Missing required parameter 'textXml' when calling ImportDatabase");
            
    
            var path_ = "/assetdatabases/{webId}/import";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            if (importMode != null) queryParams.Add("importMode", ApiClient.ParameterToString(importMode)); // query parameter
            
            
            if (textXml != null) fileParams.Add("text/xml", ApiClient.ParameterToFile("text/xml", textXml));
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ImportDatabase: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve table categories for a given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <returns>Categories</returns>            
        public Categories GetTableCategories (string webId)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetTableCategories");
            
    
            var path_ = "/assetdatabases/{webId}/tablecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTableCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTableCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Categories) ApiClient.Deserialize(response, typeof(Categories));
        }
    
        /// <summary>
        /// Retrieve table categories for a given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Categories</returns>
        public async System.Threading.Tasks.Task<Categories> GetTableCategoriesAsync (string webId)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetTableCategories");
            
    
            var path_ = "/assetdatabases/{webId}/tablecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTableCategories: " + response.Content, response.Content);

            return (Categories) ApiClient.Deserialize(response, typeof(Categories));
        }
        
        /// <summary>
        /// Create a table category on the Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the table category.</param> 
        /// <param name="body">The new table category definition.</param> 
        /// <returns></returns>            
        public void CreateTableCategory (string webId, Category body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateTableCategory");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTableCategory");
            
    
            var path_ = "/assetdatabases/{webId}/tablecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTableCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTableCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a table category on the Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database in which to create the table category.</param>
        /// <param name="body">The new table category definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateTableCategoryAsync (string webId, Category body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateTableCategory");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTableCategory");
            
    
            var path_ = "/assetdatabases/{webId}/tablecategories";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTableCategory: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        /// Retrieve tables for given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param> 
        /// <returns>Tables</returns>            
        public Tables GetTables (string webId)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetTables");
            
    
            var path_ = "/assetdatabases/{webId}/tables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTables: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTables: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Tables) ApiClient.Deserialize(response, typeof(Tables));
        }
    
        /// <summary>
        /// Retrieve tables for given Asset Database. 
        /// </summary>
        /// <param name="webId">The ID of the database.</param>
        /// <returns>Tables</returns>
        public async System.Threading.Tasks.Task<Tables> GetTablesAsync (string webId)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling GetTables");
            
    
            var path_ = "/assetdatabases/{webId}/tables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTables: " + response.Content, response.Content);

            return (Tables) ApiClient.Deserialize(response, typeof(Tables));
        }
        
        /// <summary>
        /// Create a table on the Asset Database. Create a table on the Asset Database.
        /// </summary>
        /// <param name="webId">The ID of the parent on which to create the table.</param> 
        /// <param name="body">The new table definition.</param> 
        /// <returns></returns>            
        public void CreateTable (string webId, Table body)
        {
            
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateTable");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTable");
            
    
            var path_ = "/assetdatabases/{webId}/tables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTable: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a table on the Asset Database. Create a table on the Asset Database.
        /// </summary>
        /// <param name="webId">The ID of the parent on which to create the table.</param>
        /// <param name="body">The new table definition.</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task CreateTableAsync (string webId, Table body)
        {
            // verify the required parameter 'webId' is set
            if (webId == null) throw new ApiException(400, "Missing required parameter 'webId' when calling CreateTable");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTable");
            
    
            var path_ = "/assetdatabases/{webId}/tables";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (webId != null) pathParams.Add("webId", ApiClient.ParameterToString(webId)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTable: " + response.Content, response.Content);

            
            return;
        }
        
    }
    
}
