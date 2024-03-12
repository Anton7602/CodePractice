namespace CodePracticeLeetCodeTests
{
    public class Problem08_StringToIntegerAtoi_Tests
    {
        private Problem08_StringToIntegerAtoi problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem08_StringToIntegerAtoi();
        }

        [Test]
        public void TestCase1()
        {
            string s = "42";
            int output = 42;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "   -42";
            int output = -42;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "4193 with words";
            int output = 4193;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "2147483648sdfse with words";
            int output = 2147483647;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            string s = "2147483649sdfse with words";
            int output = 2147483647;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            string s = "   2147483646    sdfse with words";
            int output = 2147483646;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            string s = "10";
            int output = 10;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase8()
        {
            string s = "0";
            int output = 0;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase9()
        {
            string s = "   +85 вапв";
            int output = 85;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase10()
        {
            string s = "   -2147483648 вапв";
            int output = -2147483648;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }
        [Test]
        public void TestCase11()
        {
            string s = "  -2147483652 вапв";
            int output = -2147483648;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }
        [Test]
        public void TestCase12()
        {
            string s = "   -2147483642 вапв";
            int output = -2147483642;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase13()
        {
            string s = "  0000000000012345678";
            int output = 12345678;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }
    }
}
