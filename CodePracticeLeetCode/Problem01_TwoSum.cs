namespace CodePracticeLeetCode
{
    /*
     * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * You can return the answer in any order.
     */
    public class Problem01_TwoSum : IProblem
    {
        public int[] _nums = [];
        public int _target;
        public int[] _output = [];

        public int[] Solve(int[] nums, int target)
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
            try
            {
                Console.WriteLine("Enter Array of Integers (nums):");
                string? line1 = Console.ReadLine();
                if (!string.IsNullOrEmpty(line1))
                {
                    var splitLine1 = line1.Split(' ');
                    _nums = new int[splitLine1.Length];
                    for (int i = 0; i < splitLine1.Length; i++)
                    {
                        _nums[i] = Convert.ToInt32(splitLine1[i]);
                    }
                }
                Console.WriteLine("Enter Integer (target):");
                string? line2 = Console.ReadLine();
                _target = Convert.ToInt32(line2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Provided invalid input data");
                Console.WriteLine(ex.Message);
            }
        }

        public void Solve()
        {
            _output = Solve(_nums, _target);
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            foreach (int number in _output)
            {
                Console.Write(number + " ");
            }
        }
    }
}
