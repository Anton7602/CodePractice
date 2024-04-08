namespace CodePracticeLeetCodeTests
{
    internal class Problem0035_SearchInsertPosition_Tests
    {
        private Problem0035_SearchInsertPosition problem;
        [SetUp]
        public void Setup()
        {
            problem =  new Problem0035_SearchInsertPosition();
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = { 1,3,5,6 };
            int target = 5;
            int output = 2;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;
            int output = 1;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;
            int output = 4;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int[] nums = { 3 };
            int target = 4;
            int output = 1;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int[] nums = { 3 };
            int target = 3;
            int output = 0;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            int[] nums = { 1, 2, 4, 5, 7, 8, 9, };
            int target = 6;
            int output = 4;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            int[] nums = { 1, 2, 4, 5, 7, 8, 9 };
            int target = -1;
            int output = 0;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase8()
        {
            int[] nums = { 1, 2, 4, 5, 7, 8, 9 };
            int target = 9;
            int output = 6;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }

        [Test]
        public void TestCase9()
        {
            int[] nums = { 1, 4 };
            int target = 2;
            int output = 1;
            Assert.That(problem.SearchInsert(nums, target), Is.EqualTo(output));
        }
    }
}
