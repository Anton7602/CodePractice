namespace CodePracticeLeetCode
{
    public class Problem0025_ReverseNodesInKGroup : IProblem
    {
        /*
         * Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.
         * k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.
         * You may not alter the values in the list's nodes, only nodes themselves may be changed.
         */
        private ListNode _head {  get; set; }
        private int _k {  get; set; }
        private ListNode _output { get; set; }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            Stack<ListNode> nodeStack = new Stack<ListNode>();
            ListNode tempNode = head;
            for (int i=0; i<k; i++)
            {
                if (tempNode == null) return head;
                nodeStack.Push(tempNode);
                tempNode = tempNode.next;
            }
            tempNode = nodeStack.Peek();
            head.next = ReverseKGroup(tempNode.next, k);
            while(nodeStack.Count>1)
                nodeStack.Pop().next = nodeStack.Peek();
            return tempNode;
        }

        public void ReadInput()
        {
            _head = ProblemIO.ReadListNodeFromConsole("Input a linked list (head):");
            _k = ProblemIO.ReadIntFromConsole("Input length of reverse node (k):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = ReverseKGroup(_head, _k);
        }
    }
}
