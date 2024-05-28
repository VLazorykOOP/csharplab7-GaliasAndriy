using System;
using System.Drawing;

namespace Lab7CSharp
{
    public class RegularTriangle : Shape
    {
        public int SideLength { get; private set; }

        public RegularTriangle(Point position, Color color, int sideLength)
            : base(position, color)
        {
            SideLength = sideLength;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                // Calculate the vertices of the triangle
                Point[] vertices = new Point[3];
                vertices[0] = new Point(Position.X, Position.Y);
                vertices[1] = new Point(Position.X + SideLength / 2, Position.Y + (int)(SideLength * Math.Sqrt(3) / 2));
                vertices[2] = new Point(Position.X - SideLength / 2, Position.Y + (int)(SideLength * Math.Sqrt(3) / 2));

                g.DrawPolygon(pen, vertices);
            }
        }
    }
}