namespace CodePracticeLeetCodeTests
{
    internal class Problem0014_LongestCommonPrefix_Tests
    {
        private Problem0014_LongestCommonPrefix problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem0014_LongestCommonPrefix();
        }

        [Test]
        public void TestCase1()
        {
            string[] strs = { "flower", "flow", "flight" };
            string output = "fl";
            Assert.That(problem.LongestCommonPrefix(strs), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string[] strs = { "dog", "racecar", "car" };
            string output = "";
            Assert.That(problem.LongestCommonPrefix(strs), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string[] strs = { "substring" };
            string output = "substring";
            Assert.That(problem.LongestCommonPrefix(strs), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string[] strs = { "", "" };
            string output = "";
            Assert.That(problem.LongestCommonPrefix(strs), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            string[] strs = { "testcase", "testcase" };
            string output = "testcase";
            Assert.That(problem.LongestCommonPrefix(strs), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            string[] strs = { };
            string output = "";
            Assert.That(problem.LongestCommonPrefix(strs), Is.EqualTo(output));
        }
    }
}
