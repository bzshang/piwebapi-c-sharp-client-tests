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
  public class AFWebAttribute {
    
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
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Gets or Sets TypeQualifier
    /// </summary>
    [DataMember(Name="TypeQualifier", EmitDefaultValue=false)]
    public string TypeQualifier { get; set; }

    
    /// <summary>
    /// Gets or Sets DefaultUnitsName
    /// </summary>
    [DataMember(Name="DefaultUnitsName", EmitDefaultValue=false)]
    public string DefaultUnitsName { get; set; }

    
    /// <summary>
    /// Gets or Sets DataReferencePlugIn
    /// </summary>
    [DataMember(Name="DataReferencePlugIn", EmitDefaultValue=false)]
    public string DataReferencePlugIn { get; set; }

    
    /// <summary>
    /// Gets or Sets ConfigString
    /// </summary>
    [DataMember(Name="ConfigString", EmitDefaultValue=false)]
    public string ConfigString { get; set; }

    
    /// <summary>
    /// Gets or Sets IsConfigurationItem
    /// </summary>
    [DataMember(Name="IsConfigurationItem", EmitDefaultValue=false)]
    public bool? IsConfigurationItem { get; set; }

    
    /// <summary>
    /// Gets or Sets IsExcluded
    /// </summary>
    [DataMember(Name="IsExcluded", EmitDefaultValue=false)]
    public bool? IsExcluded { get; set; }

    
    /// <summary>
    /// Gets or Sets IsHidden
    /// </summary>
    [DataMember(Name="IsHidden", EmitDefaultValue=false)]
    public bool? IsHidden { get; set; }

    
    /// <summary>
    /// Gets or Sets CategoryNames
    /// </summary>
    [DataMember(Name="CategoryNames", EmitDefaultValue=false)]
    public List<string> CategoryNames { get; set; }

    
    /// <summary>
    /// Gets or Sets Step
    /// </summary>
    [DataMember(Name="Step", EmitDefaultValue=false)]
    public bool? Step { get; set; }

    
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="Links", EmitDefaultValue=false)]
    public AttributeLink Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AFWebAttribute {\n");
      
      sb.Append("  WebId: ").Append(WebId).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  TypeQualifier: ").Append(TypeQualifier).Append("\n");
      
      sb.Append("  DefaultUnitsName: ").Append(DefaultUnitsName).Append("\n");
      
      sb.Append("  DataReferencePlugIn: ").Append(DataReferencePlugIn).Append("\n");
      
      sb.Append("  ConfigString: ").Append(ConfigString).Append("\n");
      
      sb.Append("  IsConfigurationItem: ").Append(IsConfigurationItem).Append("\n");
      
      sb.Append("  IsExcluded: ").Append(IsExcluded).Append("\n");
      
      sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
      
      sb.Append("  CategoryNames: ").Append(CategoryNames).Append("\n");
      
      sb.Append("  Step: ").Append(Step).Append("\n");
      
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
