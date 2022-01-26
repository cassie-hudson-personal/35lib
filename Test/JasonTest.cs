using Core.Utils;
using NUnit.Framework;
using Shouldly;
using Core;

namespace Test
{
    internal class JasonTest
    {
        [Test]
        public void TestJsonLoading()
        {
            var TestLoader = new JobLoader();

            TestLoader.JobList.Count.ShouldBe(8);

            JobTemplate Job = TestLoader.JobList["Barbarian"];
            Job.Name.ShouldBe("Barbarian");
            Job.Alignment.Count.ShouldBe(2);
            Job.Alignment.Contains("chaotic").ShouldBeTrue();
            Job.HitDice.ShouldBe(12);
            Job.BaseAttack.Levelup(20).ShouldBe(20);
            Job.BaseAttack.ShouldBeOfType<HBaseAttack>();
        }
    }
}
