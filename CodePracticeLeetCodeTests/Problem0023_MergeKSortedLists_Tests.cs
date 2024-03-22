namespace CodePracticeLeetCodeTests
{
    internal class Problem0023_MergeKSortedLists_Tests
    {
        private Problem0023_MergeKSortedLists problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0023_MergeKSortedLists();
        }

        [Test]
        public void TestCase1()
        {
            ListNode[] list = { new ListNode(1, new ListNode(4, new ListNode(5))),
            new ListNode(1, new ListNode(3, new ListNode(4))),
            new ListNode(2, new ListNode(6))};
            ListNode output = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, new ListNode(6))))))));
            Assert.That(problem.Solve(list), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            ListNode[] list = null;
            ListNode output = null;
            Assert.That(problem.Solve(list), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            ListNode[] list = { null };
            ListNode output = null;
            Assert.That(problem.Solve(list), Is.EqualTo(output));
        }
    }
}
