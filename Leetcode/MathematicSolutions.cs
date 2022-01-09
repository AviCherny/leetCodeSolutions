using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class MathematicSolutions
    {
        /// <summary>
        /// palindrome is a same number when reading it from both sides e.g 123321
        /// it achieved by creating new opsosite number and compare them 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsNumberIsPolidrom(int number)
        {
            var copyNumber = number;
            long revertNumber = 0;
            while (copyNumber > 0)
            {
                copyNumber /= 10;
                revertNumber += copyNumber % 10;
                revertNumber *= 10;
            }

            revertNumber /= 10;
            if (revertNumber == number)
            {
                return true;
            }
            return false;
        }

    }
}
