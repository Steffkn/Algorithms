namespace _05.GeneratingCombinations
{
    using System;
    using System.Linq;

    public class GeneratingCombinations
    {
        static void Main()
        {
            var array = Console.ReadLine()?
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var n = int.Parse(Console.ReadLine());
            GenerateCombination(array, new int[n], 0, 0);
        }

        private static void GenerateCombination(int[] array, int[] vector, int index, int border)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = border; i < array.Length; i++)
                {
                    vector[index] = array[i];
                    GenerateCombination(array, vector, index + 1, i + 1);
                }
            }
        }
    }
}
