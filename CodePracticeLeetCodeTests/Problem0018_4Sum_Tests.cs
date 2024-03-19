namespace CodePracticeLeetCodeTests
{
    internal class Problem0018_4Sum_Tests
    {
        private Problem0018_4Sum problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0018_4Sum();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = {1,0,-1,0,-2,2};
            int target = 0;
            List<List<int>> output = new List<List<int>> { new List<int>() {1,2,-1,-2 }, new List<int>() { 0,2,0,-2 }, new List<int>() { 0, 1, 0, -1 } };
            CollectionAssert.AreEquivalent(problem.Solve(nums, target), output);
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = {2,2,2,2,2};
            int target = 8;
            List<List<int>> output = new List<List<int>> { new List<int>() { 2, 2, 2, 2 } };
            CollectionAssert.AreEquivalent(problem.Solve(nums, target), output);
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = { 0, 0, 0, 0 };
            int target = 0;
            List<List<int>> output = new List<List<int>> { new List<int>() { 0, 0, 0, 0 } };
            CollectionAssert.AreEquivalent(problem.Solve(nums, target), output);
        }

        [Test]
        public void TestCase4()
        {
            int[] nums = { -1, 0, 1, 2,-1,-4 };
            int target = -1;
            List<List<int>> output = new List<List<int>> { new List<int>() { 0, 1, -1, -1 }, new List<int> {1,2,0,-4 } };
            CollectionAssert.AreEquivalent(problem.Solve(nums, target), output);
        }

        [Test]
        public void TestCase5()
        {
            int[] nums = { 1000000000, 1000000000, 1000000000, 1000000000};
            int target = -294967296;
            List<List<int>> output = new List<List<int>> { };
            CollectionAssert.AreEquivalent(problem.Solve(nums, target), output);
        }
    }
}
