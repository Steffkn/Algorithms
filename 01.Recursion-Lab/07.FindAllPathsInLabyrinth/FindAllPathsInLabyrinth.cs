namespace _07.FindAllPathsInLabyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindAllPathsInLabyrinth
    {
        private static char[][] lab;
        private static List<char> path = new List<char>();
        private const char visitedChar = 'x';
        private const char endChar = 'e';
        private const char freeSpaceChar = '-';

        static void Main()
        {
            lab = ReadLabyrinth();
            FindAllPaths(0, 0, 'S');
        }

        private static void FindAllPaths(int row, int col, char direction)
        {
            if (!IsInMatrix(row, col))
            {
                return;
            }

            path.Add(direction);

            if (lab[row][col] == endChar)
            {
                PrintPath();
            }
            else if (IsFree(row, col))
            {
                Mark(row, col);
                FindAllPaths(row, col + 1, 'R');
                FindAllPaths(row + 1, col, 'D');
                FindAllPaths(row, col - 1, 'L');
                FindAllPaths(row - 1, col, 'U');
                Unmark(row, col);
            }

            path.RemoveAt(path.Count - 1);
        }

        private static void Unmark(int row, int col)
        {
            lab[row][col] = freeSpaceChar;
        }

        private static void Mark(int row, int col)
        {
            lab[row][col] = visitedChar;
        }

        private static bool IsFree(int row, int col)
        {
            return lab[row][col] == freeSpaceChar;
        }

        private static void PrintPath()
        {
            Console.WriteLine(string.Join("", path.Skip(1)));
        }

        private static bool IsInMatrix(int row, int col)
        {
            bool isInMatrix = row >= 0 && row < lab.GetLength(0)
                && col >= 0 && col < lab[row].GetLength(0);

            return isInMatrix;
        }

        private static char[][] ReadLabyrinth()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            var labyrinth = new char[n][];

            for (int i = 0; i < n; i++)
            {
                labyrinth[i] = Console.ReadLine()?.ToCharArray();
            }

            return labyrinth;
        }
    }
}
