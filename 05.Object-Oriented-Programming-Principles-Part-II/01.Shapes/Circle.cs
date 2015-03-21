namespace _01.Shapes
{
    using System;

    public class Circle : Shape
    {
        public Circle(double diameter)
            : base(diameter, diameter)
        { 
            
        }

        public override double CalculateSurface()
        {
            return Math.PI * (this.Width / 2) * (this.Height / 2);
        }
    }
}
