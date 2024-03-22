namespace CodePracticeLeetCode
{
    /* Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
     * Symbol       Value
     * I             1
     * V             5
     * X             10
     * L             50
     * C             100
     * D             500
     * M             1000
     * For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
     * Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
     * The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
     * 
     * I can be placed before V (5) and X (10) to make 4 and 9. 
     * X can be placed before L (50) and C (100) to make 40 and 90. 
     * C can be placed before D (500) and M (1000) to make 400 and 900.
     * Given an integer, convert it to a roman numeral.
    */
    public class Problem0012_IntegerToRoman : IProblem
    {
        private int _num {  get; set; }
        private string? _output {  get; set; }

        public string IntToRoman(int num)
        {
            string romanNumber = string.Empty;
            Dictionary<int, string> digitToRoman = new Dictionary<int, string>();
            digitToRoman.Add(0, "");
            digitToRoman.Add(1, "I");
            digitToRoman.Add(2, "II");
            digitToRoman.Add(3, "III");
            digitToRoman.Add(4, "IV");
            digitToRoman.Add(5, "V");
            digitToRoman.Add(6, "VI");
            digitToRoman.Add(7, "VII");
            digitToRoman.Add(8, "VIII");
            digitToRoman.Add(9, "IX");
            digitToRoman.Add(10, "X");
            digitToRoman.Add(20, "XX");
            digitToRoman.Add(30, "XXX");
            digitToRoman.Add(40, "XL");
            digitToRoman.Add(50, "L");
            digitToRoman.Add(60, "LX");
            digitToRoman.Add(70, "LXX");
            digitToRoman.Add(80, "LXXX");
            digitToRoman.Add(90, "XC");
            digitToRoman.Add(100, "C");
            digitToRoman.Add(200, "CC");
            digitToRoman.Add(300, "CCC");
            digitToRoman.Add(400, "CD");
            digitToRoman.Add(500, "D");
            digitToRoman.Add(600, "DC");
            digitToRoman.Add(700, "DCC");
            digitToRoman.Add(800, "DCCC");
            digitToRoman.Add(900, "CM");
            digitToRoman.Add(1000, "M");
            digitToRoman.Add(2000, "MM");
            digitToRoman.Add(3000, "MMM");
            string number = num.ToString();
            for (int i=0; i<number.Length; i++)
            {
                romanNumber += digitToRoman[int.Parse(number[i].ToString()) * (int)Math.Pow(10, number.Length-1-i)];
            }
            return romanNumber;
        }

        public void ReadInput()
        {
            _num = ProblemIO.ReadIntFromConsole("Enter input number (num)");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = IntToRoman(_num);
        }
    }
}
