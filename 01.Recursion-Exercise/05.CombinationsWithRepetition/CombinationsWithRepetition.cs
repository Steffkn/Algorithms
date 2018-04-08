
namespace _05.CombinationsWithRepetition
{
    using System;

    public class CombinationsWithRepetition
    {
        private static int[] numbers;
        private static bool skipDuplicates = true;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            skipDuplicates = true;
            numbers = new int[k];
            SimulateNestedLoops(0, k, n);
        }

        private static void SimulateNestedLoops(int level, int lenght, int from, int start = 1)
        {
            if (level >= lenght)
            {
                PerformOperation(numbers);
            }
            else
            {
                for (int i = start; i <= from; i++)
                {
                    numbers[level] = i;
                    SimulateNestedLoops(level + 1, lenght, from, i + (skipDuplicates ? 1 : 0));
                }
            }
        }

        private static void PerformOperation(int[] counters)
        {
            Console.WriteLine(string.Join(" ", counters));
        }
    }
}
