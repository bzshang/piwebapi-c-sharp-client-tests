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
  public class UserInfo {
    
    /// <summary>
    /// Gets or Sets IdentityType
    /// </summary>
    [DataMember(Name="IdentityType", EmitDefaultValue=false)]
    public string IdentityType { get; set; }

    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets IsAuthenticated
    /// </summary>
    [DataMember(Name="IsAuthenticated", EmitDefaultValue=false)]
    public bool? IsAuthenticated { get; set; }

    
    /// <summary>
    /// Gets or Sets SID
    /// </summary>
    [DataMember(Name="SID", EmitDefaultValue=false)]
    public string SID { get; set; }

    
    /// <summary>
    /// Gets or Sets ImpersonationLevel
    /// </summary>
    [DataMember(Name="ImpersonationLevel", EmitDefaultValue=false)]
    public int? ImpersonationLevel { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserInfo {\n");
      
      sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  IsAuthenticated: ").Append(IsAuthenticated).Append("\n");
      
      sb.Append("  SID: ").Append(SID).Append("\n");
      
      sb.Append("  ImpersonationLevel: ").Append(ImpersonationLevel).Append("\n");
      
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
