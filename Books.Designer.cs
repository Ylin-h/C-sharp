namespace WinFormsApp1
{
    partial class Books
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Bid = new DataGridViewTextBoxColumn();
            Bname = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Btype = new DataGridViewTextBoxColumn();
            num = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            button10 = new Button();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(1085, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 57);
            label1.TabIndex = 0;
            label1.Text = "哈吉米书店";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, -14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 1309);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
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
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button4.ForeColor = Color.FromArgb(224, 224, 224);
            button4.Location = new Point(59, 384);
            button4.Name = "button4";
            button4.Size = new Size(269, 46);
            button4.TabIndex = 3;
            button4.Text = "用户";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button3.ForeColor = Color.FromArgb(224, 224, 224);
            button3.Location = new Point(59, 677);
            button3.Name = "button3";
            button3.Size = new Size(269, 46);
            button3.TabIndex = 2;
            button3.Text = "退出";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button2.ForeColor = Color.FromArgb(224, 224, 224);
            button2.Location = new Point(59, 536);
            button2.Name = "button2";
            button2.Size = new Size(269, 46);
            button2.TabIndex = 1;
            button2.Text = "账户管理";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(59, 247);
            button1.Name = "button1";
            button1.Size = new Size(269, 46);
            button1.TabIndex = 0;
            button1.Text = "书籍";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button5.Location = new Point(2048, 2);
            button5.Name = "button5";
            button5.Size = new Size(52, 57);
            button5.TabIndex = 4;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(437, 121);
            label3.Name = "label3";
            label3.Size = new Size(168, 48);
            label3.TabIndex = 5;
            label3.Text = "书籍名称";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 13.875F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(1423, 121);
            label4.Name = "label4";
            label4.Size = new Size(94, 48);
            label4.TabIndex = 6;
            label4.Text = "数量";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft YaHei UI", 13.875F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(774, 121);
            label5.Name = "label5";
            label5.Size = new Size(94, 48);
            label5.TabIndex = 7;
            label5.Text = "作者";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Microsoft YaHei UI", 13.875F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(1083, 121);
            label6.Name = "label6";
            label6.Size = new Size(168, 48);
            label6.TabIndex = 8;
            label6.Text = "书籍类型";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Microsoft YaHei UI", 13.875F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(1706, 121);
            label7.Name = "label7";
            label7.Size = new Size(94, 48);
            label7.TabIndex = 9;
            label7.Text = "价格";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 10.5F);
            textBox1.Location = new Point(437, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 39);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("SimSun", 10.5F);
            textBox2.Location = new Point(774, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 39);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("SimSun", 10.5F);
            textBox3.Location = new Point(1423, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 39);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("SimSun", 10.5F);
            textBox4.Location = new Point(1706, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 39);
            textBox4.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("SimSun", 10.5F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "儿童读物", "文学艺术", "人文历史", "生活美食", "经济管理", "科学技术" });
            comboBox1.Location = new Point(1083, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 36);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "全部分类";
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button6.Location = new Point(651, 274);
            button6.Name = "button6";
            button6.Size = new Size(150, 62);
            button6.TabIndex = 15;
            button6.Text = "保存";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.ForestGreen;
            button7.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button7.Location = new Point(952, 274);
            button7.Name = "button7";
            button7.Size = new Size(150, 62);
            button7.TabIndex = 16;
            button7.Text = "编辑";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.ForestGreen;
            button8.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button8.Location = new Point(1283, 274);
            button8.Name = "button8";
            button8.Size = new Size(150, 62);
            button8.TabIndex = 17;
            button8.Text = "删除";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.ForestGreen;
            button9.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button9.Location = new Point(1578, 274);
            button9.Name = "button9";
            button9.Size = new Size(150, 62);
            button9.TabIndex = 18;
            button9.Text = "重置";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.ForeColor = Color.LimeGreen;
            label8.Location = new Point(1119, 361);
            label8.Name = "label8";
            label8.Size = new Size(168, 48);
            label8.TabIndex = 19;
            label8.Text = "书籍列表";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.BlueViolet;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Bid, Bname, Author, Btype, num, price });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(409, 533);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle6.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 192, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1681, 756);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Bid
            // 
            Bid.DataPropertyName = "BId";
            dataGridViewCellStyle3.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Yellow;
            Bid.DefaultCellStyle = dataGridViewCellStyle3;
            Bid.HeaderText = "编号";
            Bid.MinimumWidth = 10;
            Bid.Name = "Bid";
            Bid.ReadOnly = true;
            // 
            // Bname
            // 
            Bname.DataPropertyName = "BTitle";
            Bname.HeaderText = "书籍名称";
            Bname.MinimumWidth = 10;
            Bname.Name = "Bname";
            Bname.ReadOnly = true;
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
            // num
            // 
            num.DataPropertyName = "BQty";
            num.HeaderText = "数量";
            num.MinimumWidth = 10;
            num.Name = "num";
            num.ReadOnly = true;
            // 
            // price
            // 
            price.DataPropertyName = "BPrice";
            price.HeaderText = "价格";
            price.MinimumWidth = 10;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // button10
            // 
            button10.BackColor = Color.ForestGreen;
            button10.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button10.Location = new Point(1367, 417);
            button10.Name = "button10";
            button10.Size = new Size(117, 64);
            button10.TabIndex = 21;
            button10.Text = "刷新";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("SimSun", 10.5F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "儿童读物", "文学艺术", "人文历史", "生活美食", "经济管理", "科学技术" });
            comboBox2.Location = new Point(1085, 445);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 36);
            comboBox2.TabIndex = 22;
            comboBox2.Text = "选择分类";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2102, 1307);
            Controls.Add(comboBox2);
            Controls.Add(button10);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button10;
        private DataGridViewTextBoxColumn Bid;
        private DataGridViewTextBoxColumn Bname;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Btype;
        private DataGridViewTextBoxColumn num;
        private DataGridViewTextBoxColumn price;
        private ComboBox comboBox2;
    }
}