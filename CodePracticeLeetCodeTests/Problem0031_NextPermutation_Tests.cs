namespace CodePracticeLeetCodeTests
{
    internal class Problem0031_NextPermutation_Tests
    {
        private Problem0031_NextPermutation problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0031_NextPermutation();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = new int[] { 1, 2, 3 };
            int[] output = new int[] { 1, 3, 2, };
            problem.NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = new int[] { 3, 2, 1 };
            int[] output = new int[] { 1, 2, 3 };
            problem.NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = new int[] { 1, 1, 5 };
            int[] output = new int[] { 1, 5, 1 };
            problem.NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(output));
        }


        [Test]
        public void TestCase4()
        {
            int[] nums = new int[] { 1, 2 };
            int[] output = new int[] { 2, 1 };
            problem.NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int[] nums = new int[] { 1, 5, 1 };
            int[] output = new int[] { 5, 1, 1 };
            problem.NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            int[] nums = new int[] { 5, 1, 1 };
            int[] output = new int[] { 1, 1, 5 };
            problem.NextPermutation(nums);
            Assert.That(nums, Is.EqualTo(output));
        }
    }
}
