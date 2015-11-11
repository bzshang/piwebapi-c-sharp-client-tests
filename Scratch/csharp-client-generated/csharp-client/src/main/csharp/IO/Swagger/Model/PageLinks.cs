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
  public class PageLinks {
    
    /// <summary>
    /// Gets or Sets First
    /// </summary>
    [DataMember(Name="First", EmitDefaultValue=false)]
    public string First { get; set; }

    
    /// <summary>
    /// Gets or Sets Previous
    /// </summary>
    [DataMember(Name="Previous", EmitDefaultValue=false)]
    public string Previous { get; set; }

    
    /// <summary>
    /// Gets or Sets Next
    /// </summary>
    [DataMember(Name="Next", EmitDefaultValue=false)]
    public string Next { get; set; }

    
    /// <summary>
    /// Gets or Sets Last
    /// </summary>
    [DataMember(Name="Last", EmitDefaultValue=false)]
    public string Last { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageLinks {\n");
      
      sb.Append("  First: ").Append(First).Append("\n");
      
      sb.Append("  Previous: ").Append(Previous).Append("\n");
      
      sb.Append("  Next: ").Append(Next).Append("\n");
      
      sb.Append("  Last: ").Append(Last).Append("\n");
      
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
