namespace 例8_手轮运动
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
            this.Axis_X = new System.Windows.Forms.RadioButton();
            this.Axis_Y = new System.Windows.Forms.RadioButton();
            this.Axis_Z = new System.Windows.Forms.RadioButton();
            this.Axis_U = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(27, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轴号选择";
            // 
            // Axis_X
            // 
            this.Axis_X.AutoSize = true;
            this.Axis_X.Checked = true;
            this.Axis_X.Location = new System.Drawing.Point(11, 33);
            this.Axis_X.Name = "Axis_X";
            this.Axis_X.Size = new System.Drawing.Size(41, 16);
            this.Axis_X.TabIndex = 0;
            this.Axis_X.TabStop = true;
            this.Axis_X.Text = "X轴";
            this.Axis_X.UseVisualStyleBackColor = true;
            this.Axis_X.CheckedChanged += new System.EventHandler(this.Axis_X_CheckedChanged);
            // 
            // Axis_Y
            // 
            this.Axis_Y.AutoSize = true;
            this.Axis_Y.Location = new System.Drawing.Point(11, 68);
            this.Axis_Y.Name = "Axis_Y";
            this.Axis_Y.Size = new System.Drawing.Size(41, 16);
            this.Axis_Y.TabIndex = 1;
            this.Axis_Y.Text = "Y轴";
            this.Axis_Y.UseVisualStyleBackColor = true;
            this.Axis_Y.CheckedChanged += new System.EventHandler(this.Axis_Y_CheckedChanged);
            // 
            // Axis_Z
            // 
            this.Axis_Z.AutoSize = true;
            this.Axis_Z.Location = new System.Drawing.Point(11, 103);
            this.Axis_Z.Name = "Axis_Z";
            this.Axis_Z.Size = new System.Drawing.Size(41, 16);
            this.Axis_Z.TabIndex = 2;
            this.Axis_Z.Text = "Z轴";
            this.Axis_Z.UseVisualStyleBackColor = true;
            this.Axis_Z.CheckedChanged += new System.EventHandler(this.Axis_Z_CheckedChanged);
            // 
            // Axis_U
            // 
            this.Axis_U.AutoSize = true;
            this.Axis_U.Location = new System.Drawing.Point(11, 138);
            this.Axis_U.Name = "Axis_U";
            this.Axis_U.Size = new System.Drawing.Size(41, 16);
            this.Axis_U.TabIndex = 3;
            this.Axis_U.Text = "U轴";
            this.Axis_U.UseVisualStyleBackColor = true;
            this.Axis_U.CheckedChanged += new System.EventHandler(this.Axis_U_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(143, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 31);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "A/B×1";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(16, 67);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 16);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.Text = "A/B×2";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(16, 103);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(59, 16);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.Text = "A/B×4";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(16, 139);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(71, 16);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.Text = "差分信号";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "最高脉冲频率";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "50000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Axis_U;
        private System.Windows.Forms.RadioButton Axis_Z;
        private System.Windows.Forms.RadioButton Axis_Y;
        private System.Windows.Forms.RadioButton Axis_X;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

