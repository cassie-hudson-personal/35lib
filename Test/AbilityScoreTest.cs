using Core;
using NUnit.Framework;
using Shouldly;

namespace Test
{
    public class AbilityScoreTest
    {
        [Test]
        public void TestAbilityScoreModForTen()
        {
            var score = new AbilityScore(10);
            score.ScoreMod.ShouldBe(0);
        }

        [Test]
        public void TestAbilityScoreModFor3()
        {
            var score = new AbilityScore(3);
            score.ScoreMod.ShouldBe(-4);
        }

        [Test]
        public void TestAbilityScoreModFor18()
        {
            var score = new AbilityScore(18);
            score.ScoreMod.ShouldBe(4);
        }
    }
}