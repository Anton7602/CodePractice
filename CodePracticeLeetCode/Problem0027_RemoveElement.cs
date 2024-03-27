namespace CodePracticeLeetCode
{
    public class Problem0027_RemoveElement : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        private int _val { get; set; }
        private int _output {  get; set; }

        public int RemoveElement(int[] nums, int val)
        {
            int slowIndex = 0;
            for (int i=0; i<nums.Length;i++)
            {
                if (nums[i]!=val)
                {
                    nums[slowIndex] = nums[i];
                    slowIndex++;
                }
            }
            return slowIndex;
        }

        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Input integer array (nums):");
            _val = ProblemIO.ReadIntFromConsole("Input value to remove from array");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = RemoveElement(_nums, _val);
        }
    }
}
