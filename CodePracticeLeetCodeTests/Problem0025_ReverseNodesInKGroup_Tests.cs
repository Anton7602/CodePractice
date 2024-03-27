namespace CodePracticeLeetCodeTests
{
    internal class Problem0025_ReverseNodesInKGroup_Tests
    {
        private Problem0025_ReverseNodesInKGroup problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0025_ReverseNodesInKGroup();
        }

        [Test]
        public void TestCase1()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int k = 2;
            ListNode output = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(5)))));
            Assert.That(problem.ReverseKGroup(head, k), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int k = 3;
            ListNode output = new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(5)))));
            Assert.That(problem.ReverseKGroup(head, k), Is.EqualTo(output));
        }
    }
}
