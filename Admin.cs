using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        String pass = "123456";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("请输入密码！");
            }
            else if(textBox1.Text != pass)
            {
                MessageBox.Show("密码错误！");
            }
            else
            {
                MessageBox.Show("登陆成功！");
                Books books = new Books();
                this.Hide();
                books.Show();
            }
   
        }
    }
}
