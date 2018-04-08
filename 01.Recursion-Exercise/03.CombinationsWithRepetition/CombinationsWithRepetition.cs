namespace _03.CombinationsWithRepetition
{
    using System;

    public class CombinationsWithRepetition
    {
        private static int[] numbers;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
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
                    SimulateNestedLoops(level + 1, lenght, from, i);
                }
            }
        }

        private static void PerformOperation(int[] counters)
        {
            Console.WriteLine(string.Join(" ", counters));
        }
    }
}
