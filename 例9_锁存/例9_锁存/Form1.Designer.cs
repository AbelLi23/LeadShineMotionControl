namespace 例9_锁存
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.V3 = new System.Windows.Forms.TextBox();
            this.ENCODER3 = new System.Windows.Forms.TextBox();
            this.V4 = new System.Windows.Forms.TextBox();
            this.ENCODER4 = new System.Windows.Forms.TextBox();
            this.V2 = new System.Windows.Forms.TextBox();
            this.POS3 = new System.Windows.Forms.TextBox();
            this.ENCODER2 = new System.Windows.Forms.TextBox();
            this.POS4 = new System.Windows.Forms.TextBox();
            this.V1 = new System.Windows.Forms.TextBox();
            this.POS2 = new System.Windows.Forms.TextBox();
            this.ENCODER1 = new System.Windows.Forms.TextBox();
            this.POS1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(504, 199);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.V3);
            this.groupBox1.Controls.Add(this.ENCODER3);
            this.groupBox1.Controls.Add(this.V4);
            this.groupBox1.Controls.Add(this.ENCODER4);
            this.groupBox1.Controls.Add(this.V2);
            this.groupBox1.Controls.Add(this.POS3);
            this.groupBox1.Controls.Add(this.ENCODER2);
            this.groupBox1.Controls.Add(this.POS4);
            this.groupBox1.Controls.Add(this.V1);
            this.groupBox1.Controls.Add(this.POS2);
            this.groupBox1.Controls.Add(this.ENCODER1);
            this.groupBox1.Controls.Add(this.POS1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "第2轴";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "第3轴";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "第1轴";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "第0轴";
            // 
            // V3
            // 
            this.V3.Location = new System.Drawing.Point(289, 111);
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(63, 21);
            this.V3.TabIndex = 5;
            // 
            // ENCODER3
            // 
            this.ENCODER3.Location = new System.Drawing.Point(289, 77);
            this.ENCODER3.Name = "ENCODER3";
            this.ENCODER3.Size = new System.Drawing.Size(63, 21);
            this.ENCODER3.TabIndex = 4;
            // 
            // V4
            // 
            this.V4.Location = new System.Drawing.Point(395, 111);
            this.V4.Name = "V4";
            this.V4.Size = new System.Drawing.Size(63, 21);
            this.V4.TabIndex = 5;
            // 
            // ENCODER4
            // 
            this.ENCODER4.Location = new System.Drawing.Point(395, 77);
            this.ENCODER4.Name = "ENCODER4";
            this.ENCODER4.Size = new System.Drawing.Size(63, 21);
            this.ENCODER4.TabIndex = 4;
            // 
            // V2
            // 
            this.V2.Location = new System.Drawing.Point(191, 111);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(63, 21);
            this.V2.TabIndex = 5;
            // 
            // POS3
            // 
            this.POS3.Location = new System.Drawing.Point(289, 46);
            this.POS3.Name = "POS3";
            this.POS3.Size = new System.Drawing.Size(63, 21);
            this.POS3.TabIndex = 3;
            // 
            // ENCODER2
            // 
            this.ENCODER2.Location = new System.Drawing.Point(191, 77);
            this.ENCODER2.Name = "ENCODER2";
            this.ENCODER2.Size = new System.Drawing.Size(63, 21);
            this.ENCODER2.TabIndex = 4;
            // 
            // POS4
            // 
            this.POS4.Location = new System.Drawing.Point(395, 46);
            this.POS4.Name = "POS4";
            this.POS4.Size = new System.Drawing.Size(63, 21);
            this.POS4.TabIndex = 3;
            // 
            // V1
            // 
            this.V1.Location = new System.Drawing.Point(97, 111);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(63, 21);
            this.V1.TabIndex = 5;
            // 
            // POS2
            // 
            this.POS2.Location = new System.Drawing.Point(191, 46);
            this.POS2.Name = "POS2";
            this.POS2.Size = new System.Drawing.Size(63, 21);
            this.POS2.TabIndex = 3;
            // 
            // ENCODER1
            // 
            this.ENCODER1.Location = new System.Drawing.Point(97, 77);
            this.ENCODER1.Name = "ENCODER1";
            this.ENCODER1.Size = new System.Drawing.Size(63, 21);
            this.ENCODER1.TabIndex = 4;
            // 
            // POS1
            // 
            this.POS1.Location = new System.Drawing.Point(97, 46);
            this.POS1.Name = "POS1";
            this.POS1.Size = new System.Drawing.Size(63, 21);
            this.POS1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "速度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "计数器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "脉冲位置";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "触发状态复位";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "清零状态复位";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(625, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 36);
            this.button5.TabIndex = 2;
            this.button5.Text = "计数器清零";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(625, 385);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 36);
            this.button6.TabIndex = 3;
            this.button6.Text = "清空列表";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 542);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox V3;
        private System.Windows.Forms.TextBox ENCODER3;
        private System.Windows.Forms.TextBox V4;
        private System.Windows.Forms.TextBox ENCODER4;
        private System.Windows.Forms.TextBox V2;
        private System.Windows.Forms.TextBox POS3;
        private System.Windows.Forms.TextBox ENCODER2;
        private System.Windows.Forms.TextBox POS4;
        private System.Windows.Forms.TextBox V1;
        private System.Windows.Forms.TextBox POS2;
        private System.Windows.Forms.TextBox ENCODER1;
        private System.Windows.Forms.TextBox POS1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

