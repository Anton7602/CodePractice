namespace CodePracticeLeetCode
{
    /*
     * Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
     * The integer division should truncate toward zero, which means losing its fractional part. For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.
     * Return the quotient after dividing dividend by divisor.
     * Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231, 231 − 1]. 
     * For this problem, if the quotient is strictly greater than 231 - 1, then return 231 - 1, and if the quotient is strictly less than -231, then return -231.
     */
    public class Problem0029_DivideTwoIntegers : IProblem
    {
        private int _divident {  get; set; }
        private int _divisor { get; set; }
        private int _output {  get; set; }

        public int Divide(int dividend, int divisor)
        {
            if (dividend == 1<<31 && divisor==-1) return int.MaxValue;
            bool sign = ((dividend >= 0) == (divisor >= 0));

            long dividendAbs = Math.Abs((long)dividend);
            long divisorAbs = Math.Abs((long)divisor);
            int result = 0;
            while(dividendAbs>=divisorAbs)
            {
                int count = 0;
                while(dividendAbs - (divisorAbs<<1<<count)>=0)
                {
                    count++;
                }
                result += 1 << count;
                dividendAbs -= divisorAbs << count;
            }
            return sign ? result : -result;
        }

        public void ReadInput()
        {
            _divident = ProblemIO.ReadIntFromConsole("Enter divident (divident):");
            _divisor = ProblemIO.ReadIntFromConsole("Enter divisor (divisor):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = Divide(_divident, _divisor);
        }
    }
}
