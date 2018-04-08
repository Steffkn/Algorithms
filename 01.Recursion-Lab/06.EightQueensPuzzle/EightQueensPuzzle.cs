namespace _06.EightQueensPuzzle
{
    using System;
    using System.Collections.Generic;

    public class EightQueensPuzzle
    {
        private const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        static void Main()
        {
            PlaceQueens(0);
        }

        private static void PlaceQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PlaceQueens(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(row + col);
            chessboard[row, col] = false;
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(row + col);
            chessboard[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var placeOccupied = attackedRows.Contains(row)
                                || attackedCols.Contains(col)
                                || attackedLeftDiagonals.Contains(col - row)
                                || attackedRightDiagonals.Contains(row + col);
            return !placeOccupied;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    Console.Write(chessboard[row, col] ? "* " : "- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
