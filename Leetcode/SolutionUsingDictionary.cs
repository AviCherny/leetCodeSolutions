using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class SolutionUsingDictionary
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// Input: nums = [2,7,11,15], target = 9
        //Output: [0,1]
        /// </summary>
        public static int [] ReturnTwoIndexesOfSumTarget(int[] arr, int target)
        {
            var dic = new Dictionary<int, int>();
            dic.Add(0, arr[0]);
            for(int i = 1; i<arr.Length; i++)
            {
                var currentValue = arr[i];
                if (dic.ContainsValue(target - currentValue))
                {
                    return new int[] { i, dic.FirstOrDefault(x => x.Value == target - currentValue).Key };
                }
                dic.Add(i, currentValue);
            }
            return null;
        }
    }
}
