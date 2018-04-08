namespace _02.NestedLoops
{
    using System;

    public class NestedLoops
    {
        private static int[] numbers;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            SimulateNestedLoops(0, n);
        }

        private static void SimulateNestedLoops(int level, int lenght, int start = 1)
        {
            if (level >= lenght)
            {
                PerformOperation(numbers);
            }
            else
            {
                for (int i = start; i <= lenght; i++)
                {
                    numbers[level] = i;
                    SimulateNestedLoops(level + 1, lenght);
                }
            }
        }

        private static void PerformOperation(int[] counters)
        {
            Console.WriteLine(string.Join(" ", counters));
        }
    }
}
