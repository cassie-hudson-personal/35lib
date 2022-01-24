using System;

namespace Core;

public class MediumBaseAttackStrategy : IBaseAttackStrategy
{
    public int Levelup(int level)
    {
        return (int) Math.Floor((decimal) ((level / 4) * 3));
    }
}