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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Text = (int.Parse(textBox8.Text) + 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox8.Text = (int.Parse(textBox8.Text) - 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
                if ((string)t.Tag == t.Text) t.Text = "";
            t.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
                if ((string)t.Tag == t.Text) t.Text = "";
            t.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
                if ((string)t.Tag == t.Text) t.Text = "";
            t.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
                if ((string)t.Tag == t.Text) t.Text = "";
            t.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
                if ((string)t.Tag == t.Text) t.Text = "";
            t.ForeColor = Color.Black;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
                if ((string)t.Tag == t.Text) t.Text = "";
            t.ForeColor = Color.Black;
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
            }
            else
                if ((string)t.Tag == t.Text) t.Text = "";
            t.ForeColor = Color.Black;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.Text = (string)t.Tag;
                t.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form7().ShowDialog();
            this.Show();
        }
    }
}
