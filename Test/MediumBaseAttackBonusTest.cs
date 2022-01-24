using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void BaseAttackBonus_AtTenthLevel_IsSeven()
        {
            var medium = new MediumBaseAttackStrategy();

            medium.Levelup(10).ShouldBe(7);
        }
    }
}
