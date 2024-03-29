﻿namespace CodePracticeLeetCode
{
    /*
     * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
     * Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
     */
    public class Problem0007_ReverseInteger : IProblem
    {
        private int _x { get; set; }
        private int _output { get; set; }

        public int Reverse(int x)
        {
            int reverseNumber = 0;
            string number = x.ToString();
            bool isNegative = (number[0].Equals('-'));
            if (isNegative) number = number.Substring(1);
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (reverseNumber + Int32.Parse(number[i].ToString()) * Math.Pow(10, i) < Int32.MaxValue)
                {
                    reverseNumber += Int32.Parse(number[i].ToString()) * (int)Math.Pow(10, i);
                }
                else
                {
                    return 0;
                }
            }
            return (isNegative) ? reverseNumber * -1 : reverseNumber;
        }

        public void ReadInput()
        {
            _x = ProblemIO.ReadIntFromConsole("Input original integer (x): ");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = Reverse(_x);
        }
    }
}
