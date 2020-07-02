namespace 例4_直线插补
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
            this.Dist_U = new System.Windows.Forms.TextBox();
            this.Dist_Z = new System.Windows.Forms.TextBox();
            this.Dist_Y = new System.Windows.Forms.TextBox();
            this.Dist_X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.XYZU = new System.Windows.Forms.RadioButton();
            this.XYZ = new System.Windows.Forms.RadioButton();
            this.XY = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tdec = new System.Windows.Forms.TextBox();
            this.Tacc = new System.Windows.Forms.TextBox();
            this.Run_Speed = new System.Windows.Forms.TextBox();
            this.Start_Speed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dist_U);
            this.groupBox1.Controls.Add(this.Dist_Z);
            this.groupBox1.Controls.Add(this.Dist_Y);
            this.groupBox1.Controls.Add(this.Dist_X);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "移动距离";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Dist_U
            // 
            this.Dist_U.Location = new System.Drawing.Point(61, 128);
            this.Dist_U.Name = "Dist_U";
            this.Dist_U.Size = new System.Drawing.Size(100, 21);
            this.Dist_U.TabIndex = 3;
            this.Dist_U.Text = "6400";
            // 
            // Dist_Z
            // 
            this.Dist_Z.Location = new System.Drawing.Point(61, 91);
            this.Dist_Z.Name = "Dist_Z";
            this.Dist_Z.Size = new System.Drawing.Size(100, 21);
            this.Dist_Z.TabIndex = 3;
            this.Dist_Z.Text = "6400";
            // 
            // Dist_Y
            // 
            this.Dist_Y.Location = new System.Drawing.Point(61, 54);
            this.Dist_Y.Name = "Dist_Y";
            this.Dist_Y.Size = new System.Drawing.Size(100, 21);
            this.Dist_Y.TabIndex = 2;
            this.Dist_Y.Text = "6400";
            // 
            // Dist_X
            // 
            this.Dist_X.Location = new System.Drawing.Point(61, 17);
            this.Dist_X.Name = "Dist_X";
            this.Dist_X.Size = new System.Drawing.Size(100, 21);
            this.Dist_X.TabIndex = 1;
            this.Dist_X.Text = "6400";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "U轴：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Z轴：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y轴：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X轴：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.XYZU);
            this.groupBox2.Controls.Add(this.XYZ);
            this.groupBox2.Controls.Add(this.XY);
            this.groupBox2.Location = new System.Drawing.Point(281, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运动轴";
            // 
            // XYZU
            // 
            this.XYZU.AutoSize = true;
            this.XYZU.Location = new System.Drawing.Point(28, 114);
            this.XYZU.Name = "XYZU";
            this.XYZU.Size = new System.Drawing.Size(59, 16);
            this.XYZU.TabIndex = 2;
            this.XYZU.Text = "XYZU轴";
            this.XYZU.UseVisualStyleBackColor = true;
            // 
            // XYZ
            // 
            this.XYZ.AutoSize = true;
            this.XYZ.Location = new System.Drawing.Point(28, 76);
            this.XYZ.Name = "XYZ";
            this.XYZ.Size = new System.Drawing.Size(53, 16);
            this.XYZ.TabIndex = 1;
            this.XYZ.Text = "XYZ轴";
            this.XYZ.UseVisualStyleBackColor = true;
            // 
            // XY
            // 
            this.XY.AutoSize = true;
            this.XY.Checked = true;
            this.XY.Location = new System.Drawing.Point(28, 36);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(47, 16);
            this.XY.TabIndex = 0;
            this.XY.TabStop = true;
            this.XY.Text = "XY轴";
            this.XY.UseVisualStyleBackColor = true;
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
            this.groupBox3.Location = new System.Drawing.Point(32, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 136);
            this.groupBox3.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "急停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "减速停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(350, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "位置清零";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 477);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Dist_U;
        private System.Windows.Forms.TextBox Dist_Z;
        private System.Windows.Forms.TextBox Dist_Y;
        private System.Windows.Forms.TextBox Dist_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton XYZU;
        private System.Windows.Forms.RadioButton XYZ;
        private System.Windows.Forms.RadioButton XY;
        private System.Windows.Forms.TextBox Tdec;
        private System.Windows.Forms.TextBox Tacc;
        private System.Windows.Forms.TextBox Run_Speed;
        private System.Windows.Forms.TextBox Start_Speed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
    }
}

