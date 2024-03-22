namespace CodePracticeLeetCodeTests
{
    internal class Problem0017_LetterCombinationsOfAPhoneNumber_Tests
    {
        private Problem0017_LetterCombinationsOfAPhoneNumber problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0017_LetterCombinationsOfAPhoneNumber();
        }

        [Test]
        public void TestCase1()
        {
            string digits = "23";
            List<string> output = new List<string>() { "ad", "ae", "af", "bd", "be", "bf","cd","ce","cf"};
            CollectionAssert.AreEquivalent(problem.LetterCombinations(digits), output);
        }

        [Test]
        public void TestCase2()
        {
            string digits = "";
            List<string> output = new List<string>() { };
            CollectionAssert.AreEquivalent(problem.LetterCombinations(digits), output);
        }

        [Test]
        public void TestCase3()
        {
            string digits = "2";
            List<string> output = new List<string>() { "a", "b", "c" };
            CollectionAssert.AreEquivalent(problem.LetterCombinations(digits), output);
        }
    }
}
