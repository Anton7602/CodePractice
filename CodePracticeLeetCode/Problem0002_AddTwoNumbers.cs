namespace CodePracticeLeetCode
{
    /*
     * You are given two non-empty linked lists representing two non-negative integers. 
     * The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
     * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
     */
    public class Problem0002_AddTwoNumbers : IProblem
    {
        ListNode _l1 { get; set; }
        ListNode _l2 { get; set; }
        ListNode _output { get; set; }


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return createNewListNode(l1, l2, false);
        }

        private ListNode createNewListNode(ListNode? firstNode, ListNode? secondNode, bool overflow)
        {
            if (firstNode == null && secondNode == null)
            {
                if (overflow)
                {
                    return new ListNode(1);
                }
                return null;
            }
            int value = Convert.ToInt32(overflow);
            ListNode? nextFirst = null;
            ListNode? nextSecond = null;
            if (firstNode != null)
            {
                value += firstNode.val;
                nextFirst = firstNode.next;
            }
            if (secondNode != null)
            {
                value += secondNode.val;
                nextSecond = secondNode.next;
            }
            if (value >= 10)
            {
                value = value % 10;
                overflow = true;
            }
            else
            {
                overflow = false;
            }
            return new ListNode(value, createNewListNode(nextFirst, nextSecond, overflow));
        }

        public void ReadInput()
        {
            _l1 = ProblemIO.ReadListNodeFromConsole("Enter first list (l1)");
            _l2 = ProblemIO.ReadListNodeFromConsole("Enter second list (l2)");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = AddTwoNumbers(_l1, _l2);
        }
    }
}
