namespace WinFormsApp1
{
    partial class User
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(414, 462);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1681, 846);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.ForeColor = Color.LimeGreen;
            label8.Location = new Point(1114, 374);
            label8.Name = "label8";
            label8.Size = new Size(168, 48);
            label8.TabIndex = 41;
            label8.Text = "用户列表";
            // 
            // button9
            // 
            button9.BackColor = Color.ForestGreen;
            button9.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button9.Location = new Point(1573, 287);
            button9.Name = "button9";
            button9.Size = new Size(150, 62);
            button9.TabIndex = 40;
            button9.Text = "重置";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.ForestGreen;
            button8.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button8.Location = new Point(1278, 287);
            button8.Name = "button8";
            button8.Size = new Size(150, 62);
            button8.TabIndex = 39;
            button8.Text = "删除";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.ForestGreen;
            button7.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button7.Location = new Point(947, 287);
            button7.Name = "button7";
            button7.Size = new Size(150, 62);
            button7.TabIndex = 38;
            button7.Text = "编辑";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button6.Location = new Point(646, 287);
            button6.Name = "button6";
            button6.Size = new Size(150, 62);
            button6.TabIndex = 37;
            button6.Text = "保存";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("SimSun", 10.5F);
            textBox4.Location = new Point(1653, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 39);
            textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("SimSun", 10.5F);
            textBox3.Location = new Point(1228, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 39);
            textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("SimSun", 10.5F);
            textBox2.Location = new Point(817, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 39);
            textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 10.5F);
            textBox1.Location = new Point(432, 205);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(278, 39);
            textBox1.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Microsoft YaHei UI", 13.875F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(1653, 134);
            label7.Name = "label7";
            label7.Size = new Size(94, 48);
            label7.TabIndex = 31;
            label7.Text = "密码";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft YaHei UI", 13.875F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(817, 134);
            label5.Name = "label5";
            label5.Size = new Size(168, 48);
            label5.TabIndex = 29;
            label5.Text = "电话号码";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 13.875F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(1228, 134);
            label4.Name = "label4";
            label4.Size = new Size(94, 48);
            label4.TabIndex = 28;
            label4.Text = "地址";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(432, 134);
            label3.Name = "label3";
            label3.Size = new Size(131, 48);
            label3.TabIndex = 27;
            label3.Text = "用户名";
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button5.Location = new Point(2043, 15);
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
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button4.ForeColor = Color.FromArgb(224, 224, 224);
            button4.Location = new Point(59, 384);
            button4.Name = "button4";
            button4.Size = new Size(269, 46);
            button4.TabIndex = 3;
            button4.Text = "用户";
            button4.UseVisualStyleBackColor = false;
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
            button1.BackColor = Color.Black;
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
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(7, -16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 1324);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(1080, 22);
            label1.Name = "label1";
            label1.Size = new Size(240, 57);
            label1.TabIndex = 24;
            label1.Text = "哈吉米书店";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UId";
            dataGridViewCellStyle3.BackColor = Color.Blue;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.HeaderText = "编号";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UName";
            Column2.HeaderText = "用户名";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "UPhone";
            Column3.HeaderText = "电话号码";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "UAdd";
            Column4.HeaderText = "地址";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "UPassword";
            Column5.HeaderText = "密码";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2102, 1307);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label8;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button5;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}