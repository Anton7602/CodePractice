namespace CodePracticeLeetCodeTests
{
    internal class Problem0032_LongestValidParentheses_Tests
    {
        private Problem0032_LongestValidParentheses problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0032_LongestValidParentheses();
        }

        [Test]
        public void TestCase1()
        {
            string s = "(()";
            int output = 2;
            Assert.That(problem.LongestValidParentheses(s) , Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = ")()())";
            int output = 4;
            Assert.That(problem.LongestValidParentheses(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "";
            int output = 0;
            Assert.That(problem.LongestValidParentheses(s), Is.EqualTo(output));
        }
    }
}
