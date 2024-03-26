namespace CodePracticeLeetCodeTests
{
    internal class Problem0026_RemoveDuplicatesFromSortedArray_Tests
    {
        private Problem0026_RemoveDuplicatesFromSortedArray problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0026_RemoveDuplicatesFromSortedArray();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = { 1, 1, 2 };
            int[] expectedNums = { 1, 2, 2 };
            int output = 2;
            Assert.That(problem.RemoveDuplicates(nums), Is.EqualTo(output));
            for (int i = 0; i < output; i++)
            {
                Assert.That(nums[i], Is.EqualTo(expectedNums[i]));
            }
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] expectedNums = { 0, 1, 2, 3, 4, 2 };
            int output = 5;
            Assert.That(problem.RemoveDuplicates(nums), Is.EqualTo(output));
            for (int i = 0; i < output; i++)
            {
                Assert.That(nums[i], Is.EqualTo(expectedNums[i]));
            }
        }
    }
}
