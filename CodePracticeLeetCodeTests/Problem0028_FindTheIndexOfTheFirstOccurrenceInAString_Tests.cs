namespace CodePracticeLeetCodeTests
{
    internal class Problem0028_FindTheIndexOfTheFirstOccurrenceInAString_Tests
    {
        private Problem0028_FindTheIndexOfTheFirstOccurrenceInAString problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0028_FindTheIndexOfTheFirstOccurrenceInAString();
        }

        [Test]
        public void TestCase1()
        {
            string haystack = "sadbutsad";
            string needle = "sad";
            int output = 0;
            Assert.That(problem.StrStr(haystack, needle), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string haystack = "leetcode";
            string needle = "leeto";
            int output = -1;
            Assert.That(problem.StrStr(haystack, needle), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string haystack = "ssssadbutsad";
            string needle = "sad";
            int output = 3;
            Assert.That(problem.StrStr(haystack, needle), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string haystack = "sasasadbutsasasad";
            string needle = "sad";
            int output = 4;
            Assert.That(problem.StrStr(haystack, needle), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            string haystack = "sasasabutsasasad";
            string needle = "sad";
            int output = 13;
            Assert.That(problem.StrStr(haystack, needle), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            string haystack = "a";
            string needle = "a";
            int output = 0;
            Assert.That(problem.StrStr(haystack, needle), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            string haystack = "mississippi";
            string needle = "issip";
            int output = 4;
            Assert.That(problem.StrStr(haystack, needle), Is.EqualTo(output));
        }
    }
}
