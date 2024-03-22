namespace CodePracticeLeetCode
{
    /*
     * You are given the heads of two sorted linked lists list1 and list2.
     * Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
     * Return the head of the merged linked list.
     */
    public class Problem0021_MergeTwoSortedLists : IProblem
    {
        private ListNode? _list1 { get; set; }
        private ListNode? _list2 { get; set; }
        private ListNode? _output {  get; set; }

        public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            return PlaceNextNode(list1, list2);
        }

        private ListNode? PlaceNextNode(ListNode? node1, ListNode? node2)
        {
            if (node1 == null && node2 == null) return null;
            if (node1 == null) return node2;
            if (node2 == null) return node1;
            if (node1.val<=node2.val)
            {
                node1.next = PlaceNextNode(node1.next, node2);
                return node1;
            } else
            {
                node2.next = PlaceNextNode(node1, node2.next);
                return node2;
            }
        }

        public void ReadInput()
        {
            _list1 = ProblemIO.ReadListNodeFromConsole("Enter First Lists elements (list1):");
            _list2 = ProblemIO.ReadListNodeFromConsole("Enter Second Lists elements (list2):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = MergeTwoLists(_list1, _list2);
        }
    }
}
