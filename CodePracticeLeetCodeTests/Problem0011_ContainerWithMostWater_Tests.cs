namespace CodePracticeLeetCodeTests
{
    internal class Problem0011_ContainerWithMostWater_Tests
    {
        private Problem0011_ContainerWithMostWater problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem0011_ContainerWithMostWater();
        }

        [Test]
        public void TestCase1()
        {
            int[] height = [1,8,6,2,5,4,8,3,7];
            int output = 49;
            Assert.That(problem.MaxArea(height), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int[] height = [1,1];
            int output = 1;
            Assert.That(problem.MaxArea(height), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int[] height = [5,8];
            int output = 5;
            Assert.That(problem.MaxArea(height), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int[] height = [10, 15, 8, 5, 7, 2, 5, 9, 6, 14, 11, 12, 3, 7, 9, 18, 24, 19, 8, 2, 2, 1];
            int output = 240;
            Assert.That(problem.MaxArea(height), Is.EqualTo(output));
        }
    }
}
