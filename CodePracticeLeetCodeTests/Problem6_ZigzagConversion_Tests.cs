namespace CodePracticeLeetCodeTests
{
    internal class Problem6_ZigzagConversion_Tests
    {
        private Problem6_ZigzagConversion problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem6_ZigzagConversion();
        }

        [Test]
        public void TestCase1()
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string output = "PAHNAPLSIIGYIR";
            Assert.That(problem.Solve(s, numRows), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "PAYPALISHIRING";
            int numRows = 4;
            string output = "PINALSIGYAHRPI";
            Assert.That(problem.Solve(s, numRows), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "A";
            int numRows = 1;
            string output = "A";
            Assert.That(problem.Solve(s, numRows), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "AsdfrsSFSDf,.sdffsetcset";
            int numRows = 1;
            string output = "AsdfrsSFSDf,.sdffsetcset";
            Assert.That(problem.Solve(s, numRows), Is.EqualTo(output));
        }
    }
}
