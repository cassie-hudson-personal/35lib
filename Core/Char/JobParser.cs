namespace Core;

public class JobParser
{
    public JobTemplate CreateJobTemplate(string path)
    {
        return new
            JobTemplate{Name = "Fighter",HitDice = 10, BaseAttackStrategy = new HighBaseAttackStrategy()};
    }
}