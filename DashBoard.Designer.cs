namespace WinFormsApp1
{
    partial class DashBoard
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
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            button2.BackColor = Color.FromArgb(0, 192, 0);
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
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Underline, GraphicsUnit.Point, 134);
            button5.Location = new Point(2043, 15);
            button5.Name = "button5";
            button5.Size = new Size(52, 57);
            button5.TabIndex = 45;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(7, -17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 1325);
            groupBox1.TabIndex = 44;
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
            label1.TabIndex = 43;
            label1.Text = "哈吉米书店";
            // 
            // button6
            // 
            button6.BackColor = Color.Green;
            button6.Enabled = false;
            button6.Font = new Font("Microsoft YaHei UI", 22.125F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(705, 246);
            button6.Name = "button6";
            button6.Size = new Size(355, 187);
            button6.TabIndex = 46;
            button6.Text = "书籍库存\r\n数量";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 192, 192);
            button7.Font = new Font("Microsoft YaHei UI", 22.125F, FontStyle.Bold);
            button7.Location = new Point(1080, 588);
            button7.Name = "button7";
            button7.Size = new Size(321, 174);
            button7.TabIndex = 47;
            button7.Text = "总用户数人数";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Yellow;
            button8.Font = new Font("Microsoft YaHei UI", 22.125F, FontStyle.Bold);
            button8.Location = new Point(1421, 242);
            button8.Name = "button8";
            button8.Size = new Size(331, 187);
            button8.TabIndex = 48;
            button8.Text = "总销售额金额";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(853, 466);
            label3.Name = "label3";
            label3.Size = new Size(52, 57);
            label3.TabIndex = 49;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 134);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(1212, 785);
            label4.Name = "label4";
            label4.Size = new Size(52, 57);
            label4.TabIndex = 50;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 134);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(1555, 466);
            label5.Name = "label5";
            label5.Size = new Size(52, 57);
            label5.TabIndex = 51;
            label5.Text = "0";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2102, 1307);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private GroupBox groupBox1;
        private Label label1;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}