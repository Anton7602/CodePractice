namespace CodePracticeLeetCodeTests
{
    internal class Problem0020_ValidParentheses_Tests
    {
        private Problem0020_ValidParentheses problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0020_ValidParentheses();
        }

        [Test]
        public void TestCase1()
        {
            string s = "()";
            bool output = true;
            Assert.That(problem.IsValid(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "()[]{}";
            bool output = true;
            Assert.That(problem.IsValid(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "(]";
            bool output = false;
            Assert.That(problem.IsValid(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "(";
            bool output = false;
            Assert.That(problem.IsValid(s), Is.EqualTo(output));
        }
    }
}
