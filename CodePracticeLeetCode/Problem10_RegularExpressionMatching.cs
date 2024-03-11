namespace CodePracticeLeetCode
{
    /*
     * Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
     * '.' Matches any single character.​​​​
     * '*' Matches zero or more of the preceding element.
     * The matching should cover the entire input string (not partial).
     */
    public class Problem10_RegularExpressionMatching : IProblem
    {
        private string? _s { get; set; }
        private string? _p { get; set; }
        private bool _output { get; set; }

        public bool Solve(string? s, string? p)
        {
            bool[,] matchingMatrix = new bool[s.Length + 1, p.Length + 1];
            matchingMatrix[0, 0] = true;
            for (int i=1; i < p.Length+1;i++)
            {
                matchingMatrix[0, i] = (p[i - 1].Equals('*')) ? matchingMatrix[0, i - 2] : false;
            }

            for (int i=1; i<s.Length+1; i++)
            {
                for (int j=1; j<p.Length+1; j++)
                {
                    if (p[j-1].Equals('.') || p[j - 1].Equals(s[i-1]))
                    {
                        matchingMatrix[i, j] = matchingMatrix[i-1, j-1];
                    } else if (p[j-1].Equals('*'))
                    {
                        matchingMatrix[i, j] = matchingMatrix[i, j - 2];
                        if (p[j-2].Equals('.') || p[j - 2].Equals(s[i-1]))
                        {
                            matchingMatrix[i, j] = matchingMatrix[i, j] || matchingMatrix[i - 1, j];
                        }
                    } else
                    {
                        matchingMatrix[i, j] = false;
                    }
                }
            }
            return matchingMatrix[s.Length, p.Length];
        }


        public void ReadInput()
        {
            Console.WriteLine("Enter input string (s):");
            _s = Console.ReadLine();
            Console.WriteLine("Enter string pattern (p):");
            _p = Console.ReadLine();
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            Console.WriteLine(_output);
        }

        public void Solve()
        {
            _output = Solve(_s, _p);
        }
    }
}
