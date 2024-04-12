namespace CodePracticeLeetCode
{
    /*
     * Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.
     * The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.
     * 
     * The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.
     */
    public class Problem0039_CombinationSum : IProblem
    {
        private int[] _candidates { get; set; } = new int[0];
        private int _target { get; set; }
        private IList<IList<int>> _output { get; set; }

        Dictionary<int, IList<IList<int>>> cashedCombinations = new Dictionary<int, IList<IList<int>>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            FindCombinationSum(candidates, target, 0, 0, new List<int>(), result);
            return result;
        }

        private void FindCombinationSum(int[] candidates, int target, int index, int sum, IList<int> temp, IList<IList<int>> result)
        {
            if (sum == target)
            {
                result.Add(temp.ToArray());
                return;
            }

            while (sum < target && index < candidates.Length)
            {
                temp.Add(candidates[index]);

                FindCombinationSum(candidates, target, index, sum + candidates[index], temp, result);

                temp.RemoveAt(temp.Count - 1);
                index++;
            }
        }

        public void ReadInput()
        {
            _candidates = ProblemIO.ReadIntArrayFromConsole("Enter array of potential candidates (candidates):");
            _target = ProblemIO.ReadIntFromConsole("Enter target number (target):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = CombinationSum(_candidates, _target);
        }
    }
}
