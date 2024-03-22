namespace CodePracticeLeetCode
{
    /*
     * Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.
     * Return the sum of the three integers.
     * You may assume that each input would have exactly one solution.
     */
    public class Problem0016_3SumClosest : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private int _target { get; set; }
        private int _output { get; set; }

        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums.Length < 3) throw new ArgumentException();
            int closestSum = nums[0] + nums[1] + nums[2];
            Array.Sort(nums);
            for (int i=0; i<nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int leftIndexer = i + 1;
                int rightIndexer = nums.Length -1;
                while (leftIndexer<rightIndexer)
                {
                    int sum = nums[i] + nums[leftIndexer] + nums[rightIndexer];
                    if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = sum;
                    }
                    if (sum>target)
                    {
                        rightIndexer--;

                    } else if (sum<target)
                    {
                        leftIndexer++;
                    }
                    else
                    {
                        return sum;
                    }
                }
            }
            return closestSum;
        }

        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Enter Array of Integers (nums):");
            _target = ProblemIO.ReadIntFromConsole("Enter target number (target):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = ThreeSumClosest(_nums, _target);
        }
    }
}
