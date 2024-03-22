namespace CodePracticeLeetCode
{
    /*
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     * An input string is valid if:
     * - Open brackets must be closed by the same type of brackets.
     * - Open brackets must be closed in the correct order.
     * - Every close bracket has a corresponding open bracket of the same type.
     */
    public class Problem0020_ValidParentheses : IProblem
    {
        private string? _s { get; set; }
        private bool _output { get; set; }
        public bool IsValid(string? s)
        {
            Stack<char> brakets = new Stack<char>();
            foreach (char symbol in s)
            {
                switch (symbol)
                {
                    case '(': { brakets.Push(symbol); break; }
                    case '[': { brakets.Push(symbol); break; }
                    case '{': { brakets.Push(symbol); break; }
                    case ')':
                        {
                            if (brakets.TryPeek(out char lastBracket) && lastBracket.Equals('(')) brakets.Pop();
                            else return false;
                            break;
                        }
                    case '}':
                        {
                            if (brakets.TryPeek(out char lastBracket) && lastBracket.Equals('{')) brakets.Pop();
                            else return false;
                            break;
                        }
                    case ']':
                        {
                            if (brakets.TryPeek(out char lastBracket) && lastBracket.Equals('[')) brakets.Pop();
                            else return false;
                            break;
                        }
                }
            }
            return !brakets.TryPeek(out char anyBracket);
        }


        public void ReadInput()
        {
            _s = ProblemIO.ReadStringFromConsole("Enter a string (s):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = IsValid(_s);
        }
    }
}
