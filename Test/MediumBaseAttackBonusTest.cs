using Core;
using NUnit.Framework;
using Shouldly;
using System;

namespace Test
{
    internal class MediumBaseAttackBonusTest
    {
        [Test]
        public void BaseAttackBonus_testalllevels()
        {
            var medium = new MediumBaseAttackStrategy();

            var expeccy = new[] { 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15 };

            for (int i = 0; i < 20; i++)
            {

                medium.Levelup(i + 1).ShouldBe(expeccy[i]);
                Console.WriteLine(medium.Levelup(i + 1));
            }

        }
    }
}
