namespace CodePracticeLeetCode
{
    /*
     * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
     * Symbol       Value
     * I             1
     * V             5
     * X             10
     * L             50
     * C             100
     * D             500
     * M             1000
     * For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
     * Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
     * The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
     * I can be placed before V (5) and X (10) to make 4 and 9. 
     * X can be placed before L (50) and C (100) to make 40 and 90. 
     * C can be placed before D (500) and M (1000) to make 400 and 900.
     * Given a roman numeral, convert it to an integer.
     */
    public class Problem0013_RomanToInteger : IProblem
    {
        private string? _s { get; set; }
        private int _output { get; set; }

        public int Solve(string? s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int arabicNumber = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        {
                            if (i + 1 < s.Length)
                            {
                                switch (s[i + 1])
                                {
                                    case 'V': { i++; arabicNumber += 4; break; }
                                    case 'X': { i++; arabicNumber += 9; break; }
                                    default: { arabicNumber++; break; }
                                }
                            }
                            else
                            {
                                arabicNumber++;
                            }
                            break;
                        }
                    case 'V': { arabicNumber += 5; break; }
                    case 'X':
                        {
                            if (i + 1 < s.Length)
                            {
                                switch (s[i + 1])
                                {
                                    case 'L': { i++; arabicNumber += 40; break; }
                                    case 'C': { i++; arabicNumber += 90; break; }
                                    default: { arabicNumber += 10; break; }
                                }
                            }
                            else
                            {
                                arabicNumber += 10;
                            }

                            break;
                        }
                    case 'L': { arabicNumber += 50; break; }
                    case 'C':
                        {
                            if (i+1<s.Length)
                            {
                                switch (s[i + 1])
                                {
                                    case 'D': { i++; arabicNumber += 400; break; }
                                    case 'M': { i++; arabicNumber += 900; break; }
                                    default: { arabicNumber += 100; break; }
                                }
                            }
                            else
                            {
                                arabicNumber += 100;
                            }
                            break;
                        }
                    case 'D': { arabicNumber += 500; break; }
                    case 'M': { arabicNumber += 1000; break; }
                    default: { throw new InvalidOperationException(); }
                }
            }
            return arabicNumber;
        }

        public void ReadInput()
        {
            Console.WriteLine("Enter roman number (s):");
            _s = Console.ReadLine();
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer");
            Console.WriteLine(_output);
        }

        public void Solve()
        {
            _output = Solve(_s);
        }
    }
}
