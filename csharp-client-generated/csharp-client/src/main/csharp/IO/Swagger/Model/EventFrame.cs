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
  public class EventFrame {
    
    /// <summary>
    /// Gets or Sets WebId
    /// </summary>
    [DataMember(Name="WebId", EmitDefaultValue=false)]
    public string WebId { get; set; }

    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="Path", EmitDefaultValue=false)]
    public string Path { get; set; }

    
    /// <summary>
    /// Gets or Sets TemplateName
    /// </summary>
    [DataMember(Name="TemplateName", EmitDefaultValue=false)]
    public string TemplateName { get; set; }

    
    /// <summary>
    /// Gets or Sets CategoryNames
    /// </summary>
    [DataMember(Name="CategoryNames", EmitDefaultValue=false)]
    public List<string> CategoryNames { get; set; }

    
    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="StartTime", EmitDefaultValue=false)]
    public string StartTime { get; set; }

    
    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="EndTime", EmitDefaultValue=false)]
    public string EndTime { get; set; }

    
    /// <summary>
    /// Gets or Sets AreValuesCaptured
    /// </summary>
    [DataMember(Name="AreValuesCaptured", EmitDefaultValue=false)]
    public bool? AreValuesCaptured { get; set; }

    
    /// <summary>
    /// Gets or Sets RefElementWebIds
    /// </summary>
    [DataMember(Name="RefElementWebIds", EmitDefaultValue=false)]
    public List<string> RefElementWebIds { get; set; }

    
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="Links", EmitDefaultValue=false)]
    public EventFrameLinks Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventFrame {\n");
      
      sb.Append("  WebId: ").Append(WebId).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
      sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
      
      sb.Append("  CategoryNames: ").Append(CategoryNames).Append("\n");
      
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      
      sb.Append("  AreValuesCaptured: ").Append(AreValuesCaptured).Append("\n");
      
      sb.Append("  RefElementWebIds: ").Append(RefElementWebIds).Append("\n");
      
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
