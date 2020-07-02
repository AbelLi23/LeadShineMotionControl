using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
 

namespace csDmc2410
{
    public class Dmc2410
    {
        //---------------------   板卡初始和配置函数  ----------------------
        /********************************************************************************
        ** 函数名称: d2410_board_init
        ** 功能描述: 控制板初始化，设置初始化和速度等设置
        ** 输　  入: 无
        ** 返 回 值: 0：无卡； 1-8：成功(实际卡数) 
        **           1001 + j: j号卡初始化出错 从1001开始。
        ** 修    改:  
        ** 修改日期: 
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_board_init", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt16 d2410_board_init();

        /********************************************************************************
        ** 函数名称: d2410_board_close
        ** 功能描述: 关闭所有卡
        ** 输　  入: 无
        ** 返 回 值: 无
        ** 日    期: 
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_board_close", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_board_close();

        /********************************************************************************
        ** 函数名称: 控制卡复位
        ** 功能描述: 复位所有卡，只能在初始化完成之后调用．
        ** 输　  入: 无
        ** 返 回 值: 无
        ** 日    期: 
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_board_rest", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_board_rest();




        //脉冲输入输出配置
        /********************************************************************************
        ** 函数名称: d2410_set_pulse_outmode
        ** 功能描述: 脉冲输出方式的设置
        ** 输　  入: axis - (0 - 3), outmode: 0 - 7
        **           6:正交脉冲，A相超前; 7:正交脉冲，B相超前
        ** 返 回 值: 无 
        ** 修改日期：2007.1.27
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_pulse_outmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_pulse_outmode(UInt16 axis, UInt16 outmode);

        //专用信号设置函数
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_SD_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_SD_PIN(UInt16 axis, UInt16 enable, UInt16 sd_logic, UInt16 sd_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_PCS_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_PCS_PIN(UInt16 axis, UInt16 enable, UInt16 pcs_logic);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_INP_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_INP_PIN(UInt16 axis, UInt16 enable, UInt16 inp_logic);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_ERC_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_ERC_PIN(UInt16 axis, UInt16 enable, UInt16 erc_logic, UInt16 erc_width, UInt16 erc_off_time);

        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_ALM_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_ALM_PIN(UInt16 axis, UInt16 alm_logic, UInt16 alm_action);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_EL_MODE", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_EL_MODE(UInt16 axis, UInt16 el_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_HOME_pin_logic", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_HOME_pin_logic(UInt16 axis, UInt16 org_logic, UInt16 filter);

        [DllImport("Dmc2410.dll", EntryPoint = "d2410_write_SEVON_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_write_SEVON_PIN(UInt16 axis, UInt16 on_off);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_SEVON_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_SEVON_PIN(UInt16 axis);

        [DllImport("Dmc2410.dll", EntryPoint = "d2410_write_ERC_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_write_ERC_PIN(UInt16 axis, UInt16 sel);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_RDY_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_RDY_PIN(UInt16 axis);

        //通用输入/输出控制函数
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_inbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_inbit(UInt16 cardno, UInt16 bitno);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_write_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_write_outbit(UInt16 cardno, UInt16 bitno, UInt16 on_off);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_outbit(UInt16 cardno, UInt16 bitno);

        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_inport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_inport(UInt16 cardno);

        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_outport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_outport(UInt16 cardno);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_write_outport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_write_outport(UInt16 cardno, UInt32 port_value);

        //制动函数
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_decel_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_decel_stop(UInt16 axis, double Tdec);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_imd_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_imd_stop(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_emg_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_emg_stop();
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_simultaneous_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_simultaneous_stop(UInt16 axis);

        //位置设置和读取函数
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_get_position(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_position(UInt16 axis, Int32 current_position);

        //状态检测函数
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_check_done", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt16 d2410_check_done(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_prebuff_status", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt16 d2410_prebuff_status(UInt16 axis);

        [DllImport("Dmc2410.dll", EntryPoint = "d2410_axis_io_status", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt16 d2410_axis_io_status(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_axis_status", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt16 d2410_axis_status(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_rsts", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 d2410_get_rsts(UInt16 axis);

        //速度设置
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_variety_speed_range", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_variety_speed_range(UInt16 axis, UInt16 chg_enable, double Max_Vel);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_current_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern double d2410_read_current_speed(UInt16 axis);

        [DllImport("Dmc2410.dll", EntryPoint = "d2410_change_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_change_speed(UInt16 axis, double Curr_Vel);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_vector_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_vector_profile(double Min_Vel, double Max_Vel, double Tacc, double Tdec);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_profile(UInt16 axis, double Min_Vel, double Max_Vel, double Tacc, double Tdec);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_s_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_s_profile(UInt16 axis, double Min_Vel, double Max_Vel, double Tacc, double Tdec, Int32 Sacc, Int32 Sdec);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_st_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_st_profile(UInt16 axis, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double Tsacc, double Tsdec);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_reset_target_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_reset_target_position(UInt16 axis, Int32 dist);

        //单轴定长运动
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_t_pmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_t_pmove(UInt16 axis, Int32 Dist, UInt16 posi_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_ex_t_pmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_ex_t_pmove(UInt16 axis, Int32 Dist, UInt16 posi_mode);


        [DllImport("Dmc2410.dll", EntryPoint = "d2410_s_pmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_s_pmove(UInt16 axis, Int32 Dist, UInt16 posi_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_ex_s_pmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_ex_s_pmove(UInt16 axis, Int32 Dist, UInt16 posi_mode);

        //单轴连续运动
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_s_vmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_s_vmove(UInt16 axis, UInt16 dir);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_t_vmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_t_vmove(UInt16 axis, UInt16 dir);

        //线性插补
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_t_line2", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_t_line2(UInt16 axis1, Int32 Dist1, UInt16 axis2, Int32 Dist2, UInt16 posi_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_t_line3", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_t_line3(ref UInt16 axis, Int32 Dist1, Int32 Dist2, Int32 Dist3, UInt16 posi_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_t_line4", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_t_line4(UInt16 cardno, Int32 Dist1, Int32 Dist2, Int32 Dist3, Int32 Dist4, UInt16 posi_mode);


        //手轮运动
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_handwheel_inmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_handwheel_inmode(UInt16 axis, UInt16 inmode, UInt16 count_dir);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_handwheel_move", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_handwheel_move(UInt16 axis, double vh);

        //找原点
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_home_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_home_mode(UInt16 axis, UInt16 mode, UInt16 EZ_count);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_home_move", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_home_move(UInt16 axis, UInt16 home_mode, UInt16 vel_mode);

        //圆弧插补
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_arc_move", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_arc_move(ref UInt16 axis, ref Int32 target_pos, ref Int32 cen_pos, UInt16 arc_dir);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_rel_arc_move", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_rel_arc_move(ref UInt16 axis, ref Int32 rel_pos, ref Int32 rel_cen, UInt16 arc_dir);

        //脉冲当量设置和椭圆插补, 脉冲闭环
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_equiv", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_get_equiv(UInt16 axis, ref double equiv);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_equiv", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_set_equiv(UInt16 axis, double new_equiv);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_position_unitmm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_get_position_unitmm(UInt16 axis, ref double pos_by_mm);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_position_unitmm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_set_position_unitmm(UInt16 axis, double pos_by_mm);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_current_speed_unitmm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_current_speed_unitmm(UInt16 axis, ref double current_speed);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_encoder_unitmm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_get_encoder_unitmm(UInt16 axis, ref double encoder_pos_by_mm);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_encoder_unitmm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_set_encoder_unitmm(UInt16 axis, double encoder_pos_by_mm);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_arc_move_unitmm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_arc_move_unitmm(ref UInt16 axis, ref double target_pos, ref double cen_pos, UInt16 arc_dir);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_rel_arc_move_unitmm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_rel_arc_move_unitmm(ref UInt16 axis, ref double rel_pos, ref double rel_cen, UInt16 arc_dir);

        //设置和读取位置比较信号
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_CMP_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_CMP_PIN(UInt16 axis, UInt16 cmp1_enable, UInt16 cmp2_enable, UInt16 CMP_logic);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_read_CMP_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_read_CMP_PIN(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_write_CMP_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_write_CMP_PIN(UInt16 axis, UInt16 on_off);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_comparator", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_comparator(UInt16 axis, UInt16 cmp1_condition, UInt16 cmp2_condition, UInt16 source_sel, UInt16 SL_action);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_comparator_data", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_comparator_data(UInt16 axis, UInt32 cmp1_data, UInt32 cmp2_data);



        //---------------------   编码器计数功能PLD  ----------------------//
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_encoder", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 d2410_get_encoder(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_encoder", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_encoder(UInt16 axis, UInt32 encoder_value);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_EZ_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_EZ_PIN(UInt16 axis, UInt16 ez_logic, UInt16 ez_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_LTC_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_LTC_PIN(UInt16 axis, UInt16 ltc_logic, UInt16 ltc_mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_latch_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_latch_mode(UInt16 cardno, UInt16 all_enable);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_counter_config", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_counter_config(UInt16 axis, UInt16 mode);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_latch_value", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 d2410_get_latch_value(UInt16 axis);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_latch_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 d2410_get_latch_flag(UInt16 cardno);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_reset_latch_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_reset_latch_flag(UInt16 cardno);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_get_counter_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 d2410_get_counter_flag(UInt16 cardno);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_reset_counter_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_reset_counter_flag(UInt16 cardno);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_reset_clear_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_reset_clear_flag(UInt16 cardno);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_triger_chunnel", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_triger_chunnel(UInt16 cardno, UInt16 num);
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_speaker_logic", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_set_speaker_logic(UInt16 cardno, UInt16 logic);

        //other
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_EMG_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void d2410_config_EMG_PIN(UInt16 cardno, UInt16 enable, UInt16 emg_logic);


        //增加同时起停操作
        /********************************************************************************
        ** 函数名称: d2410_set_t_move_all
        ** 功能描述: 多轴同步运动设定
        ** 输　  入: TotalAxes: 轴数,  pAxis:轴列表, pDist:位移列表
                     posi_mode: 0-相对, 1-绝对
        ** 返 回 值: 1:正确 , -1:参数错
        ** 
        ** 全局变量: 无
        ** 修改内容: 
        ** 修改日期:   
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_t_move_all", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_set_t_move_all(UInt16 TotalAxes, ref UInt16 pAxis, ref UInt32 pDist, UInt16 posi_mode);

        /********************************************************************************
        ** 函数名称: d2410_start_move_all
        ** 功能描述: 多轴同步运动
        ** 输　  入: TotalAxes: 第一轴轴号
        ** 返 回 值: 1:正确 , -1:参数错
        ** 
        ** 全局变量: 无
        ** 修改内容: 
        ** 修改日期:      
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_start_move_all", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_start_move_all(UInt16 FirstAxis);

        /********************************************************************************
        ** 函数名称: d2410_set_sync_option
        ** 功能描述: 多轴同步选项设定, 注意: 使用后必须关闭此功能, 将sync_option1清0.
        ** 输　  入: axis:轴号
                     sync_stop_on: 1:当CSTOP 信号来时,轴停止; 
                     cstop_output_on: 当异常停止时输出 CSTOP信号
                     sync_option1: 0:立即启动, 1: 等待CSTA信号 或是启动命令 
                     sync_option2: 无用
        ** 返 回 值: 1:正确 , -1:参数错
        ** 
        ** 全局变量: 无
        ** 修改内容: 
        ** 修改日期:     
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_sync_option", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_set_sync_option(UInt16 axis, UInt16 sync_stop_on, UInt16 cstop_output_on, UInt16 sync_option1, UInt16 sync_option2);

        /********************************************************************************
        ** 函数名称: d2410_set_sync_stop_mode
        ** 功能描述: 设置同步停止的减速方式
        ** 输　  入: axis: 轴号
                     stop_mode:  0- 立即停止, 1-减速停止
        ** 返 回 值: 1:正确 , -1:参数错
        ** 
        ** 全局变量: 无
        ** 修改内容: 
        ** 修改日期:      
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_set_sync_stop_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_set_sync_stop_mode(UInt16 axis, UInt16 stop_mode);

        /********************************************************************************
        ** 函数名称: d2410_config_CSTA_PIN
        ** 功能描述: 设置同步启动信号, 只能为低有效, 配置为电平或是边沿信号触发,默认为电平触发
        ** 输　  入: axis: 轴号
                     edge_mode:  0- 电平, 1-边沿
        ** 返 回 值: 1
        ** 
        ** 全局变量: 无
        ** 修改内容: 
        ** 修改日期: 
        *********************************************************************************/
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_config_CSTA_PIN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_config_CSTA_PIN(UInt16 axis, UInt16 edge_mode);


        //脉冲闭环操作
        [DllImport("Dmc2410.dll", EntryPoint = "d2410_pulse_loop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 d2410_pulse_loop(UInt16 axis); 
    }
}
