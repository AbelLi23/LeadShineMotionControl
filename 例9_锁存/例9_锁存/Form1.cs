using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace 例9_锁存
{
    public partial class Form1 : Form
    {
        
        public long V0 = 0;
        public long temstate;
        public static int i = 0;
        public ushort useCard = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int state = 256;

            temstate = Dmc2410.d2410_get_latch_flag(useCard);


            if ((state & temstate) == state)
            {
                
                textBox1.Text = textBox1.Text + "\r\n" + "X= " + Convert.ToString(Dmc2410.d2410_get_latch_value(0)) +
                    "  " + "Y= " + Convert.ToString(Dmc2410.d2410_get_latch_value(1)) +
                    "  " + "Z= " + Convert.ToString(Dmc2410.d2410_get_latch_value(2)) +
                    "  " + "U= " + Convert.ToString(Dmc2410.d2410_get_latch_value(3));
             }
            Dmc2410.d2410_reset_latch_flag(0);


            //获取位置
            POS1.Text = Convert.ToString(Dmc2410.d2410_get_position(0));
            POS2.Text = Convert.ToString(Dmc2410.d2410_get_position(1));
            POS3.Text = Convert.ToString(Dmc2410.d2410_get_position(2));
            POS4.Text = Convert.ToString(Dmc2410.d2410_get_position(3));

            ENCODER1.Text = Convert.ToString(Dmc2410.d2410_get_encoder(0));
            ENCODER2.Text = Convert.ToString(Dmc2410.d2410_get_encoder(1));
            ENCODER3.Text = Convert.ToString(Dmc2410.d2410_get_encoder(2));
            ENCODER4.Text = Convert.ToString(Dmc2410.d2410_get_encoder(3));

            V1.Text = Convert.ToString(Dmc2410.d2410_read_current_speed(0));
            V2.Text = Convert.ToString(Dmc2410.d2410_read_current_speed(1));
            V3.Text = Convert.ToString(Dmc2410.d2410_read_current_speed(2));
            V4.Text = Convert.ToString(Dmc2410.d2410_read_current_speed(3));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n;

            n = Dmc2410.d2410_board_init();
            if ((n < 1) || (n > 8))
                MessageBox.Show("未找到控制卡", "出错");
            for (ushort  i1 = 0; i1 < 4; i1++)
            {
                Dmc2410.d2410_set_pulse_outmode(i1, 0);
                Dmc2410.d2410_counter_config(i1, 1);             //单轴锁存
                Dmc2410.d2410_config_LTC_PIN(i1, 0, 0);//设置LTC锁存高低电平
            }

            Dmc2410.d2410_config_latch_mode(useCard, 0);
                
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_reset_latch_flag(useCard);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_reset_clear_flag(useCard);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(ushort  q=0;q<4;q++)
            { Dmc2410.d2410_set_encoder(q, 0); }    //清空计数器
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (ushort q = 0; q < 4; q++)
            {
                Dmc2410.d2410_counter_config(q, 0);
                Dmc2410.d2410_set_profile(q, 100, 1000, 0.1, 0.1);
                Dmc2410.d2410_t_vmove(q, 1);   // 1正向运动，0负向运动
            
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}