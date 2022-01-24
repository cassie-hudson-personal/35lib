using Core;
using NUnit.Framework;

namespace Test
{
    public class AcTest
    {
        [Test]
        public void TestArmorSizeClass()
        {
            var pc = new PlayerChar {Size = new SizeCat(SizeTypes.Medium)};
            Assert.AreEqual(10, pc.ArmourClass);
        }
    }
}