using System.Linq;

namespace _01.ReverseArray
{
    using System;

    public class ReverseArray
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            ReverseArrayRecurtion(array, 0);
        }

        private static void ReverseArrayRecurtion(int[] array, int index)
        {
            if (index >= array.Length / 2)
            {
                PrintArray(array);

            }
            else
            {
                var temp = array[index];
                array[index] = array[array.Length - index - 1];
                array[array.Length - index - 1] = temp;
                ReverseArrayRecurtion(array, index + 1);
            }
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
