namespace CodePracticeLeetCode
{
    /*
     * Write a function to find the longest common prefix string amongst an array of strings.
     * If there is no common prefix, return an empty string "".
     */
    public class Problem0014_LongestCommonPrefix : IProblem
    {
        private string[] _strs { get; set; } = new string[0];
        private string? _output { get; set; }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 1) return string.Empty;
            string commonSubstring = strs[0];
            for (int i=1; i<strs.Length; i++)
            {
                commonSubstring = FindCommonPrefix(commonSubstring, strs[i]);
                if (string.IsNullOrEmpty(commonSubstring)) return commonSubstring;
            }
            return commonSubstring;
        }

        public string FindCommonPrefix(string str1, string str2)
        {
            if (str2.Length < str1.Length)
            {
                string temp = str2;
                str2 = str1;
                str1 = temp;
            }
            for (int i=0; i<str1.Length; i++)
            {
                if (!str1[i].Equals(str2[i])) return str1.Substring(0, i);
            }
            return str1;
        }

        public void ReadInput()
        {
            _strs = ProblemIO.ReadStringArrayFromConsole("Enter array strings (strs):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = LongestCommonPrefix(_strs);
        }
    }
}
