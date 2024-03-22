namespace CodePracticeLeetCodeTests
{
    internal class Problem0002_AddTwoNumber_Tests
    {
        private Problem0002_AddTwoNumbers problem { get; set; }

        [SetUp]
        public void Setup()
        {
            problem = new Problem0002_AddTwoNumbers();
        }

        [Test]
        public void TestCase1()
        {
            ListNode l1 = ListNode.ToList(new int[] { 2, 4, 3 });
            ListNode l2 = ListNode.ToList(new int[] { 5, 6, 4 });
            ListNode output = ListNode.ToList(new int[] { 7, 0, 8 });
            Assert.That(problem.AddTwoNumbers(l1, l2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            ListNode output = new ListNode(0);
            Assert.That(problem.AddTwoNumbers(l1, l2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            ListNode l1 = ListNode.ToList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = ListNode.ToList(new int[] { 9, 9, 9, 9 });
            ListNode output = ListNode.ToList(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });
            Assert.That(problem.AddTwoNumbers(l1, l2), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string l1string = "1";
            string l2string = "2";
            string l3string = "3";
            for (int i = 0; i < 100; i++)
            {
                l1string += "1";
                l2string += "2";
                l3string += "3";
            }
            ListNode l1 = ListNode.ToList(l1string);
            ListNode l2 = ListNode.ToList(l2string);
            ListNode output = ListNode.ToList(l3string);
            Assert.That(problem.AddTwoNumbers(l1, l2), Is.EqualTo(output));
        }

        [Test]
        public void ToString_TestCase1()
        {
            ListNode node = new ListNode(8, new ListNode(5, new ListNode(6, new ListNode(6))));
            Assert.That(node.ToString(), Is.EqualTo("8 5 6 6"));
        }

        [Test]
        public void FullTransformation_TestCase1()
        {
            Assert.That(ListNode.ToList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).ToString(), Is.EqualTo("1 2 3 4 5 6 7 8 9"));
        }
    }
}
