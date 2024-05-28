using System.Drawing;

namespace Lab7CSharp
{
    public class CircleWithText : Shape
    {
        public int Radius { get; private set; }
        public string Text { get; private set; }

        public CircleWithText(Point position, Color color, int radius, string text)
            : base(position, color)
        {
            Radius = radius;
            Text = text;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                g.DrawEllipse(pen, Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);

                using (Font font = new Font("Arial", 12))
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    RectangleF rect = new RectangleF(Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
                    g.DrawString(Text, font, Brushes.Black, rect, format);
                }
            }
        }
    }
}