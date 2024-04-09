using System;
using System.Text.RegularExpressions;

namespace CodePracticeLeetCode
{
    public interface IProblem
    {
        void ReadInput();
        void Solve();
        void ShowAnswer();
    }

    public static class ProblemIO
    {
        public static string ReadStringFromConsole(string promtMessage = "Enter string value:")
        {
            Console.WriteLine(promtMessage);
            return Console.ReadLine();
        }

        public static int ReadIntFromConsole(string promtMessage = "Enter integer value:")
        {
            Console.WriteLine(promtMessage);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;
            Console.WriteLine("Provided invalid input data");
            throw new ArgumentException();
        }

        public static string[] ReadStringArrayFromConsole(string promtMessage = "Enter array of strings", char separator = ' ')
        {
            Console.WriteLine(promtMessage);
            string line = Console.ReadLine();
            return line.Split(separator);
        }

        public static char[] ReadCharArrayFromConsole(string promtMessage = "Enter array of chars", char? separator = ' ')
        {
            Console.WriteLine(promtMessage);
            string line = Console.ReadLine();
            if (separator!=null)
                line = line.Replace(separator.GetValueOrDefault().ToString(), "");
            return line.ToCharArray();
        }

        public static int[] ReadIntArrayFromConsole(string promtMessage = "Enter array of integers", char? separator = null)
        {
            Console.WriteLine(promtMessage);
            string? line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
            {
                Console.WriteLine("Provided empty input data");
                throw new ArgumentException();
            }
            var splitLine = (separator == null) ? line.Split(' ') : line.Split(separator.GetValueOrDefault());
            int[] nums = new int[splitLine.Length];
            for (int i = 0; i < splitLine.Length; i++)
            {
                if (int.TryParse(splitLine[i], out int value))
                {
                    nums[i] = value;
                } else
                {
                    Console.WriteLine("Provided invalid input data");
                    throw new ArgumentException();
                }
            }
            return nums;
        }

        public static ListNode ReadListNodeFromConsole(string promtMessage = "Enter ListNode value as array:", char? separator = null)
        {
            return ListNode.ToList(ReadIntArrayFromConsole(promtMessage, separator));
        }

        public static void WriteValue(object output, string promtMessage = "Answer:")
        {
            Console.WriteLine(promtMessage);
            Console.WriteLine(output.ToString());
        }

        public static void WriteValue(int[] output, string promtMessage = "Answer:")
        {
            Console.WriteLine(promtMessage);
            foreach (int number in output)
            {
                Console.Write(number + " ");
            }
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

        public static ListNode? ToList(string number, char? separator = null)
        {
            if (string.IsNullOrEmpty(number)) return new ListNode();
            string[] digits = (separator == null) ? number.ToCharArray().Select(l => l.ToString()).ToArray() : number.Split(number, separator.GetValueOrDefault());
            ListNode previousNode = null;
            ListNode startNode = null;
            for (int i = 0; i < digits.Length; i++)
            {
                if (int.TryParse(digits[i], out int digit))
                {
                    ListNode currentNode = new ListNode(digit);
                    if (previousNode == null)
                    {
                        startNode = currentNode;
                        previousNode = currentNode;
                    }
                    else
                    {
                        previousNode.next = currentNode;
                        previousNode = currentNode;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

            }
            return startNode;
        }

        public static ListNode ToList(int[] numbers)
        {
            if (numbers.Length < 1) return new ListNode();
            ListNode firstNode = new ListNode(numbers[0]);
            ListNode currentNode = firstNode;
            for (int i = 1; i < numbers.Length; i++)
            {
                currentNode.next = new ListNode(numbers[i]);
                currentNode = currentNode.next;
            }
            return firstNode;
        }

        public override string ToString()
        {
            string output = string.Empty;
            ListNode currentListNode = this;
            while (currentListNode != null)
            {
                output += currentListNode.val.ToString() + " ";
                currentListNode = currentListNode.next;
            }
            return output.Trim();
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
            if (node1.val != node2.val) return false;
            return CompareListNodes(node1.next, node2.next);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + val.GetHashCode();
                hash = hash * 23 + (next != null ? next.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
