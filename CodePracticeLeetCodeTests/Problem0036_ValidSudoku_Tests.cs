namespace CodePracticeLeetCodeTests
{
    internal class Problem0036_ValidSudoku_Tests
    {
        private Problem0036_ValidSudoku problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0036_ValidSudoku();
        }

        [Test]
        public void TestCase1()
        {
            char[][] board =
                [['5','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','.','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']];
            bool output = true;
            Assert.That(problem.IsValidSudoku(board), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            char[][] board =
                [['8','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','.','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']];
            bool output = false;
            Assert.That(problem.IsValidSudoku(board), Is.EqualTo(output));
        }
    }
}
