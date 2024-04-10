namespace CodePracticeLeetCode
{
    /*
     * Write a program to solve a Sudoku puzzle by filling the empty cells.
     * A sudoku solution must satisfy all of the following rules:
     * 
     * Each of the digits 1-9 must occur exactly once in each row.
     * Each of the digits 1-9 must occur exactly once in each column.
     * Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.
     * The '.' character indicates empty cells.
     */
    public class Problem0037_Sudoku_Solver : IProblem
    {
        private char[][] _board { get; set; } = new char[0][];

        public void SolveSudoku(char[][] board)
        {
            HashSet<char>[] rowHashMap = new HashSet<char>[9];
            HashSet<char>[] columnHashMap = new HashSet<char>[9];
            HashSet<char>[] subBoxHashMap = new HashSet<char>[9];
            sbyte i, j;
            for (i = 0; i < 9; i++)
            {
                if (rowHashMap[i] == null) rowHashMap[i] = new HashSet<char>();
                for (j = 0; j < 9; j++)
                {
                    sbyte subBoxIndex = (sbyte)((i / 3) * 3 + j / 3);
                    if (columnHashMap[j] == null) columnHashMap[j] = new HashSet<char>();
                    if (subBoxHashMap[subBoxIndex] == null) subBoxHashMap[subBoxIndex] = new HashSet<char>();
                    if (board[i][j] != '.')
                    {
                        if (!rowHashMap[i].Contains(board[i][j])) rowHashMap[i].Add(board[i][j]);
                        if (!columnHashMap[j].Contains(board[i][j])) columnHashMap[j].Add(board[i][j]);
                        if (!subBoxHashMap[subBoxIndex].Contains(board[i][j])) subBoxHashMap[subBoxIndex].Add(board[i][j]);
                    }
                }
            }



            HashSet<char>[,] possibleCellValues = new HashSet<char>[9, 9];
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        possibleCellValues[i, j] = CalculatePossibleValues(rowHashMap, columnHashMap, subBoxHashMap, i, j);
                    }
                }
            }

            PlaceNewValueInCell(board, possibleCellValues);
        }

        private HashSet<char> CalculatePossibleValues(HashSet<char>[] rowMap, HashSet<char>[] columnMap, HashSet<char>[] subBoxMap, sbyte rowIndex, sbyte columnIndex)
        {
            HashSet<char> cellMap = new HashSet<char>();
            for (byte digit = 1; digit < 10; digit++)
            {
                char symbol = digit.ToString()[0];
                byte subBoxIndex = (byte)((rowIndex / 3) * 3 + columnIndex / 3);
                if (!rowMap[rowIndex].Contains(symbol) && !columnMap[columnIndex].Contains(symbol) && !subBoxMap[subBoxIndex].Contains(symbol))
                    cellMap.Add(symbol);
            }
            return cellMap;
        }

        private HashSet<char>[,]? UpdatePossibleValues(char[][] board, HashSet<char>[,] possibleCellValues, sbyte updatedRow, sbyte updatedColumn)
        {
            HashSet<char>[,]? tempPossibleValues = CopyHashSet(possibleCellValues);
            byte subBoxIndex = (byte)((updatedRow / 3) * 3 + updatedColumn / 3);
            char newValue = board[updatedRow][updatedColumn];
            for (byte i = 0; i < 9; i++)
            {
                for (byte j = 0; j < 9; j++)
                {
                    if (tempPossibleValues[i, j] != null && (i == updatedRow || j == updatedColumn || subBoxIndex == (byte)((i / 3) * 3 + j / 3)))
                    {
                        tempPossibleValues[i, j].Remove(newValue);
                        if (tempPossibleValues[i, j].Count == 0 && board[i][j] == '.') 
                            return null;
                    }
                }
            }
            return tempPossibleValues;
        }

        private bool PlaceNewValueInCell(char[][] board, HashSet<char>[,] possibleValues)
        {
            var minIndexes = FindCellWithFewestPossibleValues(possibleValues);
            if (minIndexes[0] == -1 && minIndexes[1] == -1)
            {
                return true;
            }
            foreach (char value in possibleValues[minIndexes[0], minIndexes[1]])
            {
                board[minIndexes[0]][minIndexes[1]] = value;
                var tempPossibleValues = UpdatePossibleValues(board, possibleValues, minIndexes[0], minIndexes[1]);
                if (tempPossibleValues == null)
                {
                    board[minIndexes[0]][minIndexes[1]] = '.';
                    continue;
                }
                else
                {
                    tempPossibleValues[minIndexes[0], minIndexes[1]] = null;
                    if (PlaceNewValueInCell(board, tempPossibleValues) == true) return true;
                    else board[minIndexes[0]][minIndexes[1]] = '.';

                }
            }
            return false;
        }

        private sbyte[] FindCellWithFewestPossibleValues(HashSet<char>[,] possibleValues)
        {
            sbyte[] indexes = { 0, 0 };
            sbyte minPossibleValues = 10;
            for (sbyte i = 0; i < 9; i++)
            {
                for (sbyte j = 0; j < 9; j++)
                {
                    if (possibleValues[i, j] != null && possibleValues[i, j].Count() < minPossibleValues && possibleValues[i, j].Count() != 0)
                    {
                        minPossibleValues = (sbyte)possibleValues[i, j].Count();
                        indexes[0] = i; indexes[1] = j;
                        if (minPossibleValues == 1) return indexes;
                    }
                }
            }
            if (minPossibleValues == 10) return new sbyte[] { -1, -1 };
            return indexes;
        }

        private HashSet<char>[,] CopyHashSet(HashSet<char>[,] originalHashset)
        {
            HashSet<char>[,] newHashset = new HashSet<char>[9, 9];
            for (sbyte i = 0; i < 9; i++)
            {
                for (sbyte j = 0; j < 9; j++)
                {
                    if (originalHashset[i, j] != null)
                    {
                        newHashset[i, j] = new HashSet<char>(originalHashset[i, j]);
                    }
                }
            }
            return newHashset;
        }

        public void ReadInput()
        {
            //Console.WriteLine("Input sudoku board row by row");
            //_board = new char[9][];
            //for (int i = 0; i < 9; i++)
            //{
            //    _board[i] = ProblemIO.ReadCharArrayFromConsole("");
            //}
            _board =
                [['.','2','.','.','.','.','.','.','.']
                ,['.','.','.','6','.','.','.','.','3']
                ,['.','7','4','.','8','.','.','.','.']
                ,['.','.','.','.','.','3','.','.','2']
                ,['.','8','.','.','4','.','.','.','.']
                ,['6','.','.','5','.','.','.','.','.']
                ,['.','.','.','.','1','.','7','8','.']
                ,['5','.','.','.','.','9','.','.','.']
                ,['.','.','.','.','.','.','.','4','.']];
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue("Answer");
            for (byte i = 0; i < 9; i++)
            {
                for (byte j = 0; j < 9; j++)
                {
                    Console.Write(_board[i][j] + " ");
                }
                Console.WriteLine();
            }

            Problem0036_ValidSudoku test = new Problem0036_ValidSudoku();
            Console.WriteLine(test.IsValidSudoku(_board));
        }

        public void Solve()
        {
            SolveSudoku(_board);
        }
    }
}
