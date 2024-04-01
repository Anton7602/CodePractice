namespace CodePracticeLeetCode
{
    /*
     * You are given a string s and an array of strings words. All the strings of words are of the same length.
     * A concatenated substring in s is a substring that contains all the strings of any permutation of words concatenated.
     * For example, if words = ["ab","cd","ef"], then "abcdef", "abefcd", "cdabef", "cdefab", "efabcd", and "efcdab" are all concatenated strings. "acdbef" is not a concatenated substring because it is not the concatenation of any permutation of words.
     * Return the starting indices of all the concatenated substrings in s. You can return the answer in any order.
     */
    public class Problem0030_SubstringWithConcatenationOfAllWords : IProblem
    {
        private string _s { get; set; }
        private string[] _words { get; set; }
        private List<int> _output { get; set; }

        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> indexes = new List<int>();
            int substringLength = words.Length * words[0].Length;
            for (int i = 0; i < s.Length - (substringLength - 1); i++)
            {
                if (IsValidPermutation(s.Substring(i, substringLength), words, words[0].Length))
                {
                    indexes.Add(i);
                }
            }
            return indexes;
        }

        public bool IsValidPermutation(string line, string[] words, int wordLength)
        {
            Dictionary<string, int> dictionary = words.GroupBy(s => s).ToDictionary(g => g.Key, g => g.Count());
            int index = 0;
            while (index<line.Length)
            {
                string subLine = line.Substring(index, wordLength);
                if (!dictionary.ContainsKey(subLine))
                {
                    return false;
                } else
                {
                    if (dictionary[subLine]>1)
                    {
                        dictionary[subLine]--;
                    } else
                    {
                        dictionary.Remove(subLine);
                    }
                }
                index += wordLength;
            }
            return dictionary.Count()==0;
        }

        public void ReadInput()
        {
            _s = ProblemIO.ReadStringFromConsole("Enter the main string (s):");
            _words = ProblemIO.ReadStringArrayFromConsole("Input substrings to look for (words):");
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer");
            foreach (int index in _output)
            {
                Console.Write(index + " ");
            }
        }

        public void Solve()
        {
            _output = FindSubstring(_s, _words).ToList();
        }
    }
}
