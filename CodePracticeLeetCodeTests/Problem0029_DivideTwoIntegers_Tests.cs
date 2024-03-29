namespace CodePracticeLeetCodeTests
{
    internal class Problem0029_DivideTwoIntegers_Tests
    {
        private Problem0029_DivideTwoIntegers problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0029_DivideTwoIntegers();
        }

        [Test]
        public void TestCase1()
        {
            int divident = 10;
            int divisor = 3;
            int output = 3;
            Assert.That(problem.Divide(divident, divisor), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int divident = 7;
            int divisor = -3;
            int output = -2;
            Assert.That(problem.Divide(divident, divisor), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int divident = -2147483648;
            int divisor = 1;
            int output = -2147483648;
            Assert.That(problem.Divide(divident, divisor), Is.EqualTo(output));
        }
    }
}
