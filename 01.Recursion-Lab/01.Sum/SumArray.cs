namespace _01.SumArray
{
    using System;
    using System.Linq;

    public class SumArray
    {
        public static void Main()
        {
            var array = Console.ReadLine()?
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            long sum = Sum(array, 0);
            Console.WriteLine(sum);
        }

        private static long Sum(int[] array, int index)
        {
            if (index == array.Length)
            {
                return 0;
            }

            return (array[index] + Sum(array, index + 1));
        }
    }
}
