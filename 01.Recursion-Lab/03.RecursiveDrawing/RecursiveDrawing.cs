namespace _03.RecursiveDrawing
{
    using System;

    public class RecursiveDrawing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Draw(n);
        }

        private static void Draw(int index)
        {
            if (index <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', index));
            Draw(index - 1);
            Console.WriteLine(new string('#', index));
        }
    }
}