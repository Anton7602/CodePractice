namespace CodePracticeLeetCodeTests
{
    internal class Problem0024_SwapNodesInPairs_Tests
    {
        private Problem0024_SwapNodesInPairs problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0024_SwapNodesInPairs();
        }

        [Test]
        public void TestCase1()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            ListNode output = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3))));
            Assert.That(problem.SwapPairs(head), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            ListNode head = null;
            ListNode output = null;
            Assert.That(problem.SwapPairs(head), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            ListNode head = new ListNode(1);
            ListNode output = new ListNode(1);
            Assert.That(problem.SwapPairs(head), Is.EqualTo(output));
        }
    }
}
