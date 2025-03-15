namespace WinFormsApp1
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            button10 = new Button();
            dataGridView1 = new DataGridView();
            Bid = new DataGridViewTextBoxColumn();
            ff = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Btype = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            num = new DataGridViewTextBoxColumn();
            label8 = new Label();
            button9 = new Button();
            button6 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            label2 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            bookname = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            count = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label9 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button10
            // 
            button10.BackColor = Color.ForestGreen;
            button10.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button10.Location = new Point(1596, 1129);
            button10.Name = "button10";
            button10.Size = new Size(216, 99);
            button10.TabIndex = 43;
            button10.Text = "结算";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Bid, ff, Author, Btype, price, num });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(405, 504);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(821, 804);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Bid
            // 
            Bid.DataPropertyName = "BId";
            Bid.HeaderText = "编号";
            Bid.MinimumWidth = 10;
            Bid.Name = "Bid";
            Bid.ReadOnly = true;
            // 
            // ff
            // 
            ff.DataPropertyName = "BTitle";
            ff.HeaderText = "书籍名称";
            ff.MinimumWidth = 10;
            ff.Name = "ff";
            ff.ReadOnly = true;
            // 
            // Author
            // 
            Author.DataPropertyName = "BAuthor";
            Author.HeaderText = "作者";
            Author.MinimumWidth = 10;
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Btype
            // 
            Btype.DataPropertyName = "BCat";
            Btype.HeaderText = "书籍类型";
            Btype.MinimumWidth = 10;
            Btype.Name = "Btype";
            Btype.ReadOnly = true;
            // 
            // price
            // 
            price.DataPropertyName = "BPrice";
            price.HeaderText = "价格";
            price.MinimumWidth = 10;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // num
            // 
            num.DataPropertyName = "BQty";
            num.HeaderText = "数量";
            num.MinimumWidth = 10;
            num.Name = "num";
            num.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.ForeColor = Color.LimeGreen;
            label8.Location = new Point(721, 429);
            label8.Name = "label8";
            label8.Size = new Size(168, 48);
            label8.TabIndex = 41;
            label8.Text = "书籍列表";
            // 
            // button9
            // 
            button9.BackColor = Color.ForestGreen;
            button9.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button9.Location = new Point(834, 287);
            button9.Name = "button9";
            button9.Size = new Size(150, 62);
            button9.TabIndex = 40;
            button9.Text = "重置";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button6.Location = new Point(491, 287);
            button6.Name = "button6";
            button6.Size = new Size(224, 62);
            button6.TabIndex = 37;
            button6.Text = "加入购物车";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("SimSun", 10.5F);
            textBox4.Location = new Point(947, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 39);
            textBox4.TabIndex = 35;
            textBox4.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("SimSun", 10.5F);
            textBox3.Location = new Point(721, 205);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(170, 39);
            textBox3.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 10.5F);
            textBox1.Location = new Point(432, 205);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(223, 39);
            textBox1.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Microsoft YaHei UI", 13.875F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(721, 134);
            label7.Name = "label7";
            label7.Size = new Size(94, 48);
            label7.TabIndex = 31;
            label7.Text = "价格";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 13.875F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(947, 134);
            label4.Name = "label4";
            label4.Size = new Size(94, 48);
            label4.TabIndex = 28;
            label4.Text = "数量";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(432, 134);
            label3.Name = "label3";
            label3.Size = new Size(168, 48);
            label3.TabIndex = 27;
            label3.Text = "书籍名称";
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button5.Location = new Point(2043, 12);
            button5.Name = "button5";
            button5.Size = new Size(52, 57);
            button5.TabIndex = 26;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(128, 68);
            label2.Name = "label2";
            label2.Size = new Size(131, 48);
            label2.TabIndex = 5;
            label2.Text = "哈吉米";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button3.ForeColor = Color.FromArgb(224, 224, 224);
            button3.Location = new Point(59, 1149);
            button3.Name = "button3";
            button3.Size = new Size(269, 46);
            button3.TabIndex = 2;
            button3.Text = "退出";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(7, -20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 1328);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(986, 22);
            label1.Name = "label1";
            label1.Size = new Size(240, 57);
            label1.TabIndex = 24;
            label1.Text = "哈吉米书店";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { id, bookname, value, count, total });
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(1227, 150);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 82;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 0, 192);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(874, 519);
            dataGridView2.TabIndex = 44;
            // 
            // id
            // 
            id.HeaderText = "订单号";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // bookname
            // 
            bookname.HeaderText = "书名";
            bookname.MinimumWidth = 10;
            bookname.Name = "bookname";
            bookname.ReadOnly = true;
            // 
            // value
            // 
            value.HeaderText = "单价";
            value.MinimumWidth = 10;
            value.Name = "value";
            value.ReadOnly = true;
            // 
            // count
            // 
            count.HeaderText = "数量";
            count.MinimumWidth = 10;
            count.Name = "count";
            count.ReadOnly = true;
            // 
            // total
            // 
            total.HeaderText = "金额";
            total.MinimumWidth = 10;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(1596, 69);
            label5.Name = "label5";
            label5.Size = new Size(168, 48);
            label5.TabIndex = 45;
            label5.Text = "购物清单";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(1606, 1046);
            label9.Name = "label9";
            label9.Size = new Size(197, 57);
            label9.TabIndex = 47;
            label9.Text = "订单金额";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(405, 5);
            label6.Name = "label6";
            label6.Size = new Size(111, 57);
            label6.TabIndex = 48;
            label6.Text = "用户";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2102, 1307);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(button10);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill";
            Text = "Bill";
            Load += Bill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button10;
        private DataGridView dataGridView1;
        private Label label8;
        private Button button9;
        private Button button6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label7;
        private Label label4;
        private Label label3;
        private Button button5;
        private Label label2;
        private Button button3;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label9;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn bookname;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn Bid;
        private DataGridViewTextBoxColumn ff;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Btype;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn num;
        private Label label6;
    }
}