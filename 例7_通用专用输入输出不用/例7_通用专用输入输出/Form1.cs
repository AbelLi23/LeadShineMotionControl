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
        public bool m = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int n;
            n = Dmc2410.d2410_board_init();   //初始化控制卡
            if (n < 0 || n > 7)
            {
                MessageBox.Show("未找到控制卡", "出错");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_close();    //关闭控制卡
        }
        private void OUT1_Click(object sender, EventArgs e)
        {
            if (m == true)
            {
                OUT1.BackColor = Color.Red;
                m = false;
            }
            else if (m == false)
            {
                OUT1.BackColor = Color.Lime;
                m = true;
            }
        }

        private void OUT2_Click(object sender, EventArgs e)
        {

        }

     
        private void SEVON_B_Click(object sender, EventArgs e)
        {

        }

       
    }
}