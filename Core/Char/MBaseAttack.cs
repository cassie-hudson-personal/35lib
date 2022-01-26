using System;

namespace Core;

public class MBaseAttack : IBaseAttack
{
    public int Levelup(int level)
    {
        //return (int) Math.Floor((decimal) ((level / 4) * 3));
        var divlevel = level / 4.0;
        var multiplied = divlevel * 3;
        return (int)multiplied;
    }
}
public class HBaseAttack : IBaseAttack
{
    public int Levelup(int level)
    {
        return level;
    }
}
public class LBaseAttack : IBaseAttack
{
    public int Levelup(int level)
    {
        return (int)Math.Floor((decimal)(level / 2));
    }
}