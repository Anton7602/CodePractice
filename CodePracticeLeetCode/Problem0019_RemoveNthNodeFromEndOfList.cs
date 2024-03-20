namespace CodePracticeLeetCode
{
    // Given the head of a linked list, remove the nth node from the end of the list and return its head.
    public class Problem0019_RemoveNthNodeFromEndOfList : IProblem
    {
        private ListNode _head { get; set; }
        private int _n { get; set; }
        private ListNode _output { get; set; }

        public ListNode? Solve(ListNode head, int n)
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
            try
            {
                Console.WriteLine("Enter Array of Integers (nums):");
                string? line1 = Console.ReadLine();
                if (!string.IsNullOrEmpty(line1))
                {
                    var splitLine1 = line1.Split(' ');
                    ListNode currentNode = new ListNode(Convert.ToInt32(splitLine1[0]));
                    _head = currentNode;
                    for (int i = 1; i < splitLine1.Length; i++)
                    {
                        ListNode tempNode = new ListNode(Convert.ToInt32(splitLine1[i]));
                        currentNode.next = tempNode;
                        currentNode = tempNode;
                    }
                }
                Console.WriteLine("Enter target number (target):");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    _n = n;
                }
                else
                {
                    throw new ArgumentException();
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
            _output = Solve(_head, _n);
        }
    }
}
