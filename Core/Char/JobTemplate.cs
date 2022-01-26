using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Core.Utils;

public class JobTemplate
{
    [JsonPropertyName("classname")]
    public string Name { get; set; }
    public int HitDice { get; set; }
    private string _bab;
    public string Bab { set { _bab = value; } }


    public IBaseAttack BaseAttack
    {
        get
        {
            if (_bab == "High")
            {
                return new HBaseAttack();
            }
            else if (_bab == "Medium")
            {
                return new MBaseAttack();
            }
            else
            {
                return new LBaseAttack();
            }
        }
    }

    }

    public List<string> Alignment { get; set; }

}