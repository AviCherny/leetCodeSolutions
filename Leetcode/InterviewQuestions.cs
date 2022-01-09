using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class InterviewQuestions
    {
        /// <summary>
        /// LivePerson
        /// Q: create generic function that elevator moves to the requested floors based on minimum distance algorithm 
        ///Example: reqFloors = 2,1,9,8,7,3  / 1,5,8
        ///current floor = 6 > 7 > 8 > 9 > 3 > 2 > 1 / > 5 > 8 > 1
        ///Current floor = 4 > 3 > 2 > 1 > 7 > 8 > 9
        ///Current floor = 5 randomly, same logic
        //algorithm = minimum closest distance

        /// </summary>
        /// <param name="reqFloors"></param>
        /// <param name="currentFloor"></param>
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
