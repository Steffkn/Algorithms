namespace _04.Needles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Needles
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int c = int.Parse(inputArr[0]);
            int n = int.Parse(inputArr[1]);

            string[] cArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, int> leftMostPositions = new Dictionary<int, int>();
            List<int> leftMostPositionsArr = new List<int>();

            for (int i = 0; i < cArr.Length; i++)
            {
                int current = int.Parse(cArr[i]);
                if (current != 0)
                {
                    if (!leftMostPositions.ContainsKey(current))
                    {
                        leftMostPositions.Add(current, i);
                        leftMostPositionsArr.Add(int.Parse(cArr[i]));
                    }
                    else
                    {
                        leftMostPositions[current] = i;
                    }
                }
            }

            int[] needles = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> resultArr = new List<int>(n);

            for (int i = 0; i < needles.Length; i++)
            {
                int index = leftMostPositionsArr.BinarySearch(needles[i]);

                if (index == 0)
                {
                    resultArr.Add(0);
                }
                else if (index > 0 && index < leftMostPositionsArr.Count)
                {
                    resultArr.Add(leftMostPositions[leftMostPositionsArr[index - 1]] + 1);
                }
                else
                {
                    index = ~index;
                    if (index == 0)
                    {
                        resultArr.Add(0);
                    }
                    else
                    {
                        resultArr.Add(leftMostPositions[leftMostPositionsArr[index - 1]] + 1);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
