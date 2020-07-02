using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例2_连续运动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ushort DIR=1,nAxis;
        public int  Dist;
        public int T_S;
        public double Min_Vel, Max_Vel, Tac, S_Tac;

        private void CW_CheckedChanged(object sender, EventArgs e)
        {
            DIR = 1;
        }

        private void CCW_CheckedChanged(object sender, EventArgs e)
        {
            DIR = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = "X轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(0))) + "  X轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(0))) +
                "\r\n" + "Y轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(1))) + "  Y轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(1))) +
                "\r\n" + "Z轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(2))) + "  Z轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(2))) +
                "\r\n" + "U轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(3))) + "  U轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(3)));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Min_Vel = Convert.ToDouble(Start_speed.Text);
            Max_Vel = Convert.ToDouble(Max_speed.Text);
            Tac = Convert.ToDouble(Tacc.Text);
            S_Tac = Convert.ToDouble(S_Tacc.Text);

            Dmc2410.d2410_set_pulse_outmode(0, 0);  //设置控制卡轴的脉冲输出模式
            Dmc2410.d2410_set_pulse_outmode(1, 0);

            //Dmc2410.d2410_set_profile(0, 200, 2000, Tac, Tac);
            //Dmc2410.d2410_t_pmove(0, 5000, 0);

            if (nAxis == 0)            //0轴
            {
                if (T_S == 0)         //T型曲线运动
                {
                    Dmc2410.d2410_set_profile(0, Min_Vel, Max_Vel, Tac, Tac);
                    Dmc2410.d2410_t_vmove(0, DIR);
                }
                else
                {
                    Dmc2410.d2410_set_st_profile(0, Min_Vel, Max_Vel, Tac, Tac, S_Tac, S_Tac);
                    Dmc2410.d2410_s_vmove(0, DIR);
                }
            }
            if (nAxis == 1)           //1轴
            {
                if (T_S == 0)   //S型曲线运动
                {
                    Dmc2410.d2410_set_profile(1, Min_Vel, Max_Vel, Tac, Tac);
                    Dmc2410.d2410_t_vmove(1, DIR);
                }
                else
                {
                    Dmc2410.d2410_set_st_profile(1, Min_Vel, Max_Vel, Tac, Tac, S_Tac, S_Tac);
                    Dmc2410.d2410_s_vmove(1, DIR);
                }
            }

            if (nAxis == 2)           //2轴
            {
                if (T_S == 0)   //S型曲线运动
                {
                    Dmc2410.d2410_set_profile(2, Min_Vel, Max_Vel, Tac, Tac);
                    Dmc2410.d2410_t_vmove(2, DIR);
                }
                else
                {
                    Dmc2410.d2410_set_st_profile(2, Min_Vel, Max_Vel, Tac, Tac, S_Tac, S_Tac);
                    Dmc2410.d2410_s_vmove(2, DIR);
                }
            }
            if (nAxis == 3)           //3轴
            {
                if (T_S == 0)   //S型曲线运动
                {
                    Dmc2410.d2410_set_profile(3, Min_Vel, Max_Vel, Tac, Tac);
                    Dmc2410.d2410_t_vmove(3, DIR);
                }
                else
                {
                    Dmc2410.d2410_set_st_profile(3, Min_Vel, Max_Vel, Tac, Tac, S_Tac, S_Tac);
                    Dmc2410.d2410_s_vmove(3, DIR);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void Axis_X_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 0;
        }

        private void Axis_Z_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 2;
        }

        private void Axis_Y_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 1;
        }

        private void Axis_U_CheckedChanged(object sender, EventArgs e)
        {
            nAxis = 3;
        }

       

        private void T_Type_CheckedChanged(object sender, EventArgs e)
        {
            T_S = 0;
        }

        private void S_Type_CheckedChanged(object sender, EventArgs e)
        {
            T_S = 1;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (nAxis == 0)
            {
                Dmc2410.d2410_decel_stop(0, Tac);
            }
            if (nAxis == 1)
            {
                Dmc2410.d2410_decel_stop(1, Tac);
            }
            if (nAxis == 2)
            {
                Dmc2410.d2410_decel_stop(2, Tac);
            }
            if (nAxis == 3)
            {
                Dmc2410.d2410_decel_stop(3, Tac);
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (nAxis == 0)
            {
                Dmc2410.d2410_set_position(0, 0);
            }
            if (nAxis == 1)
            {
                Dmc2410.d2410_set_position(1, 0);
            }
            if (nAxis == 2)
            {
                Dmc2410.d2410_set_position(2, 0);
            }
            if (nAxis == 3)
            {
                Dmc2410.d2410_set_position(3, 0);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_close();    //关闭控制卡
        }
    }
}