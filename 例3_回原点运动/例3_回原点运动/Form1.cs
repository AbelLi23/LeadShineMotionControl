using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例3_回原点运动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ushort nAxis;
        public ushort home_speed;
        public ushort home_mode;
        public ushort home_signal;
        public double fAcc, m_nStart, m_nSpeed;
        public ushort number_EZ;

        private void Form1_Load(object sender, EventArgs e)
        {
            int n;
            n = Dmc2410.d2410_board_init();         //初始化控制卡
            if (n < 1 || n > 8)
                MessageBox.Show("未找到控制卡", "出错");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_close();            //关闭控制卡
        }

        private void RUN_Click(object sender, EventArgs e)
        {
            m_nStart = Convert.ToDouble(Start_Speed.Text);
            m_nSpeed = Convert.ToDouble(Max_Speed.Text);
            fAcc = Convert.ToDouble(Tacc.Text);
            number_EZ = Convert.ToUInt16(nEZ.Text);

            Dmc2410.d2410_set_pulse_outmode(0, 0);       //脉冲输出模式
            Dmc2410.d2410_set_pulse_outmode(1, 0);


            if (Low_Speed.Checked)                  //回零速度选择
                home_speed = 0;
            else
                home_speed = 1;

            if (CW.Checked)                         //回零方向
                home_mode = 1;
            else
                home_mode = 2;

            if (Only_Home.Checked)                 //回零模式
                home_signal = 0;
            else
                home_signal = 1;

            Dmc2410.d2410_set_HOME_pin_logic(nAxis, 0, 1); //设置原点信号为低电平有效，允许信号滤波
            Dmc2410.d2410_config_EZ_PIN(nAxis, 0, 1);
            Dmc2410.d2410_config_home_mode(nAxis, home_signal, number_EZ);

            Dmc2410.d2410_set_profile(nAxis, m_nStart, m_nSpeed, fAcc, fAcc);    //设置速度、加速度
            Dmc2410.d2410_home_move(nAxis, home_mode, home_speed);               //启动回原点运动
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_decel_stop(nAxis, fAcc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_set_position(nAxis, 0);
        }

        private void Low_Speed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X轴位置：" + Convert.ToString(Dmc2410.d2410_read_current_speed(0)) + "  X轴速度：" + Convert.ToString(Dmc2410.d2410_get_position(0)) +
                "\r\n" + "Y轴位置：" + Convert.ToString(Dmc2410.d2410_read_current_speed(1)) + "  Y轴速度：" + Convert.ToString(Dmc2410.d2410_get_position(1)) +
                "\r\n" + "Z轴位置：" + Convert.ToString(Dmc2410.d2410_read_current_speed(2)) + "  Z轴速度：" + Convert.ToString(Dmc2410.d2410_get_position(2)) +
                "\r\n" + "U轴位置：" + Convert.ToString(Dmc2410.d2410_read_current_speed(3)) + "  U轴速度：" + Convert.ToString(Dmc2410.d2410_get_position(3));
        }

        private void CW_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Axis_X_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 0;
        }

        private void Axis_Y_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 1;
        }

        private void Axis_Z_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 2;
        }

        private void Axis_U_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 3;
        }
    }
}