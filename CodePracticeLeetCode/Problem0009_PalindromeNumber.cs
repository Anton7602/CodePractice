namespace CodePracticeLeetCode
{
    //Given an integer x, return true if x is a palindrome, and false otherwise.
    public class Problem0009_PalindromeNumber : IProblem
    {
        private int _x { get; set; }
        private bool _output { get; set; }

        public bool IsPalindrome(int x)
        {
            char[] reversedX = x.ToString().ToCharArray();
            Array.Reverse(reversedX);
            return (x < 0) ? false : (x.ToString().Equals(new string(reversedX)));
        }
        public bool SolveAlternative(int x)
        {
            return (x < 0) ? false : IsPalindromeNumber(x, x.ToString().Length);
        }

        public bool IsPalindromeNumber(int number, int numberLength)
        {
            if (numberLength <= 1) return true;
            return (number % 10 != number / (int)Math.Pow(10, numberLength - 1)) ? false : IsPalindromeNumber((number / 10) % (int)Math.Pow(10, numberLength - 2), numberLength - 2);
        }

        public void ReadInput()
        {
            _x = ProblemIO.ReadIntFromConsole("Input given integer (x):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = IsPalindrome(_x);
        }
    }
}
