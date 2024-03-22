namespace CodePracticeLeetCodeTests
{
    internal class Problem0001_TwoSum_Tests
    {
        private Problem0001_TwoSum problem { get; set; }

        [SetUp]
        public void Setup()
        {
            problem = new Problem0001_TwoSum();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;
            int[] output = [0, 1];
            Assert.That(output, Is.EqualTo(problem.TwoSum(nums, target)));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = [3, 2, 4];
            int target = 6;
            int[] output = [1, 2];
            Assert.That(output, Is.EqualTo(problem.TwoSum(nums, target)));
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = [3, 3];
            int target = 6;
            int[] output = [0, 1];
            Assert.That(output, Is.EqualTo(problem.TwoSum(nums, target)));
        }
    }
}
