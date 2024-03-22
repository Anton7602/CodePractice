namespace CodePracticeLeetCodeTests
{
    internal class Problem0015_3Sum_Tests
    {
        private Problem0015_3Sum problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0015_3Sum();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = { -1,0,1,2,-1,-4 };
            List<List<int>> output = new List<List<int>>() { new List<int>() { -1, -1, 2 }, new List<int>() { -1, 0, 1 } };
            Assert.That(problem.ThreeSum(nums), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = { 0,1,1 };
            List<List<int>> output = new List<List<int>>();
            Assert.That(problem.ThreeSum(nums), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = { 0,0,0};
            List<List<int>> output = new List<List<int>>() { new List<int>() { 0, 0, 0 } };
            Assert.That(problem.ThreeSum(nums), Is.EqualTo(output));
        }
    }
}
