using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例5_圆弧插补
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_close();    //关闭控制卡
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nSpeed, mSpeed;
            double Tac, Tdc;

            nSpeed = Convert.ToInt16(Start_speed.Text);
            mSpeed = int.Parse(Max_speed.Text);
            Tac = double.Parse(Tacc.Text);
            Tdc = Convert.ToDouble(Tdcc.Text);

            ushort[] AxisArray = new ushort[2];
            AxisArray[0] = 0;    //选择的轴号为0轴和1轴
            AxisArray[1] = 1;

           int  []Cen={5000, 0};
           int[] Pos ={ 5000, -5000 };

           Dmc2410.d2410_set_vector_profile(nSpeed, mSpeed, Tac, Tdc);
           Dmc2410.d2410_rel_arc_move(ref AxisArray[0], ref Pos[0], ref Cen[0], 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(0))) + "  X轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(0))) +
                "\r\n" + "Y轴速度：" + Convert.ToString((Dmc2410.d2410_read_current_speed(1))) + "  Y轴位置：" + Convert.ToString((Dmc2410.d2410_get_position(1)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_set_position(0, 0);
            Dmc2410.d2410_set_position(1, 0);

        }

      
    }
}