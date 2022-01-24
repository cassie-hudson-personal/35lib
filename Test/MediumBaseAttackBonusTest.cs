using Core;
using NUnit.Framework;
using Shouldly;

namespace Test
{
    internal class MediumBaseAttackBonusTest
    {
        [Test]
        public void BaseAttackBonus_AtFirstLevel_IsZero()
        {
            var medium = new MediumBaseAttackStrategy();

            medium.Levelup(1).ShouldBe(0);
        }
        [Test]
        public void BaseAttackBonus_Attwentiethlevel_Isfifteen()
        {
            var medium = new MediumBaseAttackStrategy();

            medium.Levelup(20).ShouldBe(15);
        }
    }
}
