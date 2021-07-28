using NUnit.Framework;
using OperatorsApp;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(4)]
        public void TestMethod1(int x)
        {
            Assert.That(Program.EvenOdd(x), Is.EqualTo(true));
        }
    }
}