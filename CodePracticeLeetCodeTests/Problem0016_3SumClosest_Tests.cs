namespace CodePracticeLeetCodeTests
{
    internal class Problem0016_3SumClosest_Tests
    {
        private Problem0016_3SumClosest problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0016_3SumClosest();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = { -1,2,1,-4 };
            int target = 1;
            int output = 2;
            Assert.That(problem.ThreeSumClosest(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = { 0,0,0 };
            int target = 1;
            int output = 0;
            Assert.That(problem.ThreeSumClosest(nums, target), Is.EqualTo(output));
        }
    }
}
