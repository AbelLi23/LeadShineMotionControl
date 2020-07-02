using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例8_手轮运动
{
    public partial class Form1 : Form
    {
        public ushort InputMode;
        public ushort countdir;
        public ushort ControlAxis;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n;
            n = Dmc2410.d2410_board_init();   //初始化控制卡
            if (n < 1 || n > 8)
            {
                MessageBox.Show("未找到控制卡", "出错");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_close();    //关闭控制卡
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(0))) + "  X轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(0))) +
                "\r\n" + "Y轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(1))) + "  Y轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(1))) +
                "\r\n" + "Z轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(2))) + "  Z轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(2))) +
                "\r\n" + "U轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(3))) + "  U轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(3)));
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            InputMode = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SpeedLimit;
            ushort i;
            for (  i = 0; i < 4; i++)
            {
                Dmc2410.d2410_set_handwheel_inmode(i, InputMode, countdir);
            }
            SpeedLimit = Convert.ToDouble(textBox1.Text);
            Dmc2410.d2410_handwheel_move(i, SpeedLimit);
        }

        private void Axis_X_CheckedChanged(object sender, EventArgs e)
        {
            ControlAxis = 0;
        }

        private void Axis_Y_CheckedChanged(object sender, EventArgs e)
        {
            ControlAxis = 1;
        }

        private void Axis_Z_CheckedChanged(object sender, EventArgs e)
        {
            ControlAxis = 2;
        }

        private void Axis_U_CheckedChanged(object sender, EventArgs e)
        {
            ControlAxis = 3;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            InputMode = 0;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            InputMode = 1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            InputMode = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }
    }
}