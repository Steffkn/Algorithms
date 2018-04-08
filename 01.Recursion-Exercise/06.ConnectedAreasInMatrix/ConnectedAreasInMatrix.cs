namespace _06.ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;

    public class ConnectedAreasInMatrix
    {
        private static char[,] maze;
        private static int currentAreaSize = 0;
        private static SortedSet<Area> matches = new SortedSet<Area>();

        static void Main()
        {
            maze = ReadMaze();
            Discover();
            PrintAreas();
        }

        private static char[,] ReadMaze()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            char[,] newMaze = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < m; j++)
                {
                    newMaze[i, j] = input[j];
                }
            }

            return newMaze;
        }

        static void Discover()
        {
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (maze[row, col] == '-')
                    {
                        Mark(row, col);
                        matches.Add(new Area(currentAreaSize, row, col));
                        currentAreaSize = 0;
                    }
                }
            }
        }

        static void Mark(int row, int col)
        {
            if (row < 0 || col < 0 || row >= maze.GetLength(0) || col >= maze.GetLength(1))
            {
                return;
            }

            if (maze[row, col] == '%' || maze[row, col] == '*')
            {
                return;
            }

            currentAreaSize++;
            maze[row, col] = '%';

            Mark(row, col + 1);
            Mark(row + 1, col);
            Mark(row, col - 1);
            Mark(row - 1, col);
        }

        static void PrintAreas()
        {
            if (matches.Count <= 0)
            {
                Console.WriteLine("No area's found!");
            }
            else
            {
                int count = 1;
                Console.WriteLine("Total areas found: " + matches.Count);
                foreach (var match in matches)
                {
                    Console.WriteLine("Area #{0} at {1}", count, match);
                    count++;
                }
            }
        }
    }
}
