using Core.Utils;
using NUnit.Framework;
using Shouldly;

namespace Test
{
    internal class JasonTest
    {
        [Test]
        public void TestJsonLoading()
        {
            var TestLoader = new JobLoader();

            TestLoader.JobList.Count.ShouldBe(1);

            JobTemplate Job = TestLoader.JobList["barb"];
            Job.Name.ShouldBe("Barbarian");
            Job.Alignment.Count.ShouldBe(2);
            Job.Alignment.Contains("chaotic").ShouldBeTrue();
        }
    }
}
