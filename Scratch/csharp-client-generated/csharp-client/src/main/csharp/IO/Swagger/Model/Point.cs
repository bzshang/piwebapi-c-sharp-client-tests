using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Point {
    
    /// <summary>
    /// Gets or Sets WebId
    /// </summary>
    [DataMember(Name="WebId", EmitDefaultValue=false)]
    public string WebId { get; set; }

    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    public bool? Id { get; set; }

    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets PointClass
    /// </summary>
    [DataMember(Name="PointClass", EmitDefaultValue=false)]
    public string PointClass { get; set; }

    
    /// <summary>
    /// Gets or Sets PointType
    /// </summary>
    [DataMember(Name="PointType", EmitDefaultValue=false)]
    public string PointType { get; set; }

    
    /// <summary>
    /// Gets or Sets Future
    /// </summary>
    [DataMember(Name="Future", EmitDefaultValue=false)]
    public bool? Future { get; set; }

    
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="Links", EmitDefaultValue=false)]
    public PointLink Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Point {\n");
      
      sb.Append("  WebId: ").Append(WebId).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  PointClass: ").Append(PointClass).Append("\n");
      
      sb.Append("  PointType: ").Append(PointType).Append("\n");
      
      sb.Append("  Future: ").Append(Future).Append("\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
