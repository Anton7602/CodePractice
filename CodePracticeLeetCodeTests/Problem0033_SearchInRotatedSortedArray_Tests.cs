namespace CodePracticeLeetCodeTests
{
    internal class Problem0033_SearchInRotatedSortedArray_Tests
    {
        private Problem0033_SearchInRotatedSortedArray problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0033_SearchInRotatedSortedArray();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            int output = 4;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 3;
            int output = -1;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = { 1};
            int target = 0;
            int output = -1;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int[] nums = { 2,1 };
            int target = 2;
            int output = 0;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int[] nums = { 2, 3, 4, 5, 6, 7, 8, 1 };
            int target = 8;
            int output = 6;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            int[] nums = { 0,1,2,3,4,5,6,7,8,9 };
            int target = 2;
            int output = 2;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            int[] nums = {1, 3};
            int target = 1;
            int output = 0;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }


        [Test]
        public void TestCase8()
        {
            int[] nums = { 3,1 };
            int target = 1;
            int output = 1;
            Assert.That(problem.Search(nums, target), Is.EqualTo(output));
        }


    }
}
