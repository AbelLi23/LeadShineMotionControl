using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例7_通用专用输入输出
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "输入1口：" + Convert.ToString(Dmc2410.d2410_read_inbit(0, 1)) + "  输入2口：" + Convert.ToString(Dmc2410.d2410_read_inbit(0, 2)) +
                "  输入3口：" + Convert.ToString(Dmc2410.d2410_read_inbit(0, 3)) + "  输入4口：" + Convert.ToString(Dmc2410.d2410_read_inbit(0, 4));

            label2.Text = "X轴原点：" + Convert.ToString(Dmc2410.d2410_axis_io_status(0) & (2 ^ 14));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Dmc2410.d2410_write_outbit(0, 1, 0);
                checkBox1.Text = "输出口1：高电平";

            }
            else
            {
                Dmc2410.d2410_write_outbit(0, 1, 1);
                checkBox1.Text = "输出口1：低电平";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                Dmc2410.d2410_write_outbit(0, 2, 0);
                checkBox2.Text = "输出口2：高电平";

            }
            else
            {
                Dmc2410.d2410_write_outbit(0, 2, 1);
                checkBox2.Text = "输出口2：低电平";

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                Dmc2410.d2410_write_outbit(0, 3, 0);
                checkBox3.Text = "输出口3：高电平";

            }
            else
            {
                Dmc2410.d2410_write_outbit(0, 3, 1);
                checkBox3.Text = "输出口3：低电平";

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Checked)
            {
                Dmc2410.d2410_write_outbit(0, 4, 0);
                checkBox4.Text = "输出口4：高电平";

            }
            else
            {
                Dmc2410.d2410_write_outbit(0, 4, 1);
                checkBox4.Text = "输出口4：低电平";

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.CheckState == CheckState.Checked)
            {
                Dmc2410.d2410_write_SEVON_PIN(0, 0);
                checkBox5.Text = "伺服使能：ON";
            }
            else
            {
                Dmc2410.d2410_write_SEVON_PIN(0, 1);
                checkBox5.Text = "伺服使能：OFF";
            }
        }
    }
}