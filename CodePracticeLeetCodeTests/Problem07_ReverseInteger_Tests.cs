namespace CodePracticeLeetCodeTests
{
    internal class Problem07_ReverseInteger_Tests
    {
        private Problem07_ReverseInteger problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem07_ReverseInteger();
        }

        [Test]
        public void TestCase1()
        {
            int x = 123;
            int output = 321;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }


        [Test]
        public void TestCase2()
        {
            int x = -123;
            int output = -321;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }


        [Test]
        public void TestCase3()
        {
            int x = 120;
            int output = 21;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int x = -120;
            int output = -21;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int x = 0;
            int output = 0;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            int x = 2147483647;
            int output = 0;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            int x = -2147483648;
            int output = 0;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase8()
        {
            int x = 2147483641;
            int output = 1463847412;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase9()
        {
            int x = -2147483641;
            int output = -1463847412;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase10()
        {
            int x = 332165465;
            int output = 564561233;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }
    }
}
