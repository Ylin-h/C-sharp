using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            getBooks();
            getUsers();
            getTotal();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }
        SqlConnection con = new SqlConnection("Server=Localhost;Database=test;Integrated Security=True");
        void getBooks()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select sum(BQty) from Book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label3.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void getTotal()
        {
            try
            { 
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select sum(Amount) from Bill", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label5.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }
        void getUsers()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from users", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label4.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getBooks();
            getUsers();
            getTotal();
        }
    }
}
