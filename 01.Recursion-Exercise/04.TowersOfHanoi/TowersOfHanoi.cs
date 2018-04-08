using System.Collections.Generic;
using System.Linq;

namespace _04.TowersOfHanoi
{
    using System;

    public class TowersOfHanoi
    {
        private static int stepsTaken = 0;
        private static Stack<int> source;
        private static Stack<int> spare = new Stack<int>();
        private static Stack<int> destination = new Stack<int>();

        public static void Main()
        {
            int numberOfDisks = int.Parse(Console.ReadLine());
            source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            PrintRods(true);
            MoveDisks(numberOfDisks, source, destination, spare);
        }

        private static void PrintRods(bool initial = false)
        {
            if (!initial)
            {
                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
            }
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
            Console.WriteLine();
        }

        private static void MoveDisks(int bottomDisk, Stack<int> sourceRod, Stack<int> destinationRod, Stack<int> spareRod)
        {
            if (bottomDisk == 1)
            {
                stepsTaken++;
                destinationRod.Push(sourceRod.Pop());
                PrintRods();
            }
            else
            {
                MoveDisks(bottomDisk - 1, sourceRod, spareRod, destinationRod);
                stepsTaken++;
                destinationRod.Push(sourceRod.Pop());
                PrintRods();
                MoveDisks(bottomDisk - 1, spareRod, destinationRod, sourceRod);
            }
        }
    }
}
