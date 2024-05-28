using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        private List<Figure> figures = new List<Figure>();
        private Random random; // Random number generator

        public Form3()
        {
            InitializeComponent();

            figures = new List<Figure>();
            random = new Random();

            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                comboBox1.Items.Add(color.Name);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clearAllComponentsExceptLabel()
        {
            // Store the default label
            Label defaultLabel = null;
            foreach (Control control in groupBox3.Controls)
            {
                if (control is Label && control != defaultLabel)
                {
                    defaultLabel = (Label)control;
                    break;
                }
            }

            // Clear the existing controls in the groupBox, except for the default label
            groupBox3.Controls.Clear();

            if (defaultLabel != null)
            {
                groupBox3.Controls.Add(defaultLabel);
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Text = "Параметри п'ятикутника";

                clearAllComponentsExceptLabel();

                // Adding labels and input boxes
                Label pentagonSideLabel = new Label();
                pentagonSideLabel.Text = "Розмір сторони:";
                pentagonSideLabel.Location = new Point(15, 35);
                groupBox3.Controls.Add(pentagonSideLabel);

                TextBox pentagonTextBox = new TextBox();
                pentagonTextBox.Location = new Point(20, 58);
                groupBox3.Controls.Add(pentagonTextBox);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label5.Text = "Параметри квадрата";

                clearAllComponentsExceptLabel();

                // Adding labels and input boxes
                Label squareSideLabel = new Label();
                squareSideLabel.Text = "Розмір сторони:";
                squareSideLabel.Location = new Point(15, 35);
                groupBox3.Controls.Add(squareSideLabel);

                TextBox squareTextBox = new TextBox();
                squareTextBox.Location = new Point(20, 58);
                groupBox3.Controls.Add(squareTextBox);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label5.Text = "Параметри ромба";

                clearAllComponentsExceptLabel();

                // Adding labels and input boxes
                Label rhombDiagonalLabe1 = new Label();
                rhombDiagonalLabe1.Text = "Діагональ 1:";
                rhombDiagonalLabe1.Location = new Point(15, 40);
                groupBox3.Controls.Add(rhombDiagonalLabe1);
                rhombDiagonalLabe1.Width = 72;

                TextBox textBox1 = new TextBox();
                textBox1.Location = new Point(90, 37);
                groupBox3.Controls.Add(textBox1);
                textBox1.Width = 50;

                Label rhombDiagonalLabe2 = new Label();
                rhombDiagonalLabe2.Text = "Діагональ 2:";
                rhombDiagonalLabe2.Location = new Point(15, 75);
                groupBox3.Controls.Add(rhombDiagonalLabe2);
                rhombDiagonalLabe2.Width = 72;

                TextBox textBox2 = new TextBox();
                textBox2.Location = new Point(90, 72);
                groupBox3.Controls.Add(textBox2);
                textBox2.Width = 50;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColorName = comboBox1.SelectedItem.ToString();
            Color selectedColor = Color.FromName(selectedColorName);

            // Set the label's text color to the selected color
            panel2.BackColor = selectedColor;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label5.Text = "Параметри прямокутника";

                clearAllComponentsExceptLabel();

                // Adding labels and input boxes
                Label labelWidth = new Label();
                labelWidth.Text = "Ширина:";
                labelWidth.Location = new Point(15, 40);
                groupBox3.Controls.Add(labelWidth);
                labelWidth.Width = 50;

                TextBox textBoxWidth = new TextBox();
                textBoxWidth.Location = new Point(85, 37);
                groupBox3.Controls.Add(textBoxWidth);
                textBoxWidth.Width = 50;

                Label labelHeight = new Label();
                labelHeight.Text = "Довжина:";
                labelHeight.Location = new Point(15, 75);
                groupBox3.Controls.Add(labelHeight);
                labelHeight.Width = 59;

                TextBox textBoxHeight = new TextBox();
                textBoxHeight.Location = new Point(85, 72);
                groupBox3.Controls.Add(textBoxHeight);
                textBoxHeight.Width = 50;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label5.Text = "Параметри трикутника";

                clearAllComponentsExceptLabel();

                // Adding labels and input boxes
                Label triangleSideLabel = new Label();
                triangleSideLabel.Text = "Розмір сторони:";
                triangleSideLabel.Location = new Point(15, 35);
                groupBox3.Controls.Add(triangleSideLabel);

                TextBox triangleSideTextBox = new TextBox();
                triangleSideTextBox.Location = new Point(20, 58);
                groupBox3.Controls.Add(triangleSideTextBox);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // button add figure in array
        {
            Color selectedColor = Color.FromName(comboBox1.SelectedItem.ToString());

            if (radioButton3.Checked)
            {
                if (int.TryParse(groupBox3.Controls.OfType<TextBox>().FirstOrDefault()?.Text, out int size))
                {
                    if (size >= 5 && size <= 200)
                    {
                        figures.Add(new Triangle(size, selectedColor));
                        label6.Text = "Фігуру додано";
                        label6.ForeColor = Color.Green;
                    }
                    else
                    {
                        label6.Text = "Розмір сторони повинен бути (5-200px)";
                        label6.ForeColor = Color.Red;
                    }
                }
            }

            // if checked pentagon radio box
            else if (radioButton1.Checked)
            {
                if (int.TryParse(groupBox3.Controls.OfType<TextBox>().FirstOrDefault()?.Text, out int size))
                {
                    if (size >= 5 && size <= 200)
                    {
                        figures.Add(new Pentagon(size, selectedColor));
                        label6.Text = "Фігуру додано";
                        label6.ForeColor = Color.Green;
                    }
                    else
                    {
                        label6.Text = "Розмір сторони повинен бути (5-200px)";
                        label6.ForeColor = Color.Red;
                    }
                }
            }
            // Rectangle
            else if (radioButton2.Checked)
            {
                if (int.TryParse(groupBox3.Controls.OfType<TextBox>().ElementAtOrDefault(0)?.Text, out int width) &&
                    int.TryParse(groupBox3.Controls.OfType<TextBox>().ElementAtOrDefault(1)?.Text, out int height))
                {
                    if (width >= 5 && width <= 200 && height >= 5 && height <= 200)
                    {
                        figures.Add(new Rectangle(width, height, selectedColor));
                        label6.Text = "Фігуру додано";
                        label6.ForeColor = Color.Green;
                    }
                    else
                    {
                        label6.Text = "Введено не правильні розміри (5-200px)";
                        label6.ForeColor = Color.Red;
                    }
                }
            }
            // Rhomb
            else if (radioButton4.Checked)
            {
                if (int.TryParse(groupBox3.Controls.OfType<TextBox>().ElementAtOrDefault(0)?.Text, out int diagonal1) &&
                    int.TryParse(groupBox3.Controls.OfType<TextBox>().ElementAtOrDefault(1)?.Text, out int diagonal2))
                {
                    if (diagonal1 >= 5 && diagonal1 <= 200 && diagonal2 >= 5 && diagonal2 <= 200)
                    {
                        figures.Add(new Rhomb(diagonal1, diagonal2, selectedColor));
                        label6.Text = "Фігуру додано";
                        label6.ForeColor = Color.Green;
                    }
                    else
                    {
                        label6.Text = "Введено не правильні розміри (3-70p)";
                        label6.ForeColor = Color.Red;
                    }
                }
            }
            else if (radioButton5.Checked)
            {
                if (int.TryParse(groupBox3.Controls.OfType<TextBox>().FirstOrDefault()?.Text, out int size))
                {
                    if (size >= 5 && size <= 200)
                    {
                        figures.Add(new Square(size, selectedColor));
                        label6.Text = "Фігуру додано";
                        label6.ForeColor = Color.Green;
                    }
                    else
                    {
                        label6.Text = "Розмір сторони повинен бути (5-200px)";
                        label6.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                label6.Text = "Введені хибні дані";
                label6.ForeColor = Color.Red;
            }

            UpdateFigureListBox();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public abstract class Figure
        {
            protected int size;
            public Color Color { get; set; }
            public Figure(int size, Color color)
            {
                this.size = size;
                Color = color;
            }
            public int GetSize()
            {
                return size;
            }

            public abstract void Draw(Graphics graphics, int x, int y, int width, Color color);
        }

        public class Triangle : Figure
        {
            public Triangle(int size, Color color) : base(size, color) { }

            public override void Draw(Graphics graphics, int x, int y, int width, Color color)
            {
                Pen pen = new Pen(color);
                graphics.DrawPolygon(pen, GetTrianglePoints(x, y, width));
            }

            private Point[] GetTrianglePoints(int x, int y, int width)
            {
                int halfWidth = width / 2;
                int height = (int)(width * 0.75); // Adjust the height

                Point[] points = new Point[5];
                points[0] = new Point(x + halfWidth, y);
                points[1] = new Point(x + width, y + height);
                points[2] = new Point(x + width / 2, y + height);
                points[3] = new Point(x, y + height);
                points[4] = new Point(x + halfWidth, y);

                return points;
            }
        }

        public class Square : Figure
        {
            public Square(int size, Color color) : base(size, color) { }

            public override void Draw(Graphics graphics, int x, int y, int width, Color color)
            {
                Pen pen = new Pen(color);
                graphics.DrawPolygon(pen, GetSquarePoints(x, y, width));
            }

            private Point[] GetSquarePoints(int x, int y, int width)
            {
                Point[] points = new Point[4];
                points[0] = new Point(x, y);
                points[1] = new Point(x + width, y); 
                points[2] = new Point(x + width, y + width); 
                points[3] = new Point(x, y + width);

                return points;
            }
        }

        public class Pentagon : Figure
        {
            public Pentagon(int size, Color color) : base(size, color) { }

            public override void Draw(Graphics graphics, int x, int y, int width, Color color)
            {
                Pen pen = new Pen(color);
                graphics.DrawPolygon(pen, GetPentagonPoints(x, y, width));
            }

            private Point[] GetPentagonPoints(int x, int y, int width)
            {
                Point[] points = new Point[5];

                // Calculate the height of the pentagon based on the width
                int height = (int)(width / (2 * Math.Tan(Math.PI / 5)));

                // Calculate the coordinates of the five points
                points[0] = new Point(x, y - height);
                points[1] = new Point(x + width, y - height);
                points[2] = new Point(x + width + width / 2, y);
                points[3] = new Point(x + width, y + height);
                points[4] = new Point(x, y + height);

                return points;
            }
        }

        public class Rectangle : Figure
        {
            protected int height;
            public Rectangle(int size, int height, Color color) : base(size, color)
            {
                this.height = height;
            }

            public override void Draw(Graphics graphics, int x, int y, int size, Color color)
            {
                Pen pen = new Pen(color);
                graphics.DrawPolygon(pen, GetRectanglePoints(x, y, size, height));
            }
            private Point[] GetRectanglePoints(int x, int y, int width, int height)
            {
                Point[] points = new Point[4];

                points[0] = new Point(x, y);
                points[1] = new Point(x + width, y);
                points[2] = new Point(x + width, y + height);
                points[3] = new Point(x, y + height);

                return points;
            }
            public int GetHeight()
            {
                return height;
            }
        }

        public class Rhomb : Figure
        {
            protected int diagonal2;
            public Rhomb(int diagonal1, int diagonal2, Color color) : base(diagonal1, color)
            {
                this.diagonal2 = diagonal2;
            }

            public override void Draw(Graphics graphics, int x, int y, int diagonal1, Color color)
            {
                Pen pen = new Pen(color);
                graphics.DrawPolygon(pen, GetRhombPoints(x, y, diagonal1, diagonal2));
            }
            private Point[] GetRhombPoints(int x, int y, int diagonal1, int diagonal2)
            {
                Point[] points = new Point[4];

                double halfDiagonal1 = diagonal1 / 2.0;
                double halfDiagonal2 = diagonal2 / 2.0;

                points[0] = new Point(x, y - (int)halfDiagonal1);
                points[1] = new Point(x + (int)halfDiagonal2, y);
                points[2] = new Point(x, y + (int)halfDiagonal1);
                points[3] = new Point(x - (int)halfDiagonal2, y);

                return points;
            }
            public int GetDiagonal()
            {
                return diagonal2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = pictureBox1.CreateGraphics())
            {
                foreach (Figure figure in figures)
                {
                    // Calculate random x and y positions within the bounds of the picture box
                    int x = random.Next(pictureBox1.Width - figure.GetSize());
                    int y = random.Next(pictureBox1.Height - figure.GetSize());

                    Color color = Color.FromName(((Form3)this).comboBox1.SelectedItem.ToString());

                    if (figure is Triangle triangle)
                    {
                        int triangleSize = triangle.GetSize();
                        figure.Draw(graphics, x, y, triangleSize, figure.Color);
                    }
                    else if (figure is Pentagon pentagon)
                    {
                        int pentagonSize = pentagon.GetSize();
                        figure.Draw(graphics, x, y, pentagonSize, figure.Color);
                    }
                    else if (figure is Rectangle rectangle)
                    {
                        int rectangleWidth = rectangle.GetSize();
                        //int rectangleHeight = rectangle.GetHeight();
                        figure.Draw(graphics, x, y, rectangleWidth, figure.Color);
                    }
                    else if (figure is Rhomb rhomb)
                    {
                        int rhombDiagonal1 = rhomb.GetSize();
                        figure.Draw(graphics, x, y, rhombDiagonal1, figure.Color);
                    }
                    else
                    {
                        // Draw other types of figures using their respective sizes
                        figure.Draw(graphics, x, y, figure.GetSize(), color);
                    }
                }

                // Clear the figures array
                figures.Clear();
                // Clear list box
                //listBox1.Items.Clear();
            }
        }

        public class FigureListItem
        {
            public string FigureName { get; set; }
            public string ColorName { get; set; }
            public int Size1 { get; set; }

            public override string ToString()
            {
                return $"{FigureName} - Color: {ColorName}, Size1: {Size1}";
            }
        }
        public class FigureListItemCoupleParams : FigureListItem
        {
            public int Size2 { get; set; }
            public override string ToString()
            {
                return base.ToString() + $", Size2: {Size2}";
            }
        }

        private void UpdateFigureListBox() // this method shows actual figures list 
        {
            listBox1.Items.Clear();

            foreach (Figure figure in figures)
            {
                if (radioButton3.Checked || radioButton1.Checked) // or pentagon checked
                {
                    FigureListItem item = new FigureListItem
                    {
                        FigureName = figure.GetType().Name,
                        ColorName = figure.Color.Name,
                        Size1 = figure.GetSize(),
                    };

                    listBox1.Items.Add(item);
                }
                else if (radioButton4.Checked)
                {
                    if (figure is Rhomb)
                    {
                        //Rhomb rhomb = new Rhomb();
                        FigureListItemCoupleParams item = new FigureListItemCoupleParams
                        {
                            FigureName = figure.GetType().Name,
                            ColorName = figure.Color.Name,
                            Size1 = figure.GetSize(),
                            //Size2 = rhomb.GetDiagonal()
                        };

                        listBox1.Items.Add(item);
                    }
                }
                else
                {
                    //Rectangle rect = new Rectangle(); // Provide the required arguments
                    if (figure is Pentagon || figure is Square)
                    {
                        //Pentagon pentagon = new Pentagon();
                        FigureListItemCoupleParams item = new FigureListItemCoupleParams
                        {
                            FigureName = figure.GetType().Name,
                            ColorName = figure.Color.Name,
                            Size1 = figure.GetSize(),
                            //Size2 = pentagon.GetHeight()
                        };

                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh(); // refresh picture box
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // close the form
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFigureListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}