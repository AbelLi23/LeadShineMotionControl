namespace 例10_在线变速和改变目标位置
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.S_Tacc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dist_pos = new System.Windows.Forms.TextBox();
            this.Tacc = new System.Windows.Forms.TextBox();
            this.Max_speed = new System.Windows.Forms.TextBox();
            this.Start_speed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.S_Type = new System.Windows.Forms.RadioButton();
            this.T_Type = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CCW = new System.Windows.Forms.RadioButton();
            this.CW = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Axis_U = new System.Windows.Forms.RadioButton();
            this.Axis_Z = new System.Windows.Forms.RadioButton();
            this.Axis_Y = new System.Windows.Forms.RadioButton();
            this.Axis_X = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.S_Tacc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Dist_pos);
            this.groupBox1.Controls.Add(this.Tacc);
            this.groupBox1.Controls.Add(this.Max_speed);
            this.groupBox1.Controls.Add(this.Start_speed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 21);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "10000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 21);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "5000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "改变终点位置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "改变速度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "S段时间：";
            // 
            // S_Tacc
            // 
            this.S_Tacc.Location = new System.Drawing.Point(88, 142);
            this.S_Tacc.Name = "S_Tacc";
            this.S_Tacc.Size = new System.Drawing.Size(73, 21);
            this.S_Tacc.TabIndex = 28;
            this.S_Tacc.Text = "0.05";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "定长位移：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "加速时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "运行速度：";
            // 
            // Dist_pos
            // 
            this.Dist_pos.Location = new System.Drawing.Point(88, 173);
            this.Dist_pos.Name = "Dist_pos";
            this.Dist_pos.Size = new System.Drawing.Size(73, 21);
            this.Dist_pos.TabIndex = 22;
            this.Dist_pos.Text = "5000";
            // 
            // Tacc
            // 
            this.Tacc.Location = new System.Drawing.Point(88, 103);
            this.Tacc.Name = "Tacc";
            this.Tacc.Size = new System.Drawing.Size(73, 21);
            this.Tacc.TabIndex = 23;
            this.Tacc.Text = "0.1";
            // 
            // Max_speed
            // 
            this.Max_speed.Location = new System.Drawing.Point(88, 67);
            this.Max_speed.Name = "Max_speed";
            this.Max_speed.Size = new System.Drawing.Size(73, 21);
            this.Max_speed.TabIndex = 24;
            this.Max_speed.Text = "2000";
            // 
            // Start_speed
            // 
            this.Start_speed.Location = new System.Drawing.Point(88, 30);
            this.Start_speed.Name = "Start_speed";
            this.Start_speed.Size = new System.Drawing.Size(73, 21);
            this.Start_speed.TabIndex = 21;
            this.Start_speed.Text = "200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "初速度：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.S_Type);
            this.groupBox3.Controls.Add(this.T_Type);
            this.groupBox3.Location = new System.Drawing.Point(199, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(72, 75);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "速度曲线";
            // 
            // S_Type
            // 
            this.S_Type.AutoSize = true;
            this.S_Type.Location = new System.Drawing.Point(6, 53);
            this.S_Type.Name = "S_Type";
            this.S_Type.Size = new System.Drawing.Size(41, 16);
            this.S_Type.TabIndex = 1;
            this.S_Type.Text = "S型";
            this.S_Type.UseVisualStyleBackColor = true;
            // 
            // T_Type
            // 
            this.T_Type.AutoSize = true;
            this.T_Type.Checked = true;
            this.T_Type.Location = new System.Drawing.Point(6, 20);
            this.T_Type.Name = "T_Type";
            this.T_Type.Size = new System.Drawing.Size(41, 16);
            this.T_Type.TabIndex = 0;
            this.T_Type.TabStop = true;
            this.T_Type.Text = "T型";
            this.T_Type.UseVisualStyleBackColor = true;
            this.T_Type.CheckedChanged += new System.EventHandler(this.T_Type_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CCW);
            this.groupBox2.Controls.Add(this.CW);
            this.groupBox2.Location = new System.Drawing.Point(134, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(59, 75);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "方向";
            // 
            // CCW
            // 
            this.CCW.AutoSize = true;
            this.CCW.Location = new System.Drawing.Point(6, 50);
            this.CCW.Name = "CCW";
            this.CCW.Size = new System.Drawing.Size(47, 16);
            this.CCW.TabIndex = 1;
            this.CCW.Text = "反向";
            this.CCW.UseVisualStyleBackColor = true;
            this.CCW.CheckedChanged += new System.EventHandler(this.CCW_CheckedChanged);
            // 
            // CW
            // 
            this.CW.AutoSize = true;
            this.CW.Checked = true;
            this.CW.Location = new System.Drawing.Point(6, 20);
            this.CW.Name = "CW";
            this.CW.Size = new System.Drawing.Size(47, 16);
            this.CW.TabIndex = 0;
            this.CW.TabStop = true;
            this.CW.Text = "正向";
            this.CW.UseVisualStyleBackColor = true;
            this.CW.CheckedChanged += new System.EventHandler(this.CW_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Axis_U);
            this.groupBox4.Controls.Add(this.Axis_Z);
            this.groupBox4.Controls.Add(this.Axis_Y);
            this.groupBox4.Controls.Add(this.Axis_X);
            this.groupBox4.Location = new System.Drawing.Point(20, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 75);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "轴号";
            // 
            // Axis_U
            // 
            this.Axis_U.AutoSize = true;
            this.Axis_U.Location = new System.Drawing.Point(60, 50);
            this.Axis_U.Name = "Axis_U";
            this.Axis_U.Size = new System.Drawing.Size(41, 16);
            this.Axis_U.TabIndex = 14;
            this.Axis_U.TabStop = true;
            this.Axis_U.Text = "U轴";
            this.Axis_U.UseVisualStyleBackColor = true;
            this.Axis_U.CheckedChanged += new System.EventHandler(this.Axis_U_CheckedChanged);
            // 
            // Axis_Z
            // 
            this.Axis_Z.AutoSize = true;
            this.Axis_Z.Location = new System.Drawing.Point(60, 22);
            this.Axis_Z.Name = "Axis_Z";
            this.Axis_Z.Size = new System.Drawing.Size(41, 16);
            this.Axis_Z.TabIndex = 13;
            this.Axis_Z.TabStop = true;
            this.Axis_Z.Text = "Z轴";
            this.Axis_Z.UseVisualStyleBackColor = true;
            this.Axis_Z.CheckedChanged += new System.EventHandler(this.Axis_Z_CheckedChanged);
            // 
            // Axis_Y
            // 
            this.Axis_Y.AutoSize = true;
            this.Axis_Y.Location = new System.Drawing.Point(6, 51);
            this.Axis_Y.Name = "Axis_Y";
            this.Axis_Y.Size = new System.Drawing.Size(41, 16);
            this.Axis_Y.TabIndex = 12;
            this.Axis_Y.Text = "Y轴";
            this.Axis_Y.UseVisualStyleBackColor = true;
            this.Axis_Y.CheckedChanged += new System.EventHandler(this.Axis_Y_CheckedChanged);
            // 
            // Axis_X
            // 
            this.Axis_X.AutoSize = true;
            this.Axis_X.Checked = true;
            this.Axis_X.Location = new System.Drawing.Point(6, 20);
            this.Axis_X.Name = "Axis_X";
            this.Axis_X.Size = new System.Drawing.Size(41, 16);
            this.Axis_X.TabIndex = 0;
            this.Axis_X.TabStop = true;
            this.Axis_X.Text = "X轴";
            this.Axis_X.UseVisualStyleBackColor = true;
            this.Axis_X.CheckedChanged += new System.EventHandler(this.Axis_X_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 40);
            this.button4.TabIndex = 30;
            this.button4.Text = "位置清零";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 40);
            this.button3.TabIndex = 29;
            this.button3.Text = "急停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 28;
            this.button2.Text = "减速停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 40);
            this.button5.TabIndex = 32;
            this.button5.Text = "改变速度";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(318, 406);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 40);
            this.button6.TabIndex = 33;
            this.button6.Text = "改变位置";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 561);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox S_Tacc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dist_pos;
        private System.Windows.Forms.TextBox Tacc;
        private System.Windows.Forms.TextBox Max_speed;
        private System.Windows.Forms.TextBox Start_speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton S_Type;
        private System.Windows.Forms.RadioButton T_Type;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton CCW;
        private System.Windows.Forms.RadioButton CW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Axis_U;
        private System.Windows.Forms.RadioButton Axis_Z;
        private System.Windows.Forms.RadioButton Axis_Y;
        private System.Windows.Forms.RadioButton Axis_X;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

