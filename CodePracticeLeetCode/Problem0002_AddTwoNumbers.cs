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


        public ListNode Solve(ListNode l1, ListNode l2)
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
            Console.WriteLine("Enter number for a first list (l1)");
            _l1 = ListNode.ToList(Console.ReadLine());
            Console.WriteLine("Enter number for a second list (l2)");
            _l2 = ListNode.ToList(Console.ReadLine());

        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            Console.WriteLine(_output.ToString());
        }

        public void Solve()
        {
            _output = Solve(_l1, _l2);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode ToList(string number)
        {
            if (string.IsNullOrEmpty(number)) return new ListNode();
            char[] digits = number.ToCharArray();
            Array.Reverse(digits);
            ListNode firstNode = new ListNode(digits[0] - '0');
            ListNode previousNode = firstNode;
            for (int i = 1; i < digits.Length; i++)
            {
                ListNode currentNode = new ListNode(digits[i] - '0');
                previousNode.next = currentNode;
                previousNode = currentNode;
            }
            return firstNode;
        }

        public static ListNode ToList(int number)
        {
            return ToList(number.ToString());
        }

        public static ListNode ToList(int[] numbers)
        {
            return new ListNode();
        }

        public override string ToString()
        {
            string number = string.Empty;
            ListNode currentListNode = this;
            while (currentListNode != null)
            {
                number += currentListNode.val.ToString();
                currentListNode = currentListNode.next;
            }
            return ReverseString(number);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is ListNode)) return false;
            return CompareListNodes(this, obj as ListNode);
        }

        private bool CompareListNodes(ListNode? node1, ListNode? node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null || node2 == null) return false;
            if (node1.val!=node2.val) return false;
            return CompareListNodes(node1.next, node2.next);
        }

        private static string ReverseString(string originalString)
        {
            char[] stringArray = originalString.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }
    }
}
