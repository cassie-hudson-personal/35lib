using System;

namespace Core;

public class MediumBaseAttackStrategy : IBaseAttackStrategy
{
    public int Levelup(int level)
    {
        //return (int) Math.Floor((decimal) ((level / 4) * 3));
        var divlevel = level / 4.0;
        var multiplied = divlevel * 3;
        return (int)multiplied;
    }
}