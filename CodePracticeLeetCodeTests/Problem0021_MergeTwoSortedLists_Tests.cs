namespace CodePracticeLeetCodeTests
{
    internal class Problem0021_MergeTwoSortedLists_Tests
    {
        private Problem0021_MergeTwoSortedLists problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0021_MergeTwoSortedLists();
        }

        [Test]
        public void TestCase1()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode output = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
            Assert.That(problem.Solve(list1, list2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            ListNode list1 = null;
            ListNode list2 = null;
            ListNode output = null;
            Assert.That(problem.Solve(list1, list2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            ListNode list1 = null;
            ListNode list2 = new ListNode(0);
            ListNode output = new ListNode(0);
            Assert.That(problem.Solve(list1, list2), Is.EqualTo(output));
        }
    }
}
