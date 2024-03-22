namespace CodePracticeLeetCodeTests
{
    internal class Problem0006_ZigzagConversion_Tests
    {
        private Problem0006_ZigzagConversion problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem0006_ZigzagConversion();
        }

        [Test]
        public void TestCase1()
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string output = "PAHNAPLSIIGYIR";
            Assert.That(problem.Convert(s, numRows), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "PAYPALISHIRING";
            int numRows = 4;
            string output = "PINALSIGYAHRPI";
            Assert.That(problem.Convert(s, numRows), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "A";
            int numRows = 1;
            string output = "A";
            Assert.That(problem.Convert(s, numRows), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "AsdfrsSFSDf,.sdffsetcset";
            int numRows = 1;
            string output = "AsdfrsSFSDf,.sdffsetcset";
            Assert.That(problem.Convert(s, numRows), Is.EqualTo(output));
        }
    }
}
