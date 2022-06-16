using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
            textUserName.Focus();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                if (textUserName.Text == "reza" && textPassword.Text == "123")
                {
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("the username of password you entered in incorrect, try again");
                    textUserName.Clear();
                    textPassword.Clear();
                    textUserName.Focus();
                }
            }
        }
    }
}

