using System.Drawing;

namespace Lab7CSharp
{
    public abstract class Shape
    {
        public Point Position { get; set; }
        public Color Color { get; set; }

        protected Shape(Point position, Color color)
        {
            Position = position;
            Color = color;
        }

        public abstract void Draw(Graphics g);
        public virtual void Move(int dx, int dy)
        {
            Position = new Point(Position.X + dx, Position.Y + dy);
        }
    }
}