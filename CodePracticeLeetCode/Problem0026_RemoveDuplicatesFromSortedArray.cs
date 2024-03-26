namespace CodePracticeLeetCode
{
    /*
     * Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
     * Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
     * Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
     * Return k.
     */
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
