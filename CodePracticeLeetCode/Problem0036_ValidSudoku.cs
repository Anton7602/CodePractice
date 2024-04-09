namespace CodePracticeLeetCode
{
    /*
     * Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
     * Each row must contain the digits 1-9 without repetition.
     * Each column must contain the digits 1-9 without repetition.
     * Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
     * 
     * Note:
     * A Sudoku board (partially filled) could be valid but is not necessarily solvable.
     * Only the filled cells need to be validated according to the mentioned rules.
     */
    public class Problem0036_ValidSudoku : IProblem
    {
        private char[][] _board { get; set; } = new char[0][];
        private bool _output { get; set; }

        public bool IsValidSudoku(char[][] board)
        {
            HashSet<char>[] rowHashMap = new HashSet<char>[9];
            HashSet<char>[] columnHashMap = new HashSet<char>[9];
            HashSet<char>[] subBoxHashMap = new HashSet<char>[9];
            for (byte i = 0; i < 9; i++)
            {
                for (byte j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (rowHashMap[i] == null) rowHashMap[i] = new HashSet<char>();
                        if (rowHashMap[i].Contains(board[i][j])) return false;
                        else rowHashMap[i].Add(board[i][j]);

                        if (columnHashMap[j] == null) columnHashMap[j] = new HashSet<char>();
                        if (columnHashMap[j].Contains(board[i][j])) return false;
                        else columnHashMap[j].Add(board[i][j]);

                        byte subBoxIndex = (byte)((i / 3) * 3 + j / 3);
                        if (subBoxHashMap[subBoxIndex]==null) subBoxHashMap[subBoxIndex] = new HashSet<char>();
                        if (subBoxHashMap[subBoxIndex].Contains(board[i][j])) return false;
                        else subBoxHashMap[subBoxIndex].Add(board[i][j]);
                    }
                }
            }
            return true;
        }

        public void ReadInput()
        {
            Console.WriteLine("Input sudoku board row by row");
            _board = new char[9][];
            for (int i = 0; i < 9; i++)
            {
                _board[i] = ProblemIO.ReadCharArrayFromConsole("");
            }
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = IsValidSudoku(_board);
        }
    }
}
