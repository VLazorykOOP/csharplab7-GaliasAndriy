using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            // Initialize PictureBox
            pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };

            // Initialize Buttons
            btnOpen = new Button
            {
                Text = "Open Image",
                Dock = DockStyle.Top
            };
            btnSave = new Button
            {
                Text = "Save Image",
                Dock = DockStyle.Top
            };

            // Subscribe to the Click event of the buttons
            btnOpen.Click += BtnOpen_Click;
            btnSave.Click += BtnSave_Click;

            // Add the controls to the form
            Controls.Add(pictureBox);
            Controls.Add(btnSave); 
            Controls.Add(btnOpen);

            // Set the form's properties
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(800, 600);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.bmp, *.png)|*.jpg;*.jpeg;*.jpe;*.gif;*.bmp;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image originalImage = Image.FromFile(openFileDialog.FileName);
                    Image mirroredImage = CreateMirroredImage(originalImage);
                    pictureBox.Image = mirroredImage;
                }
            }
        }

        private Image CreateMirroredImage(Image originalImage)
        {
            Bitmap mirroredImage = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(mirroredImage))
            {
                g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                    new Rectangle(originalImage.Width, 0, -originalImage.Width, originalImage.Height), GraphicsUnit.Pixel);
            }
            return mirroredImage;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.bmp, *.png)|*.jpg;*.jpeg;*.jpe;*.gif;*.bmp;*.png";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image.Save(saveFileDialog.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}