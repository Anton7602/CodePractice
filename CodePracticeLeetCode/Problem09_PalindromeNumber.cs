namespace CodePracticeLeetCode
{
    //Given an integer x, return true if x is a palindrome, and false otherwise.
    public class Problem09_PalindromeNumber : IProblem
    {
        private int _x { get; set; }
        private bool _output { get; set; }

        public bool SolveAlternative(int x)
        {
            return (x < 0) ? false : isPalindrome(x, x.ToString().Length);
        }

        public bool isPalindrome(int number, int numberLength)
        {
            if (numberLength <= 1) return true;
            return (number % 10 != number / (int)Math.Pow(10, numberLength - 1)) ? false : isPalindrome((number / 10) % (int)Math.Pow(10, numberLength - 2), numberLength - 2);
        }

        public bool Solve(int x)
        {
            char[] reversedX = x.ToString().ToCharArray();
            Array.Reverse(reversedX);
            return (x < 0) ? false : (x.ToString().Equals(new string(reversedX)));
        }

        public void ReadInput()
        {
            Console.WriteLine("Input given integer (x):");
            _x = (Int32.TryParse(Console.ReadLine(), out int x)) ? x : 0;
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            Console.WriteLine(_output.ToString());
        }

        public void Solve()
        {
            _output = Solve(_x);
        }
    }
}
