namespace CodePracticeLeetCode
{
    public class Problem0035_SearchInsertPosition : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private int _target { get; set; }
        private int _output { get; set; }

        public int SearchInsert(int[] nums, int target)
        {
            int leftIndexer = 0;
            int rightIndexer = nums.Length - 1;
            int midIndexer = (leftIndexer + rightIndexer) / 2;
            while (leftIndexer <= rightIndexer)
            {
                if (nums[midIndexer] < target)
                {
                    if (midIndexer == nums.Length - 1) return nums.Length;
                    leftIndexer = midIndexer + 1;
                }
                else
                {
                    if (midIndexer == 0) return 0;
                    rightIndexer = midIndexer - 1;
                }
                if (nums[midIndexer] == target || (midIndexer>0 && nums[midIndexer - 1] < target && nums[midIndexer] > target))
                {
                    return midIndexer;
                }
                midIndexer = (leftIndexer + rightIndexer) / 2;
            }
            return midIndexer;
        }
        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Enter array of integers (nums):");
            _target = ProblemIO.ReadIntFromConsole("Enter target element (target):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = SearchInsert(_nums, _target);
        }
    }
}
