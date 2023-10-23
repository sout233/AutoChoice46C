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
    public partial class Cong : Form
    {
        public string name;

        public Cong()
        {
            InitializeComponent();
        }

        private void Cong_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.Text = name;
            label1.Location = new Point(label1.Location.X, label1.Location.Y);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
