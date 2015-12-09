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
  public class CacheInstance {
    
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="Links", EmitDefaultValue=false)]
    public PageLinks Links { get; set; }

    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /// <summary>
    /// Gets or Sets LastRefreshTime
    /// </summary>
    [DataMember(Name="LastRefreshTime", EmitDefaultValue=false)]
    public string LastRefreshTime { get; set; }

    
    /// <summary>
    /// Gets or Sets WillRefreshAfter
    /// </summary>
    [DataMember(Name="WillRefreshAfter", EmitDefaultValue=false)]
    public string WillRefreshAfter { get; set; }

    
    /// <summary>
    /// Gets or Sets ScheduledExpirationTime
    /// </summary>
    [DataMember(Name="ScheduledExpirationTime", EmitDefaultValue=false)]
    public string ScheduledExpirationTime { get; set; }

    
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="User", EmitDefaultValue=false)]
    public string User { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CacheInstance {\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  LastRefreshTime: ").Append(LastRefreshTime).Append("\n");
      
      sb.Append("  WillRefreshAfter: ").Append(WillRefreshAfter).Append("\n");
      
      sb.Append("  ScheduledExpirationTime: ").Append(ScheduledExpirationTime).Append("\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
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
