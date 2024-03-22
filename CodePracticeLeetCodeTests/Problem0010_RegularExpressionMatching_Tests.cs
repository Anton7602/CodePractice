namespace CodePracticeLeetCodeTests
{
    internal class Problem0010_RegularExpressionMatching_Tests
    {
        private Problem0010_RegularExpressionMatching problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem0010_RegularExpressionMatching();
        }

        [Test]
        public void TestCase1()
        {
            string s = "aa";
            string p = "a";
            bool output = false;
            Assert.That(problem.IsMatch(s,p), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "aa";
            string p = "a*";
            bool output = true;
            Assert.That(problem.IsMatch(s, p), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "aa";
            string p = ".*";
            bool output = true;
            Assert.That(problem.IsMatch(s, p), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "xaabyc";
            string p = "xa*b.c";
            bool output = true;
            Assert.That(problem.IsMatch(s, p), Is.EqualTo(output));
        }
    }
}
