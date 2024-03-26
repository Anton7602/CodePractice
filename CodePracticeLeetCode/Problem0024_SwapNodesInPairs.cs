namespace CodePracticeLeetCode
{
    /*
     * Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)
     */
    public class Problem0024_SwapNodesInPairs : IProblem
    {
        private ListNode _head { get; set; }
        private ListNode _output { get; set; }

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;
            ListNode temp = head.next;
            head.next = temp.next;
            temp.next = head;
            if (head.next!=null) head.next = SwapPairs(head.next);
            return temp;
        }

        public void ReadInput()
        {
            _head = ProblemIO.ReadListNodeFromConsole("Input a linked list (head):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = SwapPairs(_head);
        }
    }
}
