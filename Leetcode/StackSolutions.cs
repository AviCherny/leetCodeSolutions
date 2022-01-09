using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class StackSolutions
    {
        public static bool IsValidParentheses(string s)
        {
            Stack<char> parentheses = new Stack<char>();
            {
                foreach (var sign in s)
                {
                    if (sign == '(')
                    {
                        parentheses.Push(')');
                    }
                    else if (sign == '[')
                    {
                        parentheses.Push(']');
                    }
                    else if (sign == '{')
                    {
                        parentheses.Push('}');
                    }
                    else
                    {
                        if (parentheses.Count == 0)
                            return false;
                        else if (parentheses.Pop() != sign)
                        {
                            return false;
                        }
                    }
                }
                if (parentheses.Count > 0)
                    return false;
                return true;
            }

        }

        public static void GoToNextFloor(List<int> reqFloors, int currentFloor)
        {
            var copyCollection = reqFloors;
            var allDistances = new Dictionary<int, int>();
            var floorsAlreadyViseted = new List<int>();
            var minDistance = int.MaxValue;
            var allMinDistances = new List<int>();

            for (int i = 0; i < copyCollection.Count; i++)
            {
                foreach (var floor in copyCollection)
                {
                    if (floorsAlreadyViseted.Contains(floor))
                    {
                        continue;
                    }

                    int distanceFromCurrentFloors = (Math.Abs(currentFloor - floor));
                    allDistances.Add(floor, distanceFromCurrentFloors);
                    minDistance = Math.Min(distanceFromCurrentFloors, minDistance);
                }

                int nextFloor = 0;
                foreach (var value in allDistances)
                {
                    if (value.Value == minDistance)
                    {
                        allMinDistances.Add(value.Key);
                        nextFloor = value.Key;
                    }
                }

                var random = new Random();
                if (allMinDistances.Count > 1)
                {
                    int randomSelectedFloor = random.Next(allMinDistances.Count);
                    currentFloor = allMinDistances[randomSelectedFloor];
                }

                else
                {
                    currentFloor = nextFloor;
                }

                floorsAlreadyViseted.Add(currentFloor);
                allDistances.Clear();
                allMinDistances.Clear();
                minDistance = int.MaxValue;
            }

            Console.WriteLine($"visited floors: ");
            foreach (var floor in floorsAlreadyViseted)
            {
                Console.Write($"{floor} -> ");
            }
        }
    }
}
