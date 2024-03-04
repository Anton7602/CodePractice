namespace CodePracticeLeetCodeTests
{
    internal class Problem2_AddTwoNumber_Tests
    {
        private Problem2_AddTwoNumbers problem { get; set; }

        [SetUp]
        public void Setup()
        {
            problem = new Problem2_AddTwoNumbers();
        }

        [Test]
        public void TestCase1()
        {
            ListNode l1 = ListNode.ToList("342");
            ListNode l2 = ListNode.ToList("465");
            string output = "807";
            Assert.That(problem.Solve(l1, l2).ToString(), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            ListNode l1 = ListNode.ToList("0");
            ListNode l2 = ListNode.ToList("0");
            string output = "0";
            Assert.That(problem.Solve(l1, l2).ToString(), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            ListNode l1 = ListNode.ToList("9999999");
            ListNode l2 = ListNode.ToList("9999");
            string output = "10009998";
            Assert.That(problem.Solve(l1, l2).ToString(), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string l1string = "1";
            string l2string = "2";
            string l3string = "3";
            for (int i = 0; i<100; i++)
            {
                l1string += "1";
                l2string += "2";
                l3string += "3";
            }
            ListNode l1 = ListNode.ToList(l1string);
            ListNode l2 = ListNode.ToList(l2string);
            string output = l3string;
            Assert.That(problem.Solve(l1, l2).ToString(), Is.EqualTo(output));
        }

        [Test]
        public void ToString_TestCase1()
        {
            ListNode node = new ListNode(8, new ListNode(5, new ListNode(6, new ListNode(6))));
            Assert.That(node.ToString(), Is.EqualTo("6658"));
        }

        [Test]
        public void FullTransformation_TestCase1()
        {
            Assert.That(ListNode.ToList(123456789).ToString(), Is.EqualTo("123456789"));
        }
    }
}
