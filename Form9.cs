using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runner1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form10().ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form11().ShowDialog();
            this.Show();
        }
    }
}
