namespace CodePracticeLeetCodeTests
{
    internal class Problem0027_RemoveElement_Tests
    {
        private Problem0027_RemoveElement problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0027_RemoveElement();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int[] expectedNums = { 2, 2, 2,3 };
            int output = 2;
            Assert.That(problem.RemoveElement(nums,val), Is.EqualTo(output));
            for (int i = 0; i < output; i++)
            {
                Assert.That(nums[i], Is.EqualTo(expectedNums[i]));
            }
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = { 0, 1, 2, 2,3,0,4,2 };
            int val = 2;
            int[] expectedNums = { 0,1,3,0,4,0,4,2 };
            int output = 5;
            Assert.That(problem.RemoveElement(nums, val), Is.EqualTo(output));
            for (int i = 0; i < output; i++)
            {
                Assert.That(nums[i], Is.EqualTo(expectedNums[i]));
            }
        }
    }
}
