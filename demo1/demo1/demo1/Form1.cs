using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace demo1
{
    public partial class Form1 : Form
    {
        private static System.Diagnostics.Process p;

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "root" && password == "123456")
            {
                MessageBox.Show("Login Success！");
                Form2 form2 = new Form2();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Login Failed！");
            }
            //textBox2.Text = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p == null)
            {
                p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "mspaint.exe";
                p.Start();
            }
            else
            {
                if (p.HasExited) //是否正在运行
                {
                    p.Start();
                }
            }
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
        }
    }
}
