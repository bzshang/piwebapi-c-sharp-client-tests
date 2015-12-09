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
  public class TimedValue {
    
    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="Timestamp", EmitDefaultValue=false)]
    public string Timestamp { get; set; }

    
    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    public string Value { get; set; }

    
    /// <summary>
    /// Gets or Sets UnitsAbbreviation
    /// </summary>
    [DataMember(Name="UnitsAbbreviation", EmitDefaultValue=false)]
    public string UnitsAbbreviation { get; set; }

    
    /// <summary>
    /// Gets or Sets Good
    /// </summary>
    [DataMember(Name="Good", EmitDefaultValue=false)]
    public bool? Good { get; set; }

    
    /// <summary>
    /// Gets or Sets Questionable
    /// </summary>
    [DataMember(Name="Questionable", EmitDefaultValue=false)]
    public bool? Questionable { get; set; }

    
    /// <summary>
    /// Gets or Sets Substituted
    /// </summary>
    [DataMember(Name="Substituted", EmitDefaultValue=false)]
    public bool? Substituted { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimedValue {\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  UnitsAbbreviation: ").Append(UnitsAbbreviation).Append("\n");
      
      sb.Append("  Good: ").Append(Good).Append("\n");
      
      sb.Append("  Questionable: ").Append(Questionable).Append("\n");
      
      sb.Append("  Substituted: ").Append(Substituted).Append("\n");
      
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
