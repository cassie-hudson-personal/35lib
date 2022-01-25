using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Core.Utils;

public class JobTemplate
{
    [JsonPropertyName("classname")]
    public string Name { get; set; }
    public short HitDice { get; set; }
    public IBaseAttackStrategy BaseAttackStrategy { get; set; }

    [JsonPropertyName("alignment")]
    public List<string> Alignment { get; set; }
    
}