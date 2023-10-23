using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoChoice46C
{
    public partial class Password : Form
    {
        private string _password;

        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] hiragana = { "あ", "い", "う", "え", "お", "か", "し", "そ", "ぬ" };

            string password = "";
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(hiragana.Length);
                password += hiragana[index];
            }

            Dictionary<string, string> romanMap = new Dictionary<string, string>();
            romanMap.Add("あ", "a");
            romanMap.Add("い", "i");
            romanMap.Add("う", "u");
            romanMap.Add("え", "e");
            romanMap.Add("お", "o");
            romanMap.Add("か", "ka");
            romanMap.Add("し", "shi");
            romanMap.Add("そ", "so");
            romanMap.Add("ぬ", "nu");



            string romanPassword = "";
            foreach (char c in password)
            {
                if (romanMap.ContainsKey(c.ToString()))
                {
                    romanPassword += romanMap[c.ToString()];
                }
            }

            label2.Text = romanPassword;
            _password = password;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == _password)
            {
                Form1 form1 = ((Form1)this.Owner);
                form1.panel1.Visible = true;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "あ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "い";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "う";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "え";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "お";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "か";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "し";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "そ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ぬ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
        }
    }
}
