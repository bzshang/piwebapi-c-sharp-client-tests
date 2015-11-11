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
  public class Unit {
    
    /// <summary>
    /// Gets or Sets WebId
    /// </summary>
    [DataMember(Name="webId", EmitDefaultValue=false)]
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
    /// Gets or Sets Abbreviation
    /// </summary>
    [DataMember(Name="Abbreviation", EmitDefaultValue=false)]
    public string Abbreviation { get; set; }

    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    /// <summary>
    /// Gets or Sets CanonicalUnitName
    /// </summary>
    [DataMember(Name="CanonicalUnitName", EmitDefaultValue=false)]
    public string CanonicalUnitName { get; set; }

    
    /// <summary>
    /// Gets or Sets CanonicalUnitAbbreviation
    /// </summary>
    [DataMember(Name="CanonicalUnitAbbreviation", EmitDefaultValue=false)]
    public string CanonicalUnitAbbreviation { get; set; }

    
    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="Path", EmitDefaultValue=false)]
    public string Path { get; set; }

    
    /// <summary>
    /// Gets or Sets Factor
    /// </summary>
    [DataMember(Name="Factor", EmitDefaultValue=false)]
    public double? Factor { get; set; }

    
    /// <summary>
    /// Gets or Sets Offset
    /// </summary>
    [DataMember(Name="Offset", EmitDefaultValue=false)]
    public string Offset { get; set; }

    
    /// <summary>
    /// Gets or Sets ReferenceFactor
    /// </summary>
    [DataMember(Name="ReferenceFactor", EmitDefaultValue=false)]
    public string ReferenceFactor { get; set; }

    
    /// <summary>
    /// Gets or Sets ReferenceOffset
    /// </summary>
    [DataMember(Name="ReferenceOffset", EmitDefaultValue=false)]
    public string ReferenceOffset { get; set; }

    
    /// <summary>
    /// Gets or Sets ReferenceUnitAbbreviation
    /// </summary>
    [DataMember(Name="ReferenceUnitAbbreviation", EmitDefaultValue=false)]
    public string ReferenceUnitAbbreviation { get; set; }

    
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="Links", EmitDefaultValue=false)]
    public Links Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Unit {\n");
      
      sb.Append("  WebId: ").Append(WebId).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  CanonicalUnitName: ").Append(CanonicalUnitName).Append("\n");
      
      sb.Append("  CanonicalUnitAbbreviation: ").Append(CanonicalUnitAbbreviation).Append("\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
      sb.Append("  Factor: ").Append(Factor).Append("\n");
      
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      
      sb.Append("  ReferenceFactor: ").Append(ReferenceFactor).Append("\n");
      
      sb.Append("  ReferenceOffset: ").Append(ReferenceOffset).Append("\n");
      
      sb.Append("  ReferenceUnitAbbreviation: ").Append(ReferenceUnitAbbreviation).Append("\n");
      
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
