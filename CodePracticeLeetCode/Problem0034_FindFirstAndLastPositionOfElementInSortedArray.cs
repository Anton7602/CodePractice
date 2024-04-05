namespace CodePracticeLeetCode
{
    /*
     * Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
     * If target is not found in the array, return [-1, -1].
     * You must write an algorithm with O(log n) runtime complexity.
     */
    public class Problem0034_FindFirstAndLastPositionOfElementInSortedArray : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private int _target { get; set; }
        private int[] _output { get; set; } = new int[0];

        public int[] SearchRange(int[] nums, int target)
        {
            int leftIndexer = 0;
            int rightIndexer = nums.Length - 1;
            int midIndexer = (leftIndexer + rightIndexer) / 2;
            while (leftIndexer <= rightIndexer)
            {
                if (nums[midIndexer] == target)
                {
                    return new int[] { FindLeftBoundary(nums, target, leftIndexer, midIndexer), FindRightBoundary(nums, target, midIndexer, rightIndexer) };
                }
                else if (nums[midIndexer] < target)
                {
                    leftIndexer = midIndexer + 1;
                }
                else
                {
                    rightIndexer = midIndexer - 1;
                }
                midIndexer = (leftIndexer + rightIndexer) / 2;
            }
            return new int[] { -1, -1 };
        }

        public int FindLeftBoundary(int[] nums, int target, int leftIndexer, int rightIndexer)
        {
            int midIndexer = leftIndexer;
            while (leftIndexer<=rightIndexer)
            {
                midIndexer = (leftIndexer + rightIndexer) / 2;
                if (nums[midIndexer] == target)
                {
                    if (midIndexer==0 || nums[midIndexer] > nums[midIndexer-1])
                    {
                        return midIndexer;
                    }
                    rightIndexer = midIndexer - 1;
                } else
                {
                    leftIndexer = midIndexer + 1;
                }
            }
            return midIndexer;
        }

        public int FindRightBoundary(int[] nums, int target, int leftIndexer, int rightIndexer)
        {
            int midIndexer = rightIndexer;
            while (leftIndexer <= rightIndexer)
            {
                midIndexer = (leftIndexer + rightIndexer) / 2;
                if (nums[midIndexer] == target)
                {
                    if (midIndexer == nums.Length-1 || nums[midIndexer] < nums[midIndexer + 1])
                    {
                        return midIndexer;
                    }
                    leftIndexer = midIndexer + 1;
                }
                else
                {
                    rightIndexer = midIndexer - 1;
                }
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
            _output = SearchRange(_nums, _target);
        }
    }
}
