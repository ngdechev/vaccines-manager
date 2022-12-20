using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vaccines
{
    public partial class PacientInfo : Form
    {
        public PacientInfo()
        {
            InitializeComponent();
        }

        DateTime b;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[\u0410-\u042F]{1}[\u0430-\u044F]+$"))
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[\u0410-\u042F]{1}[\u0430-\u044F]+$"))
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^[0-9]{10}$"))
            {
                textBox3.BackColor = Color.Green;
                DateTime zeroTime = new DateTime(1, 1, 1);
                int month = System.Convert.ToInt32(textBox3.Text.Substring(2, 2)),
                years, days;
                years = System.Convert.ToInt32(textBox3.Text.Substring(0, 2));
                days = System.Convert.ToInt32(textBox3.Text.Substring(4, 2));

                if (month > 12)
                {
                    b = new DateTime(2000 + years, month - 40, days);
                }
                else
                {
                    b = new DateTime(1900 + years, month, days);
                }

                TimeSpan span = DateTime.Now - b;
                textBox4.Text = ((zeroTime + span).Year - 1).ToString();
                dateTimePicker1.Value = b;

                if (System.Convert.ToInt32(textBox3.Text.Substring(8, 1)) % 2 == 0)
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Green && textBox3.BackColor == Color.Green)
            {
                Vaccines f3 = new Vaccines(System.Convert.ToInt32(textBox4.Text), textBox1.Text, textBox2.Text, textBox3.Text);
                f3.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilities.ClearAllControls(this);
        }
    }
}
