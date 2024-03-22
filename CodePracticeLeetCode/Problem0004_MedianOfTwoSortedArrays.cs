using System;
using System.Globalization;

namespace CodePracticeLeetCode
{
    /*
     * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
     * The overall run time complexity should be O(log (m+n)).
     */
    public class Problem0004_MedianOfTwoSortedArrays : IProblem
    {
        int[] _nums1 { get; set; } = [];
        int[] _nums2 { get; set; } = [];
        double _output { get; set; }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums2.Length == 0 && nums1.Length == 0) return 0;
            if (nums1.Length == 0) return findMedian(nums2);
            if (nums2.Length == 0) return findMedian(nums1);
            if (nums1.Length > nums2.Length)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }
            int fullLenght = nums1.Length + nums2.Length;
            int leftIndex = 0;
            int rightIndex = nums1.Length;
            do
            {
                int smallPointer = (leftIndex + rightIndex) / 2;
                int largePointer = (fullLenght + 1) / 2 - smallPointer;
                int maxLeftNums1 = (smallPointer == 0) ? int.MinValue : nums1[smallPointer - 1];
                int minRightNums1 = (smallPointer == nums1.Length) ? int.MaxValue : nums1[smallPointer];
                int maxLeftNums2 = (largePointer == 0) ? int.MinValue : nums2[largePointer - 1];
                int minRightNums2 = (largePointer == nums2.Length) ? int.MaxValue : nums2[largePointer];
                if (maxLeftNums1 <= minRightNums2 && maxLeftNums2 <= minRightNums1)
                {
                    if ((fullLenght) % 2 == 0)
                    {
                        return (Math.Max(maxLeftNums1, maxLeftNums2) + Math.Min(minRightNums1, minRightNums2)) / 2.0;
                    }
                    else
                    {
                        return Math.Max(maxLeftNums1, maxLeftNums2);
                    }
                }
                else if (maxLeftNums1 > minRightNums2)
                {
                    rightIndex = smallPointer - 1;
                }
                else
                {
                    leftIndex = smallPointer + 1;
                }
            } while (true);
        }

        public double SolveOld(int[] nums1, int[] nums2)
        {
            int[] mergedNums = new int[nums1.Length + nums2.Length];
            int firstIndex = 0;
            int secondIndex = 0;
            if (mergedNums.Length < 1) return 0.0;
            if (nums1.Length < 1) return findMedian(nums2);
            if (nums2.Length < 1) return findMedian(nums1);
            for (int i = 0; i < mergedNums.Length; i++)
            {
                if (firstIndex < 0 && secondIndex < 0) break;
                if (secondIndex < 0 || (firstIndex >= 0 && nums1[firstIndex] <= nums2[secondIndex]))
                {
                    mergedNums[i] = nums1[firstIndex];
                    firstIndex = (firstIndex < nums1.Length - 1) ? firstIndex + 1 : -1;
                }
                else
                {
                    mergedNums[i] = nums2[secondIndex];
                    secondIndex = (secondIndex < nums2.Length - 1) ? secondIndex + 1 : -1;
                }
            }

            return findMedian(mergedNums);
        }

        public double findMedian(int[] nums)
        {
            if (nums.Length % 2 == 0)
            {
                return (nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2.0;
            }
            else
            {
                return nums[nums.Length / 2];
            }

        }

        public void ReadInput()
        {
            _nums1 = ProblemIO.ReadIntArrayFromConsole("Enter first array of Integers (nums1):");
            _nums2 = ProblemIO.ReadIntArrayFromConsole("Enter second array of Integers (nums2):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = FindMedianSortedArrays(_nums1, _nums2);
        }
    }
}
