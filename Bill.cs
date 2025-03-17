using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            show();
        }
        SqlConnection conn = new SqlConnection("Server=localhost;Database=test;Integrated Security=True");

        private void show()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Book", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox4.Text = 1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            label6.Text =Login.UserName;
        }
        static int price1 = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择书籍！");
                return;
            }
            else
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();

                }
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Bill values('" + Login.UserName + "'," + price1 + ")", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("下单成功！");
                    conn.Close();
                    label9.Text = "￥0元";
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
        void reset()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            reset();
        }
        void minus()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Book set BQty=BQty-" + textBox4.Text + "where BId='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'and BQty>0", conn);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("减少成功！");
                //show();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
        int nums = 0, sum = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox4.Text != "0")
            {
                if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["num"].Value.ToString()) >= 1)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dataGridView2);
                    dr.Cells[0].Value = ++nums;
                    dr.Cells[1].Value = textBox1.Text;
                    dr.Cells[2].Value = textBox3.Text;
                    dr.Cells[3].Value = textBox4.Text;
                    dr.Cells[4].Value = (Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox3.Text)).ToString();
                    dataGridView2.Rows.Add(dr);
                    minus();
                    reset();
                    show();
                    sum += Convert.ToInt32(dataGridView2.Rows[nums - 1].Cells[4].Value.ToString());
                    label9.Text = "￥" + sum.ToString() + "元";
                }
                else
                {
                    MessageBox.Show("库存不足！");
                }
            }
            else
            {
                MessageBox.Show("请选择书籍！");
            }
            price1 = sum;
        }
        int prodId, prodQty, prodPrice,tottal, pos = 60;
        string prodName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("哈吉米书店购物清单", new Font("黑体", 20, FontStyle.Bold), Brushes.Black, new Point(10));
            e.Graphics.DrawString("编号  产品  价格  数量  总计", new Font("宋体", 12, FontStyle.Bold), Brushes.Black, new Point(20, 40));
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                prodId = Convert.ToInt32(row.Cells["id"].Value);
                prodName = ""+row.Cells["bookname"].Value;
                prodPrice = Convert.ToInt32(row.Cells["value"].Value);
                prodQty = Convert.ToInt32(row.Cells["count"].Value);
                tottal = Convert.ToInt32(row.Cells["total"].Value);
                e.Graphics.DrawString("" + prodId, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodName, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(80, pos));
                e.Graphics.DrawString("" + prodPrice, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(130, pos));
                e.Graphics.DrawString("" + prodQty, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(180, pos));
                e.Graphics.DrawString("" + tottal, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(240, pos));
                pos += 20;
            }
            e.Graphics.DrawString("订单总计：￥" + sum.ToString() + "元", new Font("幼圆", 12, FontStyle.Bold), Brushes.Crimson, new PointF(60, pos+50));
            e.Graphics.DrawString("**********哈吉米书店**********", new Font("幼圆", 12, FontStyle.Bold), Brushes.Crimson, new PointF(15, pos + 80));
            dataGridView2.Rows.Clear();
            sum = 0;    
            dataGridView2.Refresh();
            pos = 60;
        }
    }
}
