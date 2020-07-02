namespace 例6_位置比较
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Axis_U = new System.Windows.Forms.RadioButton();
            this.Axis_Z = new System.Windows.Forms.RadioButton();
            this.Axis_Y = new System.Windows.Forms.RadioButton();
            this.Axis_X = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tdec = new System.Windows.Forms.TextBox();
            this.Tacc = new System.Windows.Forms.TextBox();
            this.Run_Speed = new System.Windows.Forms.TextBox();
            this.Start_Speed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TYPE1_2 = new System.Windows.Forms.RadioButton();
            this.TYPE1_3 = new System.Windows.Forms.RadioButton();
            this.TYPE1_1 = new System.Windows.Forms.RadioButton();
            this.Pos1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pos2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TYPE2_2 = new System.Windows.Forms.RadioButton();
            this.TYPE2_3 = new System.Windows.Forms.RadioButton();
            this.TYPE2_1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CCW = new System.Windows.Forms.RadioButton();
            this.CW = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Axis_U);
            this.groupBox1.Controls.Add(this.Axis_Z);
            this.groupBox1.Controls.Add(this.Axis_Y);
            this.groupBox1.Controls.Add(this.Axis_X);
            this.groupBox1.Location = new System.Drawing.Point(26, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轴号选择";
            // 
            // Axis_U
            // 
            this.Axis_U.AutoSize = true;
            this.Axis_U.Location = new System.Drawing.Point(72, 42);
            this.Axis_U.Name = "Axis_U";
            this.Axis_U.Size = new System.Drawing.Size(41, 16);
            this.Axis_U.TabIndex = 3;
            this.Axis_U.Text = "U轴";
            this.Axis_U.UseVisualStyleBackColor = true;
            this.Axis_U.CheckedChanged += new System.EventHandler(this.Axis_U_CheckedChanged);
            // 
            // Axis_Z
            // 
            this.Axis_Z.AutoSize = true;
            this.Axis_Z.Location = new System.Drawing.Point(15, 42);
            this.Axis_Z.Name = "Axis_Z";
            this.Axis_Z.Size = new System.Drawing.Size(41, 16);
            this.Axis_Z.TabIndex = 2;
            this.Axis_Z.Text = "Z轴";
            this.Axis_Z.UseVisualStyleBackColor = true;
            this.Axis_Z.CheckedChanged += new System.EventHandler(this.Axis_Z_CheckedChanged);
            // 
            // Axis_Y
            // 
            this.Axis_Y.AutoSize = true;
            this.Axis_Y.Location = new System.Drawing.Point(72, 20);
            this.Axis_Y.Name = "Axis_Y";
            this.Axis_Y.Size = new System.Drawing.Size(41, 16);
            this.Axis_Y.TabIndex = 1;
            this.Axis_Y.Text = "Y轴";
            this.Axis_Y.UseVisualStyleBackColor = true;
            this.Axis_Y.CheckedChanged += new System.EventHandler(this.Axis_Y_CheckedChanged);
            // 
            // Axis_X
            // 
            this.Axis_X.AutoSize = true;
            this.Axis_X.Checked = true;
            this.Axis_X.Location = new System.Drawing.Point(15, 20);
            this.Axis_X.Name = "Axis_X";
            this.Axis_X.Size = new System.Drawing.Size(41, 16);
            this.Axis_X.TabIndex = 0;
            this.Axis_X.TabStop = true;
            this.Axis_X.Text = "X轴";
            this.Axis_X.UseVisualStyleBackColor = true;
            this.Axis_X.CheckedChanged += new System.EventHandler(this.Axis_X_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Tdec);
            this.groupBox3.Controls.Add(this.Tacc);
            this.groupBox3.Controls.Add(this.Run_Speed);
            this.groupBox3.Controls.Add(this.Start_Speed);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(195, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 136);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "运动参数";
            // 
            // Tdec
            // 
            this.Tdec.Location = new System.Drawing.Point(90, 99);
            this.Tdec.Name = "Tdec";
            this.Tdec.Size = new System.Drawing.Size(100, 21);
            this.Tdec.TabIndex = 1;
            this.Tdec.Text = "0.1";
            // 
            // Tacc
            // 
            this.Tacc.Location = new System.Drawing.Point(90, 72);
            this.Tacc.Name = "Tacc";
            this.Tacc.Size = new System.Drawing.Size(100, 21);
            this.Tacc.TabIndex = 1;
            this.Tacc.Text = "0.1";
            // 
            // Run_Speed
            // 
            this.Run_Speed.Location = new System.Drawing.Point(90, 45);
            this.Run_Speed.Name = "Run_Speed";
            this.Run_Speed.Size = new System.Drawing.Size(100, 21);
            this.Run_Speed.TabIndex = 1;
            this.Run_Speed.Text = "1000";
            // 
            // Start_Speed
            // 
            this.Start_Speed.Location = new System.Drawing.Point(90, 18);
            this.Start_Speed.Name = "Start_Speed";
            this.Start_Speed.Size = new System.Drawing.Size(100, 21);
            this.Start_Speed.TabIndex = 1;
            this.Start_Speed.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "减速时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "加速时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "运行速度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "起始速度：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TYPE1_2);
            this.groupBox2.Controls.Add(this.TYPE1_3);
            this.groupBox2.Controls.Add(this.TYPE1_1);
            this.groupBox2.Controls.Add(this.Pos1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(26, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "比较器1设置";
            // 
            // TYPE1_2
            // 
            this.TYPE1_2.AutoSize = true;
            this.TYPE1_2.Location = new System.Drawing.Point(10, 85);
            this.TYPE1_2.Name = "TYPE1_2";
            this.TYPE1_2.Size = new System.Drawing.Size(143, 16);
            this.TYPE1_2.TabIndex = 6;
            this.TYPE1_2.TabStop = true;
            this.TYPE1_2.Text = "计数器的值小于比较器";
            this.TYPE1_2.UseVisualStyleBackColor = true;
            this.TYPE1_2.CheckedChanged += new System.EventHandler(this.TYPE1_2_CheckedChanged);
            // 
            // TYPE1_3
            // 
            this.TYPE1_3.AutoSize = true;
            this.TYPE1_3.Location = new System.Drawing.Point(10, 107);
            this.TYPE1_3.Name = "TYPE1_3";
            this.TYPE1_3.Size = new System.Drawing.Size(143, 16);
            this.TYPE1_3.TabIndex = 5;
            this.TYPE1_3.Text = "计数器的值大于比较器";
            this.TYPE1_3.UseVisualStyleBackColor = true;
            this.TYPE1_3.CheckedChanged += new System.EventHandler(this.TYPE1_3_CheckedChanged);
            // 
            // TYPE1_1
            // 
            this.TYPE1_1.AutoSize = true;
            this.TYPE1_1.Checked = true;
            this.TYPE1_1.Location = new System.Drawing.Point(10, 59);
            this.TYPE1_1.Name = "TYPE1_1";
            this.TYPE1_1.Size = new System.Drawing.Size(143, 16);
            this.TYPE1_1.TabIndex = 4;
            this.TYPE1_1.TabStop = true;
            this.TYPE1_1.Text = "计数器的值等于比较器";
            this.TYPE1_1.UseVisualStyleBackColor = true;
            this.TYPE1_1.CheckedChanged += new System.EventHandler(this.TYPE1_1_CheckedChanged);
            // 
            // Pos1
            // 
            this.Pos1.Location = new System.Drawing.Point(78, 20);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(75, 21);
            this.Pos1.TabIndex = 1;
            this.Pos1.Text = "3000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "比较点1：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "比较点2：";
            // 
            // Pos2
            // 
            this.Pos2.Location = new System.Drawing.Point(78, 20);
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(75, 21);
            this.Pos2.TabIndex = 3;
            this.Pos2.Text = "5000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TYPE2_2);
            this.groupBox4.Controls.Add(this.TYPE2_3);
            this.groupBox4.Controls.Add(this.TYPE2_1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Pos2);
            this.groupBox4.Location = new System.Drawing.Point(217, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 141);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "比较器2设置";
            // 
            // TYPE2_2
            // 
            this.TYPE2_2.AutoSize = true;
            this.TYPE2_2.Location = new System.Drawing.Point(10, 85);
            this.TYPE2_2.Name = "TYPE2_2";
            this.TYPE2_2.Size = new System.Drawing.Size(143, 16);
            this.TYPE2_2.TabIndex = 9;
            this.TYPE2_2.TabStop = true;
            this.TYPE2_2.Text = "计数器的值小于比较器";
            this.TYPE2_2.UseVisualStyleBackColor = true;
            this.TYPE2_2.CheckedChanged += new System.EventHandler(this.TYPE2_2_CheckedChanged);
            // 
            // TYPE2_3
            // 
            this.TYPE2_3.AutoSize = true;
            this.TYPE2_3.Location = new System.Drawing.Point(10, 107);
            this.TYPE2_3.Name = "TYPE2_3";
            this.TYPE2_3.Size = new System.Drawing.Size(143, 16);
            this.TYPE2_3.TabIndex = 8;
            this.TYPE2_3.Text = "计数器的值大于比较器";
            this.TYPE2_3.UseVisualStyleBackColor = true;
            this.TYPE2_3.CheckedChanged += new System.EventHandler(this.TYPE2_3_CheckedChanged);
            // 
            // TYPE2_1
            // 
            this.TYPE2_1.AutoSize = true;
            this.TYPE2_1.Checked = true;
            this.TYPE2_1.Location = new System.Drawing.Point(10, 59);
            this.TYPE2_1.Name = "TYPE2_1";
            this.TYPE2_1.Size = new System.Drawing.Size(143, 16);
            this.TYPE2_1.TabIndex = 7;
            this.TYPE2_1.TabStop = true;
            this.TYPE2_1.Text = "计数器的值等于比较器";
            this.TYPE2_1.UseVisualStyleBackColor = true;
            this.TYPE2_1.CheckedChanged += new System.EventHandler(this.TYPE2_1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CCW);
            this.groupBox5.Controls.Add(this.CW);
            this.groupBox5.Location = new System.Drawing.Point(27, 111);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(131, 37);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "方向";
            // 
            // CCW
            // 
            this.CCW.AutoSize = true;
            this.CCW.Location = new System.Drawing.Point(65, 15);
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
            this.CW.Location = new System.Drawing.Point(6, 14);
            this.CW.Name = "CW";
            this.CW.Size = new System.Drawing.Size(47, 16);
            this.CW.TabIndex = 0;
            this.CW.TabStop = true;
            this.CW.Text = "正向";
            this.CW.UseVisualStyleBackColor = true;
            this.CW.CheckedChanged += new System.EventHandler(this.CW_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "位置清零";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 514);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Axis_X;
        private System.Windows.Forms.RadioButton Axis_U;
        private System.Windows.Forms.RadioButton Axis_Z;
        private System.Windows.Forms.RadioButton Axis_Y;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Tdec;
        private System.Windows.Forms.TextBox Tacc;
        private System.Windows.Forms.TextBox Run_Speed;
        private System.Windows.Forms.TextBox Start_Speed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Pos1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pos2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton TYPE1_2;
        private System.Windows.Forms.RadioButton TYPE1_3;
        private System.Windows.Forms.RadioButton TYPE1_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton TYPE2_2;
        private System.Windows.Forms.RadioButton TYPE2_3;
        private System.Windows.Forms.RadioButton TYPE2_1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton CCW;
        private System.Windows.Forms.RadioButton CW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

