using System.Data;
using System.Data.SqlClient;
using System.Timers;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string UserName = "";
        SqlConnection con = new SqlConnection("Server=localhost;Database=test;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from users where UName='" + textBox1.Text + "' and UPassword='" + textBox2.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    DataTable dt1 = dt.Tables[0];
                                   
                    if (dt1.Rows.Count > 0)
                    {
                        DataRow dr = dt1.Rows[0];
                        UserName = dr["UName"].ToString();
                        MessageBox.Show("登录成功！");
                        Bill form2 = new Bill();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 5;
            progressBar1.Value = count;
            label6.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                label7.Text = "加载成功！";
                timer1.Stop();
            }

        }   
        private void label4_Click(object sender, EventArgs e)
        {  
            Admin form3 = new Admin();
            form3.Show();
            this.Hide();
        }
    }
}
