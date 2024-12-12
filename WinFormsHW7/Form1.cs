using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsHW7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

            Dictionary<string, Color> colors = new Dictionary<string, Color>()
            {
                { "Red", Color.Red },
                { "Green", Color.Green },
                { "Blue", Color.Blue }
            };

            if (colors.ContainsKey(toolStripComboBox1.Text))
            {
                this.BackColor = colors[toolStripComboBox1.Text];
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("The data has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }


        private void MainForm_KeyDown(object sender, EventArgs e)
        {

        }







        private void toolStripTextBox1_Click_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Label text = new Label();
                text.Text = toolStripTextBox1.Text;
                MessageBox.Show($"{text.Text}");
                toolStripTextBox1.Text = string.Empty;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The data has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
