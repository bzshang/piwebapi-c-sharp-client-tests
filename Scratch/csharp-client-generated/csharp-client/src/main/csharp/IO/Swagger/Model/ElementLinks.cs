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
  public class ElementLinks {
    
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="Self", EmitDefaultValue=false)]
    public string Self { get; set; }

    
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="Attributes", EmitDefaultValue=false)]
    public string Attributes { get; set; }

    
    /// <summary>
    /// Gets or Sets Elements
    /// </summary>
    [DataMember(Name="Elements", EmitDefaultValue=false)]
    public string Elements { get; set; }

    
    /// <summary>
    /// Gets or Sets Database
    /// </summary>
    [DataMember(Name="Database", EmitDefaultValue=false)]
    public string Database { get; set; }

    
    /// <summary>
    /// Gets or Sets Parent
    /// </summary>
    [DataMember(Name="Parent", EmitDefaultValue=false)]
    public string Parent { get; set; }

    
    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="Template", EmitDefaultValue=false)]
    public string Template { get; set; }

    
    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [DataMember(Name="Categories", EmitDefaultValue=false)]
    public string Categories { get; set; }

    
    /// <summary>
    /// Gets or Sets EventFrames
    /// </summary>
    [DataMember(Name="EventFrames", EmitDefaultValue=false)]
    public string EventFrames { get; set; }

    
    /// <summary>
    /// Gets or Sets InterpolatedData
    /// </summary>
    [DataMember(Name="InterpolatedData", EmitDefaultValue=false)]
    public string InterpolatedData { get; set; }

    
    /// <summary>
    /// Gets or Sets RecordedData
    /// </summary>
    [DataMember(Name="RecordedData", EmitDefaultValue=false)]
    public string RecordedData { get; set; }

    
    /// <summary>
    /// Gets or Sets PlotData
    /// </summary>
    [DataMember(Name="PlotData", EmitDefaultValue=false)]
    public string PlotData { get; set; }

    
    /// <summary>
    /// Gets or Sets SummaryData
    /// </summary>
    [DataMember(Name="SummaryData", EmitDefaultValue=false)]
    public string SummaryData { get; set; }

    
    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    public string Value { get; set; }

    
    /// <summary>
    /// Gets or Sets EndValue
    /// </summary>
    [DataMember(Name="EndValue", EmitDefaultValue=false)]
    public string EndValue { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElementLinks {\n");
      
      sb.Append("  Self: ").Append(Self).Append("\n");
      
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      
      sb.Append("  Elements: ").Append(Elements).Append("\n");
      
      sb.Append("  Database: ").Append(Database).Append("\n");
      
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      
      sb.Append("  Template: ").Append(Template).Append("\n");
      
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      
      sb.Append("  EventFrames: ").Append(EventFrames).Append("\n");
      
      sb.Append("  InterpolatedData: ").Append(InterpolatedData).Append("\n");
      
      sb.Append("  RecordedData: ").Append(RecordedData).Append("\n");
      
      sb.Append("  PlotData: ").Append(PlotData).Append("\n");
      
      sb.Append("  SummaryData: ").Append(SummaryData).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  EndValue: ").Append(EndValue).Append("\n");
      
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
