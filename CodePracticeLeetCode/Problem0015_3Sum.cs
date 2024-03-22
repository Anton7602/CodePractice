namespace CodePracticeLeetCode
{
    /*
     * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
     * Notice that the solution set must not contain duplicate triplets.
     */
    public class Problem0015_3Sum : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private IList<IList<int>> _output { get; set; }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int indexLeft = i + 1;
                int indexRight = nums.Length - 1;
                while(indexLeft<indexRight)
                {
                    int sum = nums[i] + nums[indexLeft] + nums[indexRight];
                    if (sum>0)
                    {
                        indexRight--;
                    } else if(sum<0)
                    {
                        indexLeft++;
                    } else
                    {
                        result.Add(new List<int>() { nums[i], nums[indexLeft], nums[indexRight] });
                        indexLeft++;
                        while (nums[indexLeft] == nums[indexLeft-1] && indexLeft<indexRight)
                        {
                            indexLeft++;
                        }
                    }

                }
            }
            return result.ToArray();
        }
        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Enter Array of Integers (nums):");
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            int answerCounter = 1;
            foreach (IList<int> triplet in _output)
            {
                Console.WriteLine("Triplet " + answerCounter + ":" + triplet[0] + " " + triplet[1] + " " + triplet[2]);
                answerCounter++;
            }
        }

        public void Solve()
        {
            _output = ThreeSum(_nums);
        }
    }
}
