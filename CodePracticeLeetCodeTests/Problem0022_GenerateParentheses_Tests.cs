namespace CodePracticeLeetCodeTests
{
    internal class Problem0022_GenerateParentheses_Tests
    {
        private Problem0022_GenerateParentheses problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0022_GenerateParentheses();
        }

        [Test]
        public void TestCase1()
        {
            int n = 1;
            List<string> output = new List<string>() { "()"};
            Assert.That(problem.GenerateParenthesis(n), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int n = 2;
            List<string> output = new List<string>() { "(())", "()()" };
            Assert.That(problem.GenerateParenthesis(n), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int n = 3;
            List<string> output = new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" };
            Assert.That(problem.GenerateParenthesis(n), Is.EqualTo(output));
        }
    }
}
