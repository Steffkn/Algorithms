namespace _02.Factorial
{
    using System;

    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long nFact = Fact(n);
            Console.WriteLine(nFact);
        }

        private static long Fact(int index)
        {
            if (index == 0)
            {
                return 1;
            }

            return (index * Fact(index - 1));
        }
    }
}
