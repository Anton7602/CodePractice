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

        public ListNode Solve(ListNode? list1, ListNode? list2)
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
            try
            {
                Console.WriteLine("Enter First Lists elements (list1):");
                string? line1 = Console.ReadLine();
                if (!string.IsNullOrEmpty(line1))
                {
                    var splitLine1 = line1.Split(' ');
                    ListNode currentNode = new ListNode(Convert.ToInt32(splitLine1[0]));
                    _list1 = currentNode;
                    for (int i = 1; i < splitLine1.Length; i++)
                    {
                        ListNode tempNode = new ListNode(Convert.ToInt32(splitLine1[i]));
                        currentNode.next = tempNode;
                        currentNode = tempNode;
                    }
                }
                Console.WriteLine("Enter Second Lists elements (list2):");
                string? line2 = Console.ReadLine();
                if (!string.IsNullOrEmpty(line1))
                {
                    var splitLine1 = line1.Split(' ');
                    ListNode currentNode = new ListNode(Convert.ToInt32(splitLine1[0]));
                    _list2 = currentNode;
                    for (int i = 1; i < splitLine1.Length; i++)
                    {
                        ListNode tempNode = new ListNode(Convert.ToInt32(splitLine1[i]));
                        currentNode.next = tempNode;
                        currentNode = tempNode;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Provided invalid input data");
                Console.WriteLine(ex.Message);
            }
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            Console.WriteLine(_output.ToString());
        }

        public void Solve()
        {
            _output = Solve(_list1, _list2);
        }
    }
}
