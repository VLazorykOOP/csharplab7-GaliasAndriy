using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        private static List<Form1> openForms = new List<Form1>();

        public Form1()
        {
            InitializeComponent();
            openForms.Add(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void ButtonDuplicate_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
                {
                    openForms.Remove(this);
                    if (openForms.Count == 0)
                    {
                        Application.Exit();
                    }
                }*/

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            openForms.Remove(this);

            if (openForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
