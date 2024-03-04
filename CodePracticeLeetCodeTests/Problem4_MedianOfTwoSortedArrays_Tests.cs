namespace CodePracticeLeetCodeTests
{
    internal class Problem4_MedianOfTwoSortedArrays_Tests
    {
        private Problem4_MedianOfTwoSortedArrays problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem4_MedianOfTwoSortedArrays();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums1 = [1,3];
            int[] nums2 = [2];
            double output = 2.0;
            Assert.That(problem.Solve(nums1, nums2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums1 = [1, 2];
            int[] nums2 = [3, 4];
            double output = 2.5;
            Assert.That(problem.Solve(nums1, nums2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int[] nums1 = [];
            int[] nums2 = [6, 7,8,9];
            double output = 7.5;
            Assert.That(problem.Solve(nums1, nums2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int[] nums1 = [-10,-5, 5, 10];
            int[] nums2 = [];
            double output = 0;
            Assert.That(problem.Solve(nums1, nums2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int[] nums1 = [1, 2, 3, 4,5,6];
            int[] nums2 = [1,2,3];
            double output = 3;
            Assert.That(problem.Solve(nums1, nums2), Is.EqualTo(output));
        }

        [Test]
        public void EdgeCaseMin_TestCase()
        {
            int[] nums1 = [];
            int[] nums2 = [];
            double output = 0.0;
            Assert.That(problem.Solve(nums1, nums2), Is.EqualTo(output));
        }
    }
}
