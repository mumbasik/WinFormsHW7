using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.minusToolStripMenuItem.Click += new System.EventHandler(this.minusToolStripMenuItem_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void enterNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int number;
            int number2;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Please enter 2 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (!int.TryParse(textBox1.Text, out number) || !int.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Wrong symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show($"{textBox1.Text} + {textBox2.Text} = {number + number2}");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int number;
            int number2;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Please enter 2 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (!int.TryParse(textBox1.Text, out number) || !int.TryParse(textBox2.Text, out number2))
            {
                MessageBox.Show("Wrong symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show($"{textBox1.Text} - {textBox2.Text} = {number - number2}");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            minusToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            plusToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem_Click(sender, e);
        }
    }
}
