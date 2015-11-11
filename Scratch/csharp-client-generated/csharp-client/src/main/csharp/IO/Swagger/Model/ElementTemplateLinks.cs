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
  public class ElementTemplateLinks {
    
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="Self", EmitDefaultValue=false)]
    public string Self { get; set; }

    
    /// <summary>
    /// Gets or Sets AttributeTemplates
    /// </summary>
    [DataMember(Name="AttributeTemplates", EmitDefaultValue=false)]
    public string AttributeTemplates { get; set; }

    
    /// <summary>
    /// Gets or Sets Database
    /// </summary>
    [DataMember(Name="Database", EmitDefaultValue=false)]
    public string Database { get; set; }

    
    /// <summary>
    /// Gets or Sets BaseTemplate
    /// </summary>
    [DataMember(Name="BaseTemplate", EmitDefaultValue=false)]
    public string BaseTemplate { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElementTemplateLinks {\n");
      
      sb.Append("  Self: ").Append(Self).Append("\n");
      
      sb.Append("  AttributeTemplates: ").Append(AttributeTemplates).Append("\n");
      
      sb.Append("  Database: ").Append(Database).Append("\n");
      
      sb.Append("  BaseTemplate: ").Append(BaseTemplate).Append("\n");
      
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
