namespace CodePracticeLeetCode
{
    /*
     * You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
     * Find two lines that together with the x-axis form a container, such that the container contains the most water.
     * Return the maximum amount of water a container can store.
     * Notice that you may not slant the container.
     */
    public class Problem0011_ContainerWithMostWater : IProblem
    {
        private int[] _height { get; set; } = new int[0];
        private int _output {  get; set; }

        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int leftIndexer = 0;
            int rightIndexer = height.Length - 1;
            while(rightIndexer>leftIndexer)
            {
                int area = (rightIndexer - leftIndexer) * Math.Min(height[leftIndexer], height[rightIndexer]);
                maxArea = Math.Max(maxArea, area);
                if (height[rightIndexer] < height[leftIndexer])
                {
                    rightIndexer--;
                } else
                {
                    leftIndexer++;
                }
            }
            return maxArea;
        }

        public void ReadInput()
        {
            _height = ProblemIO.ReadIntArrayFromConsole("Enter heights array (height):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = MaxArea(_height);
        }
    }
}
