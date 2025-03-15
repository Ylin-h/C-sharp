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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard user = new DashBoard();
            user.Show();
            this.Hide();
        }
        int key = 0;
        SqlConnection conn = new SqlConnection("Server=localhost;Database=test;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            if (textBox1.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            else
            {
                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Book values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox1.SelectedItem.ToString() + "'," + textBox3.Text + ", " + textBox4.Text + ")", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("书籍添加成功！");
                    reset();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void populate()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Book", conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            populate();
            comboBox2.SelectedIndex = -1;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update Book set BTitle='" + textBox1.Text + "', BAuthor='" + textBox2.Text + "', BCat='" + comboBox1.SelectedItem.ToString() + "', BQty=" + textBox3.Text + ",BPrice=" + textBox4.Text + " where BID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("编辑成功！");
                    reset();
                    populate();
                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            else
            {
                DialogResult result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("delete from Book where BID=" + key + "", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("删除成功！");
                        reset();
                        populate();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
            reset();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (comboBox2.SelectedIndex == -1)
                    return;
                else
                {
                conn.Open();
                string query = "select * from Book where BCat='" + comboBox2.SelectedItem.ToString() + "' ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
                }
               
                
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
