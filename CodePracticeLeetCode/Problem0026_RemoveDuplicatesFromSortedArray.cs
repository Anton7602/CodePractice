namespace CodePracticeLeetCode
{
    public class Problem0026_RemoveDuplicatesFromSortedArray : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private int _output { get; set; }

        public int RemoveDuplicates(int[] nums)
        {
            int indexSlow = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    if (indexSlow != i)
                    {
                        nums[indexSlow] = nums[i];
                    }
                    indexSlow++;
                }
            }
            return indexSlow;
        }

        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Input original array (nums):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = RemoveDuplicates(_nums);
        }
    }
}
