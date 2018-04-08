namespace _06.ConnectedAreasInMatrix
{
    using System;

    public class Area : IComparable<Area>
    {
        public Area(int size, int row, int col)
        {
            this.Size = size;
            this.Row = row;
            this.Col = col;
        }

        public int Size { get; set; }

        public int Row { get; }

        public int Col { get; }

        public int CompareTo(Area other)
        {
            int compare = this.Size.CompareTo(other.Size);
            if (compare == 0)
            {
                compare = this.Row.CompareTo(other.Row);

                if (compare == 0)
                {
                    compare = this.Col.CompareTo(other.Col);
                }
            }

            return compare;
        }

        public override string ToString()
        {
            return $"({this.Row}, {this.Col}), size: {this.Size}";
        }
    }
}
