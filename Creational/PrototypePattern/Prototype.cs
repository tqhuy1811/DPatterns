/*
 Another useless complex pattern. Use FP concept for this type of problem would makes it much more easier to understand
*/
namespace DesignPattern
{
    public abstract class Shape 
    {
        public int X { get; }
        public int Y { get; }

        public Shape(Shape source)
        {
            this.X = source.X;
            this.Y = source.Y;
        }


        public abstract Shape Clone();

    }
}