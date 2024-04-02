namespace CodePracticeLeetCode
{
    /*
     * A permutation of an array of integers is an arrangement of its members into a sequence or linear order.
     * For example, for arr = [1,2,3], the following are all the permutations of arr: [1,2,3], [1,3,2], [2, 1, 3], [2, 3, 1], [3,1,2], [3,2,1].
     * The next permutation of an array of integers is the next lexicographically greater permutation of its integer. More formally, if all the permutations of the array are sorted in one container according to their lexicographical order, then the next permutation of that array is the permutation that follows it in the sorted container.
     * If such arrangement is not possible, the array must be rearranged as the lowest possible order (i.e., sorted in ascending order).
     * For example, the next permutation of arr = [1,2,3] is [1,3,2].
     * Similarly, the next permutation of arr = [2,3,1] is [3,1,2].
     * While the next permutation of arr = [3,2,1] is [1,2,3] because [3,2,1] does not have a lexicographical larger rearrangement.
     * Given an array of integers nums, find the next permutation of nums.
     * The replacement must be in place and use only constant extra memory.
     */
    public class Problem0031_NextPermutation : IProblem
    {
        private int[] _nums { get; set; } = new int[0];
        public void NextPermutation(int[] nums)
        {
            for (int i=nums.Length-2; i>=0; i--)
            {
                if (nums[i] < nums[i+1] || i==0)
                {
                    bool switched = false;
                    for (int j=nums.Length-1; j>0; j--)
                    {
                        if (nums[j] > nums[i])
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            switched = true;
                            break;
                        }
                    }
                    int leftIndex = (switched) ? i+1 : i;
                    int rightIndex = nums.Length - 1;
                    while (leftIndex<rightIndex)
                    {
                        int temp = nums[leftIndex];
                        nums[leftIndex] = nums[rightIndex];
                        nums[rightIndex] = temp;
                        leftIndex++;
                        rightIndex--;
                    }
                    break;
                }
            }
        }

        public void ReadInput()
        {
            _nums = ProblemIO.ReadIntArrayFromConsole("Enter array of integers (nums):");
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer");
            foreach (int number in _nums)
            {
                Console.Write(number + " ");
            }
        }

        public void Solve()
        {
            NextPermutation(_nums);
        }
    }
}
