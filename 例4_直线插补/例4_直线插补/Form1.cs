using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例4_直线插补
{
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            int dist1, dist2, dist3, dist4;
            int nSpeed, mSpeed;
            double Tac, Tdc;

            nSpeed = Convert.ToInt16(Start_Speed.Text);
            mSpeed = int.Parse(Run_Speed.Text);
            Tac = double.Parse(Tacc.Text);
            Tdc = Convert.ToDouble(Tdec.Text);

            dist1 = int.Parse(Dist_X.Text);
            dist2 = int.Parse(Dist_Y.Text);
            dist3 = int.Parse(Dist_Z.Text);
            dist4 = int.Parse(Dist_U.Text);

            ushort[] Axis ={ 0, 1, 2 };

            Dmc2410.d2410_set_vector_profile(nSpeed, mSpeed, Tac, Tdc);

            if (XY.Checked)
            {
                Dmc2410.d2410_t_line2(0, dist1, 1, dist2, 0);
            }
            else if (XYZ.Checked)
            {
                Dmc2410.d2410_t_line3( ref Axis[0], dist1, dist2, dist3,0);
            }
            else if (XYZU.Checked)
            {
                Dmc2410.d2410_t_line4(0, dist1, dist2, dist3,dist4 , 0);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_close();    //关闭控制卡
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = "X轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(0))) + "  X轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(0))) +
                 "\r\n" + "Y轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(1))) + "  Y轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(1))) +
                 "\r\n" + "Z轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(2))) + "  Z轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(2))) +
                 "\r\n" + "U轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(3))) + "  U轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(3)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Tdc = Convert.ToDouble(Tdec.Text);
            Dmc2410.d2410_decel_stop(0, Tdc);
            Dmc2410.d2410_decel_stop(1, Tdc);
            Dmc2410.d2410_decel_stop(2, Tdc);
            Dmc2410.d2410_decel_stop(3, Tdc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_set_position(0, 0);
            Dmc2410.d2410_set_position(1, 0);
            Dmc2410.d2410_set_position(2, 0);
            Dmc2410.d2410_set_position(3, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}