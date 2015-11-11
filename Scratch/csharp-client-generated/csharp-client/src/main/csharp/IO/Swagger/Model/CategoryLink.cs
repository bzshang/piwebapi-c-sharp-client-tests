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
  public class CategoryLink {
    
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="Self", EmitDefaultValue=false)]
    public string Self { get; set; }

    
    /// <summary>
    /// Gets or Sets Database
    /// </summary>
    [DataMember(Name="Database", EmitDefaultValue=false)]
    public string Database { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoryLink {\n");
      
      sb.Append("  Self: ").Append(Self).Append("\n");
      
      sb.Append("  Database: ").Append(Database).Append("\n");
      
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
