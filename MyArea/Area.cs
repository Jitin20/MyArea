using System;

namespace MyArea
{
    public class Area
    {
        public float Circle(int radius)
        {
            return (float)Math.PI * radius * radius;
        }
        public float Square(int side)
        {
            return (float)side * side;
        }
        public float Triangle(int b, int h)
        {
            return (float).5 * b * h;
        }

        public int Rectangle(int l, int b)

        {
            return l * b;
        }
    }
}
