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
  public class AssetDatabaseLinks {
    
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="Self", EmitDefaultValue=false)]
    public string Self { get; set; }

    
    /// <summary>
    /// Gets or Sets Elements
    /// </summary>
    [DataMember(Name="Elements", EmitDefaultValue=false)]
    public string Elements { get; set; }

    
    /// <summary>
    /// Gets or Sets ElementTemplates
    /// </summary>
    [DataMember(Name="ElementTemplates", EmitDefaultValue=false)]
    public string ElementTemplates { get; set; }

    
    /// <summary>
    /// Gets or Sets EventFrames
    /// </summary>
    [DataMember(Name="EventFrames", EmitDefaultValue=false)]
    public string EventFrames { get; set; }

    
    /// <summary>
    /// Gets or Sets AssetServer
    /// </summary>
    [DataMember(Name="AssetServer", EmitDefaultValue=false)]
    public string AssetServer { get; set; }

    
    /// <summary>
    /// Gets or Sets ElementCategories
    /// </summary>
    [DataMember(Name="ElementCategories", EmitDefaultValue=false)]
    public string ElementCategories { get; set; }

    
    /// <summary>
    /// Gets or Sets AttributeCategories
    /// </summary>
    [DataMember(Name="AttributeCategories", EmitDefaultValue=false)]
    public string AttributeCategories { get; set; }

    
    /// <summary>
    /// Gets or Sets TableCategories
    /// </summary>
    [DataMember(Name="TableCategories", EmitDefaultValue=false)]
    public string TableCategories { get; set; }

    
    /// <summary>
    /// Gets or Sets EnumerationSets
    /// </summary>
    [DataMember(Name="EnumerationSets", EmitDefaultValue=false)]
    public string EnumerationSets { get; set; }

    
    /// <summary>
    /// Gets or Sets Tables
    /// </summary>
    [DataMember(Name="Tables", EmitDefaultValue=false)]
    public string Tables { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDatabaseLinks {\n");
      
      sb.Append("  Self: ").Append(Self).Append("\n");
      
      sb.Append("  Elements: ").Append(Elements).Append("\n");
      
      sb.Append("  ElementTemplates: ").Append(ElementTemplates).Append("\n");
      
      sb.Append("  EventFrames: ").Append(EventFrames).Append("\n");
      
      sb.Append("  AssetServer: ").Append(AssetServer).Append("\n");
      
      sb.Append("  ElementCategories: ").Append(ElementCategories).Append("\n");
      
      sb.Append("  AttributeCategories: ").Append(AttributeCategories).Append("\n");
      
      sb.Append("  TableCategories: ").Append(TableCategories).Append("\n");
      
      sb.Append("  EnumerationSets: ").Append(EnumerationSets).Append("\n");
      
      sb.Append("  Tables: ").Append(Tables).Append("\n");
      
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
