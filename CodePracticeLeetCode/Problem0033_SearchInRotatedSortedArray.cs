namespace CodePracticeLeetCode
{
    /*
     * There is an integer array nums sorted in ascending order (with distinct values).
     * Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed).
     * For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
     * Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
     * You must write an algorithm with O(log n) runtime complexity.
     */
    public class Problem0033_SearchInRotatedSortedArray : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private int _target { get; set; }
        private int _output { get; set; }

        public int Search(int[] nums, int target)
        {
            if (nums.Length==1) return (nums[0]==target) ? 0 : -1;
            int rotationIndex = 1;
            int leftIndexer = 0;
            int rightIndexer = nums.Length-1;
            int midIndexer = (rightIndexer + leftIndexer) / 2;
            while (nums[midIndexer] < nums[midIndexer+1])
            {
                if (nums[leftIndexer] < nums[midIndexer])
                {
                    leftIndexer = (midIndexer==leftIndexer) ?  midIndexer+1 : midIndexer;
                } else
                {
                    rightIndexer = (midIndexer==rightIndexer) ? midIndexer-1 :  midIndexer;
                }
                if (leftIndexer>rightIndexer)
                {
                    midIndexer = 0;
                    rotationIndex = 0;
                    break;
                }
                midIndexer = (rightIndexer + leftIndexer) / 2;
            }
            rotationIndex += midIndexer;
            leftIndexer = 0;
            rightIndexer = nums.Length - 1;
            int rotatedMidIndexer;
            while (leftIndexer<=rightIndexer)
            {
                midIndexer = (rightIndexer + leftIndexer) / 2;
                rotatedMidIndexer = (midIndexer + rotationIndex < nums.Length) ? midIndexer + rotationIndex : (midIndexer + rotationIndex) - nums.Length;
                if (nums[rotatedMidIndexer] ==target)
                {
                    return rotatedMidIndexer;
                }
                else if (nums[rotatedMidIndexer] <target)
                {
                    leftIndexer = (leftIndexer == midIndexer) ? midIndexer + 1 : midIndexer;
                } else
                {
                    rightIndexer = (rightIndexer==midIndexer) ? midIndexer-1 : midIndexer;
                }
            }
            return -1;
        }

        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Enter rotated array (nums):");
            _target = ProblemIO.ReadIntFromConsole("Enter target element (target):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = Search(_nums, _target);
        }
    }
}
