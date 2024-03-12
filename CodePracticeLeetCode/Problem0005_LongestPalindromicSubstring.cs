namespace CodePracticeLeetCode
{
    //Given a string s, return the longest palindromic substring in s.
    public class Problem0005_LongestPalindromicSubstring : IProblem
    {
        string? _s {  get; set; }
        string? _output {  get; set; }

        public string Solve(string? s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            string maxSubstring = s[0].ToString();
            for (int i=0; i<s.Length-1; i++)
            {
                if (i>=1 && s[i - 1].Equals(s[i+1]))
                {
                    int tempLength = evaluatePalindromLength(s, i, true);
                    if (tempLength>maxSubstring.Length)
                    {
                        maxSubstring = s.Substring(i - (tempLength - 1) / 2, tempLength);
                    }
                }
                if (s[i].Equals(s[i+1]))
                {
                    int tempLenght = evaluatePalindromLength(s, i, false);
                    if (tempLenght>maxSubstring.Length)
                    {
                        maxSubstring = s.Substring(i - ((tempLenght / 2) - 1), tempLenght);
                    }
                }
            }
            return maxSubstring;
        }

        public int evaluatePalindromLength(string origin, int indexStart, bool isOdd)
        {
            int lenght = 3;
            int indexLeft = indexStart - 2;
            int indexRight = indexStart + 2;
            if (!isOdd)
            {
                lenght = 2;
                indexLeft = indexStart - 1;
                indexRight = indexStart + 2;
            }
            do
            {
                if (indexLeft < 0 || indexRight >= origin.Length || !origin[indexLeft].Equals(origin[indexRight])) return lenght;
                lenght += 2;
                indexLeft--;
                indexRight++;
            } while (true);
        }

        public void ReadInput()
        {
            Console.WriteLine("Input string (s)");
            _s = Console.ReadLine();
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            Console.WriteLine(_output);
        }

        public void Solve()
        {
            _output = Solve(_s);
        }
    }
}
