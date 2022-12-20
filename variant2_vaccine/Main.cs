using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vaccines
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[^0-9][6-9a-z]{4,7}$"))
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[0-9a-zA-Z]{3}[?]$"))
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Green)
            {
                PacientInfo pacient = new PacientInfo();
                pacient.ShowDialog();
            }
        }
    }
}
