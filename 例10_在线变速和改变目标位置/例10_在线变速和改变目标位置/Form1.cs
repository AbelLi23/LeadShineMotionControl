using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例10_在线变速和改变目标位置
{
    public partial class Form1 : Form
    {
        public ushort nAxis=0;
        public int DIR=1, Dist;
        public int T_S;
        public double Min_Vel, Max_Vel, Tac, S_Tac;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double V=Convert .ToDouble (textBox1 .Text );
            Dmc2410.d2410_variety_speed_range(nAxis, 1, 10000000); //变速使能
            Dmc2410.d2410_change_speed(nAxis, V);

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

        private void CW_CheckedChanged(object sender, EventArgs e)
        {
            DIR = 1;
        }

        private void CCW_CheckedChanged(object sender, EventArgs e)
        {
            DIR = -1;
        }

        private void T_Type_CheckedChanged(object sender, EventArgs e)
        {
            T_S = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Min_Vel = Convert.ToDouble(Start_speed.Text);
            Max_Vel = Convert.ToDouble(Max_speed.Text);
            Tac = Convert.ToDouble(Tacc.Text);
            Dist = Convert.ToInt16(Dist_pos.Text);
            S_Tac = Convert.ToDouble(S_Tacc.Text);

            Dmc2410.d2410_set_pulse_outmode(nAxis, 0);  //设置控制卡轴的脉冲输出模式
            if (T_S == 0)         //T型曲线运动
            {
                Dmc2410.d2410_set_profile(nAxis, Min_Vel, Max_Vel, Tac, Tac);
                Dmc2410.d2410_t_pmove(nAxis, DIR * Dist, 1);
            }
            else
            {
                Dmc2410.d2410_set_st_profile(nAxis, Min_Vel, Max_Vel, Tac, Tac, S_Tac, S_Tac);
                Dmc2410.d2410_s_pmove(nAxis, DIR * Dist, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_decel_stop(nAxis, Tac);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_set_position(nAxis, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int  P=Convert .ToInt16 (textBox2 .Text );
            Dmc2410.d2410_reset_target_position(nAxis, P);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(nAxis))) + "  轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(nAxis)));
        }
    }
}