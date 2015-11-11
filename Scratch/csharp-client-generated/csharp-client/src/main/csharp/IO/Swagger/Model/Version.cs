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
  public class Version {
    
    /// <summary>
    /// Gets or Sets FullVersion
    /// </summary>
    [DataMember(Name="FullVersion", EmitDefaultValue=false)]
    public string FullVersion { get; set; }

    
    /// <summary>
    /// Gets or Sets MajorMinorRevision
    /// </summary>
    [DataMember(Name="MajorMinorRevision", EmitDefaultValue=false)]
    public string MajorMinorRevision { get; set; }

    
    /// <summary>
    /// Gets or Sets Build
    /// </summary>
    [DataMember(Name="Build", EmitDefaultValue=false)]
    public string Build { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Version {\n");
      
      sb.Append("  FullVersion: ").Append(FullVersion).Append("\n");
      
      sb.Append("  MajorMinorRevision: ").Append(MajorMinorRevision).Append("\n");
      
      sb.Append("  Build: ").Append(Build).Append("\n");
      
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
