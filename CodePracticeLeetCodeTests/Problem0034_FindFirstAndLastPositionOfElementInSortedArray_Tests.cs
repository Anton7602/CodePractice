namespace CodePracticeLeetCodeTests
{
    internal class Problem0034_FindFirstAndLastPositionOfElementInSortedArray_Tests
    {
        private Problem0034_FindFirstAndLastPositionOfElementInSortedArray problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0034_FindFirstAndLastPositionOfElementInSortedArray();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = { 5,7,7,8,8,10 };
            int target = 8;
            int[] output = {3,4};
            Assert.That(problem.SearchRange(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 6;
            int[] output = { -1, -1 };
            Assert.That(problem.SearchRange(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = { };
            int target = 0;
            int[] output = { -1, -1};
            Assert.That(problem.SearchRange(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int[] nums = { 1,2 };
            int target = 1;
            int[] output = { 0, 0 };
            Assert.That(problem.SearchRange(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int[] nums = {1 };
            int target = 2;
            int[] output = { -1, -1 };
            Assert.That(problem.SearchRange(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            int[] nums = { 1 };
            int target = 1;
            int[] output = { 0, 0 };
            Assert.That(problem.SearchRange(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            int[] nums = { 1, 1, 1, 1 };
            int target = 1;
            int[] output = { 0, 3 };
            Assert.That(problem.SearchRange(nums, target), Is.EqualTo(output));
        }
    }
}
