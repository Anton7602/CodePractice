namespace CodePracticeLeetCode
{
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
