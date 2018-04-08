namespace _02.Searching
{
    using System;
    using System.Linq;

    public class Searching
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int indexOf = Array.IndexOf(numbers, n);

            Console.WriteLine(indexOf);
        }
    }
}

