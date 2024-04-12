namespace CodePracticeLeetCodeTests
{
    internal class Problem0039_CombinationSum_Tests
    {
        private Problem0039_CombinationSum problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0039_CombinationSum();
        }

        [Test]
        public void TestCase1()
        {
            int[] candidates = { 2,3,6,7 };
            int target = 7;
            List<List<int>> output = new List<List<int>> { new List<int>() { 2,2,3 }, new List<int>() {7 } };
            CollectionAssert.AreEquivalent(problem.CombinationSum(candidates, target), output);
        }

        [Test]
        public void TestCase2()
        {
            int[] candidates = { 2,3,5 };
            int target = 8;
            List<List<int>> output = new List<List<int>> { new List<int>() { 2, 2, 2,2 }, new List<int>() { 2,3,3 }, new List<int>() { 3,5 } };
            CollectionAssert.AreEquivalent(problem.CombinationSum(candidates, target), output);
        }

        [Test]
        public void TestCase3()
        {
            int[] candidates = { 2 };
            int target = 1;
            List<List<int>> output = new List<List<int>>();
            CollectionAssert.AreEquivalent(problem.CombinationSum(candidates, target), output);
        }
    }
}
