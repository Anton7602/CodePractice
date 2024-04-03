namespace CodePracticeLeetCode
{
    /*
     * Given a string containing just the characters '(' and ')', return the length of the longest valid (well-formed) parentheses substring
     */
    public class Problem0032_LongestValidParentheses : IProblem
    {
        private string _s {  get; set; }
        private int _output {  get; set; }

        public int LongestValidParentheses(string s)
        {
            int maxLength = 0;
            int openBrackets = 0;
            int currentLength = 0;
            for (int i=0; i<s.Length; i++)
            {
                if (s[i] == '(')
                {
                    openBrackets++;
                    currentLength++;
                }
                else
                {
                    openBrackets--;
                    currentLength++;
                    if (openBrackets == 0 && currentLength>maxLength)
                    {
                        maxLength = currentLength;
                    }
                    if (openBrackets < 0)
                    {
                        openBrackets = 0;
                        currentLength = 0;
                    }
                }
            }
            openBrackets = 0;
            currentLength = 0;
            for (int i = s.Length-1; i >= 0; i--)
            {
                if (s[i] == ')')
                {
                    openBrackets++;
                    currentLength++;
                }
                else
                {
                    openBrackets--;
                    currentLength++;
                    if (openBrackets == 0 && currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    if (openBrackets < 0)
                    {
                        openBrackets = 0;
                        currentLength = 0;
                    }
                }
            }
            return maxLength;
        }

        public int LongestValidParenthesesLegacy(string s)
        {
            int maxLength = 0;
            List<Counter> counters = new List<Counter>();
            foreach (char symbol in s)
            {
                if (symbol=='(')
                {
                    foreach (var item in counters)
                    {
                        item.openBrakets++;
                        item.currentLength++;
                    }
                    counters.Add(new Counter() { openBrakets = 1, currentLength = 1 });
                } else
                {
                    foreach (var item in counters)
                    {
                        item.openBrakets--;
                        item.currentLength++;
                        if (item.openBrakets == 0 && item.currentLength > maxLength)
                            maxLength = item.currentLength;
                    }
                    counters = counters.Where(l => l.openBrakets >= 0).ToList();
                }
            }
            return maxLength;
        }

        public class Counter
        {
            public int openBrakets { get; set; }
            public int currentLength { get; set; }
        }

        public void ReadInput()
        {
            _s = ProblemIO.ReadStringFromConsole("Enter string of parentheses");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = LongestValidParentheses(_s);
        }
    }
}
