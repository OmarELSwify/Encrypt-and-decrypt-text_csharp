using System;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Encoding.Unicode.GetString(Convert.FromBase64String(textBox2.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
