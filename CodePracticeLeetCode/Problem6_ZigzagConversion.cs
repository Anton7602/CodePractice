namespace CodePracticeLeetCode
{
    /*
     * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
     * P   A   H   N
     *  A P L S I I G
     *   Y   I   R
     * And then read line by line: "PAHNAPLSIIGYIR"
     * Write the code that will take a string and make this conversion given a number of rows:
     */
    public class Problem6_ZigzagConversion : IProblem
    {
        private string? _s { get; set; }
        private int _numRows { get; set; }
        private string? _output { get; set; }

        public string Solve(string? s, int numRows)
        {
            if (numRows == 1 || s.Length < 2) return s;
            string[] rows = new string[numRows];
            string output = string.Empty;
            bool isForward = true;
            int rowIndexer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (rows[rowIndexer] == null)
                {
                    rows[rowIndexer] = string.Empty;
                }
                rows[rowIndexer] += s[i];
                rowIndexer = (isForward) ? rowIndexer + 1 : rowIndexer - 1;
                if (isForward && rowIndexer == rows.Length - 1)
                {
                    isForward = false;
                }
                if (!isForward && rowIndexer == 0)
                {
                    isForward = true;
                }
            }
            foreach (var rowsString in rows)
            {
                output += rowsString;
            }
            return output;
        }

        public void ReadInput()
        {
            Console.WriteLine("Input original string (s):");
            _s = Console.ReadLine();
            Console.WriteLine("Input number of rows (numRows):");
            if (Int32.TryParse(Console.ReadLine(), out int numRows))
            {
                _numRows = numRows;
            }
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            Console.WriteLine(_output);
        }

        public void Solve()
        {
            _output = Solve(_s, _numRows);
        }
    }
}
