﻿namespace CodePracticeLeetCode
{
    /*
     * You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
     * Merge all the linked-lists into one sorted linked-list and return it.
     */
    public class Problem0023_MergeKSortedLists : IProblem
    {
        private ListNode[] _lists { get; set; } = new ListNode[0];
        private ListNode _output { get; set; }

        public ListNode? MergeKLists(ListNode[] lists)
        {
            if (lists == null) return null;
            List<ListNode> nodes = lists.Where(l => l != null).OrderBy(l => l.val).ToList();
            if (nodes == null || nodes.Count() < 1) return null;
            ListNode firstNode = nodes[0];
            ListNode lastNode = firstNode;
            nodes.RemoveAt(0);
            ListNode newNode = lastNode.next;
            while (nodes.Count > 0)
            {
                if (newNode != null)
                {
                    if (newNode.val <= nodes[0].val)
                    {
                        lastNode.next = newNode;
                        lastNode = lastNode.next;
                        newNode = newNode.next;
                        continue;
                    }
                    else if (newNode.val >= nodes.Last().val)
                    {
                        nodes.Add(newNode);
                    }
                    else
                    {
                        int leftIndex = 0;
                        int rightIndex = nodes.Count - 1;
                        while (leftIndex <= rightIndex)
                        {
                            int midIndex = (leftIndex + rightIndex) / 2;
                            if (newNode.val <= nodes[midIndex].val && newNode.val >= nodes[midIndex - 1].val)
                            {
                                nodes.Insert(midIndex, newNode);
                                break;
                            }
                            else if (newNode.val < nodes[midIndex].val)
                            {
                                rightIndex = (rightIndex == midIndex) ? midIndex - 1 : midIndex;
                            }
                            else
                            {
                                leftIndex = (leftIndex == midIndex) ? midIndex + 1 : midIndex;
                            }
                        }
                    }
                }
                lastNode.next = nodes[0];
                lastNode = lastNode.next;
                nodes.RemoveAt(0);
                newNode = lastNode.next;
            }
            return firstNode;
        }

        public void ReadInput()
        {
            int k = ProblemIO.ReadIntFromConsole("Input number of linked-lists (k):");
            _lists = new ListNode[k];
            for (int i = 0; i < k; i++)
            {
                _lists[i] = ProblemIO.ReadListNodeFromConsole($"Enter {i + 1} list of elements (list{i}):");
            }
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = MergeKLists(_lists);
        }
    }
}
