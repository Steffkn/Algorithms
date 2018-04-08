namespace _01.Sorting
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Sorting
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        public class Quicksorter<T> where T : IComparable<T>
        {
            private int low = 0;
            private int high;

            public void Sort(List<T> collection)
            {
                this.high = collection.Count;
                this.QuickSort(collection, this.low, this.high);
            }

            private void QuickSort(List<T> collection, int low, int high)
            {
                if (low < high)
                {
                    int pivotLocation = this.Partition(collection, low, high);
                    QuickSort(collection, low, pivotLocation);
                    QuickSort(collection, pivotLocation + 1, high);
                }
            }

            private int Partition(List<T> collection, int low, int high)
            {
                T pivot = collection[low];
                int leftWall = low;
                for (int i = low + 1; i < high; i++)
                {
                    if (collection[i].CompareTo(pivot) < 0)
                    {
                        leftWall++;
                        this.Swap(collection, i, leftWall);
                    }
                }

                this.Swap(collection, low, leftWall);
                return leftWall;
            }

            private void Swap(List<T> collection, int t1, int t2)
            {
                T temp = collection[t1];
                collection[t1] = collection[t2];
                collection[t2] = temp;
            }
        }
    }
}
