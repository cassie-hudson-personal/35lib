using System;

namespace Core
{
    public class AbilityScore
    {
        public int Score { get; set; }

        public int ScoreMod => (int) Math.Floor((Score - 10.0) / 2);

        public AbilityScore(int score)
        {
            Score = score;
        }
    }
}