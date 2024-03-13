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

        public string Solve(string[] strs)
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
            Console.WriteLine("Enter number of strings (strs.Lenghth):");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                _strs = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter string {i+1} (strs[{i}]):");
                    _strs[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid lenght of strs array provided.");
                throw new InvalidOperationException();
            }
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            Console.WriteLine(_output);
        }

        public void Solve()
        {
            _output = Solve(_strs);
        }
    }
}
