namespace CodePracticeLeetCodeTests
{
    internal class Problem0019_RemoveNthNodeFromEndOfList_Tests
    {
        private Problem0019_RemoveNthNodeFromEndOfList problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0019_RemoveNthNodeFromEndOfList();
        }

        [Test]
        public void TestCase1()
        {
            ListNode head  = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int n = 2;
            ListNode output = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));
            Assert.That(problem.Solve(head, n), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            ListNode head = new ListNode(1, null); ;
            int n = 1;
            ListNode output = null;
            Assert.That(problem.Solve(head, n), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            ListNode head = new ListNode(1, new ListNode(2));
            int n = 1;
            ListNode output = new ListNode(1);
            Assert.That(problem.Solve(head, n), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int n = 1;
            ListNode output = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            Assert.That(problem.Solve(head, n), Is.EqualTo(output));
        }
    }
}
