namespace _01.Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double side)
            : base(side, side)
        { 
            
        }

        public override double CalculateSurface()
        {
            return Math.PI * (this.Width / 2) * (this.Height / 2);
        }
    }
}
