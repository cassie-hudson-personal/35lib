namespace Core;

public class JobTemplate
{
    public string Name { get; set; }
    public short HitDice { get; set; }
    public IBaseAttackStrategy BaseAttackStrategy { get; set; }

}