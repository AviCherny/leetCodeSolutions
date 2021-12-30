using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 6, 9, 7, 8, 2, 4, 6, 2, 8, 7, 5, 3 };
            SlidingWindow.FindMaxSumSubArrayWithFixedSubSize(new int[] { 2, 6, 9, 7, 8, 2, 4, 6, 2, 8, 7, 5, 3 }, 3);
            SlidingWindow.FindMinSumSubArrayWithFixedSubSize(arr, 9);
            SlidingWindow.FindSmallestSubArrayThatSumBiggerThanGivenValue(arr, 9);
            var a = SolutionUsingDictionary.ReturnTwoIndexesOfSumTarget(new int[] { 3,2,4}, 6);
            
        }
    }
}
