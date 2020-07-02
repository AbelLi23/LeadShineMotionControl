namespace 例3_回原点运动
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RUN = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CCW = new System.Windows.Forms.RadioButton();
            this.CW = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nEZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Home_EZ = new System.Windows.Forms.RadioButton();
            this.Only_Home = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Axis_Y = new System.Windows.Forms.RadioButton();
            this.Axis_X = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.High_Speed = new System.Windows.Forms.RadioButton();
            this.Low_Speed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Start_Speed = new System.Windows.Forms.TextBox();
            this.Max_Speed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tacc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Axis_Z = new System.Windows.Forms.RadioButton();
            this.Axis_U = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 35);
            this.button4.TabIndex = 25;
            this.button4.Text = "位置清零";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "急停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "减速停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RUN
            // 
            this.RUN.Location = new System.Drawing.Point(59, 303);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(92, 35);
            this.RUN.TabIndex = 22;
            this.RUN.Text = "启动";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CCW);
            this.groupBox5.Controls.Add(this.CW);
            this.groupBox5.Location = new System.Drawing.Point(225, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 48);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "回原点方向";
            // 
            // CCW
            // 
            this.CCW.AutoSize = true;
            this.CCW.Location = new System.Drawing.Point(71, 20);
            this.CCW.Name = "CCW";
            this.CCW.Size = new System.Drawing.Size(47, 16);
            this.CCW.TabIndex = 1;
            this.CCW.Text = "负向";
            this.CCW.UseVisualStyleBackColor = true;
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
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.nEZ);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Home_EZ);
            this.groupBox4.Controls.Add(this.Only_Home);
            this.groupBox4.Location = new System.Drawing.Point(217, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 103);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "回原点信号检测";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "(1-16)";
            // 
            // nEZ
            // 
            this.nEZ.Location = new System.Drawing.Point(67, 72);
            this.nEZ.Name = "nEZ";
            this.nEZ.Size = new System.Drawing.Size(21, 21);
            this.nEZ.TabIndex = 3;
            this.nEZ.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "EZ个数：";
            // 
            // Home_EZ
            // 
            this.Home_EZ.AutoSize = true;
            this.Home_EZ.Location = new System.Drawing.Point(6, 50);
            this.Home_EZ.Name = "Home_EZ";
            this.Home_EZ.Size = new System.Drawing.Size(77, 16);
            this.Home_EZ.TabIndex = 1;
            this.Home_EZ.Text = "Home + EZ";
            this.Home_EZ.UseVisualStyleBackColor = true;
            // 
            // Only_Home
            // 
            this.Only_Home.AutoSize = true;
            this.Only_Home.Checked = true;
            this.Only_Home.Location = new System.Drawing.Point(6, 28);
            this.Only_Home.Name = "Only_Home";
            this.Only_Home.Size = new System.Drawing.Size(59, 16);
            this.Only_Home.TabIndex = 0;
            this.Only_Home.TabStop = true;
            this.Only_Home.Text = "仅Home";
            this.Only_Home.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Axis_U);
            this.groupBox3.Controls.Add(this.Axis_Z);
            this.groupBox3.Controls.Add(this.Axis_Y);
            this.groupBox3.Controls.Add(this.Axis_X);
            this.groupBox3.Location = new System.Drawing.Point(223, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 80);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "轴号";
            // 
            // Axis_Y
            // 
            this.Axis_Y.AutoSize = true;
            this.Axis_Y.Location = new System.Drawing.Point(71, 20);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.High_Speed);
            this.groupBox2.Controls.Add(this.Low_Speed);
            this.groupBox2.Location = new System.Drawing.Point(20, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 48);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "回原点速度模式";
            // 
            // High_Speed
            // 
            this.High_Speed.AutoSize = true;
            this.High_Speed.Location = new System.Drawing.Point(83, 20);
            this.High_Speed.Name = "High_Speed";
            this.High_Speed.Size = new System.Drawing.Size(47, 16);
            this.High_Speed.TabIndex = 1;
            this.High_Speed.Text = "高速";
            this.High_Speed.UseVisualStyleBackColor = true;
            // 
            // Low_Speed
            // 
            this.Low_Speed.AutoSize = true;
            this.Low_Speed.Checked = true;
            this.Low_Speed.Location = new System.Drawing.Point(16, 20);
            this.Low_Speed.Name = "Low_Speed";
            this.Low_Speed.Size = new System.Drawing.Size(47, 16);
            this.Low_Speed.TabIndex = 0;
            this.Low_Speed.TabStop = true;
            this.Low_Speed.Text = "低速";
            this.Low_Speed.UseVisualStyleBackColor = true;
            this.Low_Speed.CheckedChanged += new System.EventHandler(this.Low_Speed_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Start_Speed);
            this.groupBox1.Controls.Add(this.Max_Speed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tacc);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 151);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运动参数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "运行速度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "加速时间：";
            // 
            // Start_Speed
            // 
            this.Start_Speed.Location = new System.Drawing.Point(77, 22);
            this.Start_Speed.Name = "Start_Speed";
            this.Start_Speed.Size = new System.Drawing.Size(61, 21);
            this.Start_Speed.TabIndex = 1;
            this.Start_Speed.Text = "200";
            // 
            // Max_Speed
            // 
            this.Max_Speed.Location = new System.Drawing.Point(77, 63);
            this.Max_Speed.Name = "Max_Speed";
            this.Max_Speed.Size = new System.Drawing.Size(61, 21);
            this.Max_Speed.TabIndex = 2;
            this.Max_Speed.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "起始速度：";
            // 
            // Tacc
            // 
            this.Tacc.Location = new System.Drawing.Point(77, 104);
            this.Tacc.Name = "Tacc";
            this.Tacc.Size = new System.Drawing.Size(61, 21);
            this.Tacc.TabIndex = 3;
            this.Tacc.Text = "0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // Axis_Z
            // 
            this.Axis_Z.AutoSize = true;
            this.Axis_Z.Location = new System.Drawing.Point(14, 58);
            this.Axis_Z.Name = "Axis_Z";
            this.Axis_Z.Size = new System.Drawing.Size(41, 16);
            this.Axis_Z.TabIndex = 2;
            this.Axis_Z.TabStop = true;
            this.Axis_Z.Text = "Z轴";
            this.Axis_Z.UseVisualStyleBackColor = true;
            this.Axis_Z.CheckedChanged += new System.EventHandler(this.Axis_Z_CheckedChanged);
            // 
            // Axis_U
            // 
            this.Axis_U.AutoSize = true;
            this.Axis_U.Location = new System.Drawing.Point(71, 58);
            this.Axis_U.Name = "Axis_U";
            this.Axis_U.Size = new System.Drawing.Size(41, 16);
            this.Axis_U.TabIndex = 3;
            this.Axis_U.TabStop = true;
            this.Axis_U.Text = "U轴";
            this.Axis_U.UseVisualStyleBackColor = true;
            this.Axis_U.CheckedChanged += new System.EventHandler(this.Axis_U_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 511);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RUN);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton CCW;
        private System.Windows.Forms.RadioButton CW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nEZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Home_EZ;
        private System.Windows.Forms.RadioButton Only_Home;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Axis_U;
        private System.Windows.Forms.RadioButton Axis_Z;
        private System.Windows.Forms.RadioButton Axis_Y;
        private System.Windows.Forms.RadioButton Axis_X;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton High_Speed;
        private System.Windows.Forms.RadioButton Low_Speed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Start_Speed;
        private System.Windows.Forms.TextBox Max_Speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tacc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

