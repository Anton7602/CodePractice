namespace CodePracticeLeetCode
{
    /*
     * Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
     */
    public class Problem0028_FindTheIndexOfTheFirstOccurrenceInAString : IProblem
    {
        private string _haystack { get; set; }
        private string _needle { get; set; }
        private int _output { get; set; }

        public int StrStr(string haystack, string needle)
        {
            List<int> needleIndexes = new List<int>();
            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needleIndexes.Count; j++)
                {
                    if (haystack[i] == needle[needleIndexes[j]])
                    {
                        needleIndexes[j]++;
                        if (needleIndexes[j] == needle.Length)
                        {
                            return i - (needle.Length - 1);
                        }
                    }
                    else
                    {
                        needleIndexes.RemoveAt(j);
                        j--;
                    }
                }
                if (haystack[i] == needle[0])
                {
                    needleIndexes.Add(1);
                    if (needle.Length == 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public void ReadInput()
        {
            _haystack = ProblemIO.ReadStringFromConsole("Enter haystack string (haystack):");
            _needle = ProblemIO.ReadStringFromConsole("Enter needle string (needle):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = StrStr(_haystack, _needle);
        }
    }
}
