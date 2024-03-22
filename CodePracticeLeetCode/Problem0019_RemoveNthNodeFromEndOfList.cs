namespace CodePracticeLeetCode
{
    // Given the head of a linked list, remove the nth node from the end of the list and return its head.
    public class Problem0019_RemoveNthNodeFromEndOfList : IProblem
    {
        private ListNode _head { get; set; }
        private int _n { get; set; }
        private ListNode _output { get; set; }

        public ListNode? RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode currentListNode = head;
            Dictionary<int, ListNode> indexMap = new Dictionary<int, ListNode>();
            int index = 0;
            while (currentListNode != null)
            {
                indexMap.Add(index, currentListNode);
                currentListNode = currentListNode.next;
                index++;
            }
            if (index - n < 0 || index - n > index) return null;
            if (index - n == 0)
            {
                indexMap[0] = (indexMap.ContainsKey(1)) ? indexMap[1] : null;
            }
            else if (n == 1)
            {
                indexMap[index - 2].next = null;
            }
            else
            {
                indexMap[index - n - 1].next = indexMap[index - n + 1];
            }
            return indexMap.TryGetValue(0, out ListNode? value) ? value : null;
        }
        public void ReadInput()
        {
            _head = ProblemIO.ReadListNodeFromConsole("Enter list of Integers (head):");
            _n = ProblemIO.ReadIntFromConsole("Enter node number (n):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = RemoveNthFromEnd(_head, _n);
        }
    }
}
