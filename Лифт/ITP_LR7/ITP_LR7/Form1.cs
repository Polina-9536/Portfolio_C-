using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_LR7_ITP;
using MediaPlayer;

namespace ITP_LR7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "melody1.wav")); 

        int i = 0;
        int peop = 0;
        int lvl = 1;

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i%2==0)
            {
                if (checkBox1.Checked)
                    sp.Play();
            }
            else
            {
                sp.Stop();
            }
            i++;
        }

        private void bth_Simple_Go_In_Click(object sender, EventArgs e)
        {
            DLL_LR7_ITP.Lift.peop_go_in(txt_people_inside_simple, ref peop);
        }

        private void bth_Simple_Go_Out_Click(object sender, EventArgs e)
        {
            DLL_LR7_ITP.Lift.peop_go_out(txt_people_inside_simple, ref peop);
        }

        private void txt_people_inside_simple_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_LR7_ITP.Lift.shield(txt_people_inside_simple, e, txt_people_inside_simple);
        }
        private void txt_current_lvl_simple_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_LR7_ITP.Lift.shield(txt_current_lvl_simple, e, txt_current_lvl_simple);
        }

        private void bth_Simple_Moving_Up_Click(object sender, EventArgs e)
        {
            if (DLL_LR7_ITP.Lift.check_people(txt_people_inside_simple) == true)
            {
                DLL_LR7_ITP.ImprovedLift.pic_visible(pictureBox01, pictureBox02, pictureBox03, pictureBox04, pictureBox05, pictureBox06, pictureBox07, lvl + 1);
                int twice = 0;
                var mc = new DLL_LR7_ITP.Lift();
                mc.lift_go_up(txt_current_lvl_simple, ref lvl, ref twice);
                txt_current_lvl_simple.Text = System.Convert.ToString(lvl);
                DLL_LR7_ITP.ImprovedLift.pic_visible(pictureBox01, pictureBox02, pictureBox03, pictureBox04, pictureBox05, pictureBox06, pictureBox07, lvl);
            }
        }

        private void bth_Simple_Moving_Down_Click(object sender, EventArgs e)
        {
            if (DLL_LR7_ITP.Lift.check_people(txt_people_inside_simple) == true)
            {
                DLL_LR7_ITP.ImprovedLift.pic_visible(pictureBox01, pictureBox02, pictureBox03, pictureBox04, pictureBox05, pictureBox06, pictureBox07, lvl - 1);
                int twice = 0;
                var mc = new DLL_LR7_ITP.Lift();
                mc.lift_go_down(txt_current_lvl_simple, ref lvl, ref twice);
                txt_current_lvl_simple.Text = System.Convert.ToString(lvl);
                DLL_LR7_ITP.ImprovedLift.pic_visible(pictureBox01, pictureBox02, pictureBox03, pictureBox04, pictureBox05, pictureBox06, pictureBox07, lvl);
            }
        }

        private void bth_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int peop1 = 0;
        int lvl1 = 1;

        private void bth_Improved_Go_In_Click(object sender, EventArgs e)
        {
            DLL_LR7_ITP.Lift.peop_go_in(txt_people_inside_impr, ref peop1);
        }

        private void bth_Improved_Go_Out_Click(object sender, EventArgs e)
        {
            DLL_LR7_ITP.Lift.peop_go_out(txt_people_inside_impr, ref peop1);
        }

        private void txt_people_inside_impr_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_LR7_ITP.Lift.shield(txt_people_inside_impr, e, txt_people_inside_impr);
        }

        private void txt_current_lvl_impr_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_LR7_ITP.Lift.shield(txt_current_lvl_impr, e, txt_current_lvl_impr);
        }

        private void bth_Improved_Moving_Up_Click(object sender, EventArgs e)
        {
            if (DLL_LR7_ITP.Lift.check_people(txt_people_inside_impr) == true)
            {
                if (txt_current_lvl_impr.Text == "7")
                {
                    DLL_LR7_ITP.ImprovedLift.pic_visible(pic_1, pic_2, pic_3, pic_4, pic_5, pic_6, pic_7, 7);
                    MessageBox.Show("Лифт не может подняться выше 7 этажа!");
                }
                else
                {
                    DLL_LR7_ITP.ImprovedLift.pic_visible(pic_1, pic_2, pic_3, pic_4, pic_5, pic_6, pic_7, lvl1 + 1);
                    int twice = 0;
                    var mc = new DLL_LR7_ITP.ImprovedLift();
                    mc.lift_go_up(txt_current_lvl_impr, ref lvl1, ref twice);
                    DLL_LR7_ITP.ImprovedLift.pic_visible(pic_1, pic_2, pic_3, pic_4, pic_5, pic_6, pic_7, lvl1);
                }
            }
        }

        private void bth_Improved_Moving_Down_Click(object sender, EventArgs e)
        {
            if (DLL_LR7_ITP.Lift.check_people(txt_people_inside_impr) == true)
            {
                if (txt_current_lvl_impr.Text == "1")
                {
                    DLL_LR7_ITP.ImprovedLift.pic_visible(pic_1, pic_2, pic_3, pic_4, pic_5, pic_6, pic_7, 1);
                    MessageBox.Show("Лифт не может опуститься ниже 1 этажа!");
                }
                else
                {
                    DLL_LR7_ITP.ImprovedLift.pic_visible(pic_1, pic_2, pic_3, pic_4, pic_5, pic_6, pic_7, lvl1-1);
                    int twice = 0;
                    var mc = new DLL_LR7_ITP.ImprovedLift();
                    mc.lift_go_down(txt_current_lvl_impr, ref lvl1, ref twice);
                    txt_current_lvl_impr.Text = System.Convert.ToString(lvl1);
                    DLL_LR7_ITP.ImprovedLift.pic_visible(pic_1, pic_2, pic_3, pic_4, pic_5, pic_6, pic_7, lvl1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                sp.Play();
                sp.PlayLooping();
            }
            else
            {
                sp.Stop();
            }
        }

        private void txt_current_lvl_simple_KeyUp(object sender, KeyEventArgs e)
        {
            if (DLL_LR7_ITP.Lift.check_people(txt_people_inside_simple) == true)
            {
                    int floor = 0;
                    int twice1 = 0;
                    int twice7 = 0;

                    var mc = new DLL_LR7_ITP.Lift();
                    mc.lvl_change(txt_current_lvl_simple, ref floor, ref twice1, ref twice7);
                    DLL_LR7_ITP.ImprovedLift.pic_visible(pictureBox01, pictureBox02, pictureBox03, pictureBox04, pictureBox05, pictureBox06, pictureBox07, floor);
            }
        }

        private void txt_current_lvl_impr_KeyUp(object sender, KeyEventArgs e)
        {
            if (DLL_LR7_ITP.Lift.check_people(txt_people_inside_impr) == true)
            {
                int floor = 0;
                if (txt_current_lvl_impr.Text !="")
                {
                    floor = System.Convert.ToInt32(txt_current_lvl_impr.Text);
                }
                int twice1 = 0;
                int twice7 = 0;

                DLL_LR7_ITP.ImprovedLift.pic_visible(pic_1, pic_2, pic_3, pic_4, pic_5, pic_6, pic_7, floor);
                var mc = new DLL_LR7_ITP.ImprovedLift();
                mc.lvl_change(txt_current_lvl_impr, ref floor, ref twice1, ref twice7);

            }
        }
    }
}
