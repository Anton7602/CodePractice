namespace CodePracticeLeetCodeTests
{
    internal class Problem5_LongestPalindromicSubstring_Tests
    {
        private Problem5_LongestPalindromicSubstring problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem5_LongestPalindromicSubstring();
        }

        [Test]
        public void TestCase1()
        {
            string s = "babad";
            string output = "bab";
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }


        [Test]
        public void TestCase2()
        {
            string s = "cbbd";
            string output = "bb";
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "a";
            string output = "a";
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "abcdefg";
            string output = "a";
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            string s = "bb";
            string output = "bb";
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }
    }
}
