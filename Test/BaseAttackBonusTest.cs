using Core;
using NUnit.Framework;
using Shouldly;
using System;

namespace Test
{
    internal class BaseAttackBonusTest
    {
        [Test]
        public void HBaseAttackBonustest()
        {
            var high = new HBaseAttack();
            for (int i = 0; i < 20; i++)
            {
           
                high.Levelup(i + 1).ShouldBe(i+1);
            }
            
            
        }


        [Test]
        public void MBaseAttackBonus_testalllevels()
        {
            var medium = new MBaseAttack();

            var expeccy = new[] { 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15 };

            for (int i = 0; i < 20; i++)
            {

                medium.Levelup(i + 1).ShouldBe(expeccy[i]);
                Console.WriteLine(medium.Levelup(i + 1));
            }

        }
        [Test]
        public void LBaseAttackBonustest()
        {
            var low = new LBaseAttack();

            
            var expeccy = new[] { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 };
            for (int i = 0; i < expeccy.Length; i++)
            {
                
                Console.WriteLine(low.Levelup(i+1));
                low.Levelup(i+1).ShouldBe(expeccy[i]);
                

                var bab = low.Levelup(i+1);
                Console.WriteLine($"level{i} is {bab}");

            }

        }

    }
}
