namespace CodePracticeLeetCode
{
    /*
     * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * You can return the answer in any order.
     */
    public class Problem0001_TwoSum : IProblem
    {
        public int[] _nums = [];
        public int _target;
        public int[] _output = [];

        public int[] TwoSum(int[] nums, int target)
        {
            int[] answer = new int[2];
            Dictionary<int, int> indexMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!indexMap.ContainsKey(target - nums[i]))
                {
                    if (!indexMap.ContainsKey(nums[i]))
                    {
                        indexMap.Add(nums[i], i);
                    }
                }
                else
                {
                    answer[0] = indexMap[target - nums[i]];
                    answer[1] = i;
                }
            }
            return answer;
        }

        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Enter Array of Integers (nums):");
            _target = ProblemIO.ReadIntFromConsole("Enter Integer (target):");
        }

        public void Solve()
        {
            _output = TwoSum(_nums, _target);
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }
    }
}
