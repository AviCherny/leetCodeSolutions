using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class SlidingWindow
    {
        /// <summary>
        /// we used fixed sliding window 
        /// by remove the left index and appand the right index
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        public static void FindMaxSumSubArrayWithFixedSubSize(int[] arr, int k)
        {
            int maxValue = int.MinValue;
            int currentRunningSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentRunningSum += arr[i];

                //filling the currentRunningSum with first elemnt of array till k-1
                if (i >= k-1)
                {
                    maxValue = Math.Max(maxValue, currentRunningSum);
                    currentRunningSum -= arr[i - (k - 1)];//reduce most left element in order to make the searching window to slide
                }
            }
            Console.WriteLine($"FindMaxSumSubArray result is : {maxValue}" );
        }

        public static void FindMinSumSubArrayWithFixedSubSize(int[] arr, int k)
        {
            int minValue = int.MaxValue;
            int currentRunningSum = 0;

            for (int i = 0; i<arr.Length; i++)
            {
                currentRunningSum += arr[i];
                if (i >= k-1)
                {
                    minValue = Math.Min(minValue, currentRunningSum);
                    currentRunningSum -= arr[i - (k - 1)];
                }
            }

            Console.WriteLine($"FindSmallestSubArray {minValue}");
        }

        /// <summary>
        /// Dynamic slide array 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        public static void FindSmallestSubArrayThatSumBiggerThanGivenValue(int[] arr, int k)
        {
            int minWindowSize = int.MaxValue;
            int currentWindowSum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                currentWindowSum += arr[windowEnd];
                while (currentWindowSum >= k)
                {
                    minWindowSize = Math.Min(minWindowSize, windowEnd - windowStart + 1);//delta how long is our window is 
                    currentWindowSum -= arr[windowStart];
                    windowStart++;
                }
            }
            Console.WriteLine($"minWindowSize {minWindowSize}");

            


        }

    }
}
