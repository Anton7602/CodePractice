namespace CodePracticeLeetCode
{
    /*Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).
    * The algorithm for myAtoi(string s) is as follows:
    * 1. Read in and ignore any leading whitespace.
    * 2. Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
    * 3. Read in next the characters until the next non-digit character or the end of the input is reached. The rest of the string is ignored.
    * 4. Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
    * 5. If the integer is out of the 32-bit signed integer range [-2^31, 2^31 - 1], then clamp the integer so that it remains in the range. Specifically, integers less than -2^31 should be clamped to -2^31, and integers greater than 2^31 - 1 should be clamped to 2^31 - 1.
    * 6. Return the integer as the final result.
    * Note:
    * Only the space character ' ' is considered a whitespace character.
    * Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.
    */
    public class Problem8_StringToIntegerAtoi : IProblem
    {
        private string? _s { get; set; }
        private int _output { get; set; }

        public int Solve(string? s)
        {
            if (s == null) return 0;
            s = s.Trim();
            if (s.Length == 0) return 0;
            bool isNegative = (s[0] == '-');
            s = (isNegative || s[0] == '+') ? s.Remove(0, 1) : s;
            int parsedNumber = 0;
            int currentDigit;
            do
            {
                currentDigit = (s.Length>0 && int.TryParse(s[0].ToString(), out int digit)) ? digit : -1;
                if (currentDigit >= 0)
                {
                    if (!isNegative && int.MaxValue / 10.0 - currentDigit/10.0 < parsedNumber) return int.MaxValue;
                    if (isNegative && int.MinValue / 10.0 + currentDigit/10.0 > -1*parsedNumber) return int.MinValue;
                    parsedNumber = parsedNumber * 10 + currentDigit;
                    s = s.Remove(0, 1);
                }
            } while (currentDigit >= 0);
            return isNegative ? -1 * parsedNumber : parsedNumber;
        }

        public void ReadInput()
        {
            Console.WriteLine("Input string to parse to integer (s):");
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
