using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例6_位置比较
{
    public partial class Form1 : Form
    {
        public ushort nAxis;
        public ushort  cmp1_condition;
        public ushort  cmp2_condition;
        public ushort  Dir;

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

        private void button1_Click(object sender, EventArgs e)
        {
            int nSpeed, mSpeed;
            double Tac, Tdc;
            uint  Dist_Pos1, Dist_Pos2;

            nSpeed = Convert.ToInt16(Start_Speed.Text);
            mSpeed = Convert.ToInt16(Run_Speed.Text);

            Tac = double.Parse(Tacc.Text);
            Tdc = double.Parse(Tdec.Text);

            Dist_Pos1 = Convert.ToUInt16   (Pos1 .Text);
            Dist_Pos2 = Convert.ToUInt16(Pos2.Text);

            Dmc2410.d2410_config_CMP_PIN(nAxis, 1, 1, 1);//配置位置比较输出功能
            Dmc2410.d2410_set_comparator_data(nAxis, Dist_Pos1, Dist_Pos2); //预置比较器的数值
            Dmc2410.d2410_config_comparator(nAxis, cmp1_condition, cmp2_condition, 0, 0);
            //配置指定轴的触发条件

            Dmc2410.d2410_set_profile(nAxis, nSpeed, mSpeed, Tac, Tdc);
            Dmc2410.d2410_t_vmove(nAxis, Dir);          //连续运动
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_set_position(0, 0);
            Dmc2410.d2410_set_position(1, 0);
            Dmc2410.d2410_set_position(2, 0);
            Dmc2410.d2410_set_position(3, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(0))) + "  X轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(0))) +
                 "\r\n" + "Y轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(1))) + "  Y轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(1))) +
                 "\r\n" + "Z轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(2))) + "  Z轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(2))) +
                 "\r\n" + "U轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(3))) + "  U轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(3))) +
                 "\r\n" + "比较输出端口1状态:" + Convert.ToString(Dmc2410.d2410_read_CMP_PIN(nAxis)) +
                 "\r\n" + "比较输出端口2状态:" + Convert.ToString(Dmc2410.d2410_read_outbit(0, 17));
        }

        private void TYPE1_1_CheckedChanged(object sender, EventArgs e)
        {
            cmp1_condition = 1;
        }

        private void TYPE1_2_CheckedChanged(object sender, EventArgs e)
        {
            cmp1_condition = 2;
        }

        private void TYPE1_3_CheckedChanged(object sender, EventArgs e)
        {
            cmp1_condition = 3;
        }

        private void TYPE2_1_CheckedChanged(object sender, EventArgs e)
        {
            cmp2_condition = 1;
        }

        private void TYPE2_2_CheckedChanged(object sender, EventArgs e)
        {
            cmp2_condition = 2;
        }

        private void TYPE2_3_CheckedChanged(object sender, EventArgs e)
        {
            cmp2_condition = 3;
        }

        private void CW_CheckedChanged(object sender, EventArgs e)
        {
            Dir = 1;
        }

        private void CCW_CheckedChanged(object sender, EventArgs e)
        {
            Dir = 0;
        }

        

    }
}