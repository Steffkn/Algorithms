using System.Collections.Generic;

namespace _04.Generating0_1Vectors
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            GenerateFector(new int[n], 0);
        }

        private static void GenerateFector(IList<int> array, int index)
        {
            if (index > array.Count - 1)
            {
                Console.WriteLine(string.Join("", array));
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    array[index] = i;
                    GenerateFector(array, index + 1);
                }
            }
        }
    }
}
