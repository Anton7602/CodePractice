namespace CodePracticeLeetCode
{
    /*
     * Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that: 0 <= a, b, c, d < n; a, b, c, and d are distinct; nums[a] + nums[b] + nums[c] + nums[d] == target
     * You may return the answer in any order.
     */
    public class Problem0018_4Sum : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private int _target { get; set; }
        private IList<IList<int>> _output { get; set; }

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            return nSum(4, nums, target).ToArray();
        }

        public List<List<int>> nSum(int n, int[] nums, long target, int startIndex = 0)
        {
            if (n > 2)
            {
                List<List<int>> combinations = new List<List<int>>();
                for (int i = startIndex; i < nums.Length - n+1; i++)
                {
                    if (i > startIndex && nums[i] == nums[i - 1]) continue;
                    List<List<int>> currentCombinations = nSum(n - 1, nums, target - nums[i], i + 1);
                    foreach (List<int> combination in currentCombinations)
                    {
                        combination.Add(nums[i]);
                    }
                    combinations.AddRange(currentCombinations);
                }
                return combinations;
            }
            else
            {
                int leftIndex = startIndex;
                int rightIndex = nums.Length - 1;
                List<List<int>> combinations = new List<List<int>>();
                while (leftIndex < rightIndex)
                {
                    if (nums[leftIndex] + nums[rightIndex] < target)
                    {
                        leftIndex++;
                    }
                    else if (nums[leftIndex] + nums[rightIndex] > target)
                    {
                        rightIndex--;
                    }
                    else
                    {
                        combinations.Add(new List<int> { nums[leftIndex], nums[rightIndex] });
                        leftIndex++;
                        while (leftIndex < rightIndex && nums[leftIndex] == nums[leftIndex - 1])
                        {
                            leftIndex++;
                        }
                    }
                }
                return combinations;
            }
        }

        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Enter Array of Integers (nums):");
            _target = ProblemIO.ReadIntFromConsole("Enter target number (target):");
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            int answerCounter = 1;
            foreach (IList<int> quadruplet in _output)
            {
                Console.WriteLine("Quadruplet " + answerCounter + ": " + quadruplet[0] + " " + quadruplet[1] + " " + quadruplet[2] + " " + quadruplet[3]);
                answerCounter++;
            }
        }

        public void Solve()
        {
            _output = FourSum(_nums, _target);
        }
    }
}
