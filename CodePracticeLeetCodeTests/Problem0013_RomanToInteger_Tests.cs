namespace CodePracticeLeetCodeTests
{
    internal class Problem0013_RomanToInteger_Tests
    {
        private Problem0013_RomanToInteger problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem0013_RomanToInteger();
        }

        [Test]
        public void TestCase1()
        {
            string s = "III";
            int output = 3;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "LVIII";
            int output = 58;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "MCMXCIV";
            int output = 1994;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "CDLXXXIX";
            int output = 489;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            string s = "DCCCXCIV";
            int output = 894;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            string s = "DXII";
            int output = 512;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            string s = "X";
            int output = 10;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase8()
        {
            string s = "I";
            int output = 1;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase9()
        {
            string s = "MMMCMXCIX";
            int output = 3999;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }
    }
}
