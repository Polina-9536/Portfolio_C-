using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_LR7_ITP
{
    public class Lift
    {
        public static void shield(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox txtbx)
        {
            if (!Char.IsDigit(e.KeyChar))
                // Если нажатая клавиша не является клавишей BackSpace.
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true; // Запрет ввода

            // запрет последовательного ввода после имеющегося нуля
            if (txtbx.Text == "0" && e.KeyChar != 8 && e.KeyChar != ',' || txtbx.Text == "-0" && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            // запрет на ввод нуля при перемещении курсора в начало
            if (e.KeyChar == 48 && txtbx.SelectionStart == 0 && txtbx.Text != "")
                e.Handled = true;
        }

        public static void peop_go_in(TextBox txt, ref int new_peop)
        {
            if (txt.Text != "")
            {
                int cur_peop = System.Convert.ToInt32(txt.Text);
                if (cur_peop < 8)
                {
                    new_peop = cur_peop + 1;
                    txt.Text = System.Convert.ToString(new_peop);
                }
                else
                    MessageBox.Show("Вместимость лифта 8 человек!");
            }
            else
                MessageBox.Show("Заполните поле людей в лифте!");
        }

        public static void peop_go_out(TextBox txt, ref int new_peop)
        {
            if (txt.Text != "")
            {
                int cur_peop = System.Convert.ToInt32(txt.Text);
                if (cur_peop > 0)
                {
                    new_peop = cur_peop - 1;
                    txt.Text = System.Convert.ToString(new_peop);
                }
                else
                    MessageBox.Show("В лифте 0 людей, больше никто выйти не может!");
            }
            else
                MessageBox.Show("Заполните поле людей в лифте!");
        }

        public virtual void lift_go_down(TextBox txt, ref int new_lvl, ref int twice)
        {
            if (txt != null && txt.Text != "")
            {
                twice = 0;
                int cur_lvl = System.Convert.ToInt32(txt.Text);
                if (cur_lvl > 1)
                {
                    twice = 0;
                    new_lvl = cur_lvl - 1;
                    txt.Text = System.Convert.ToString(new_lvl);
                }
                else
                {
                    MessageBox.Show("Лифт не может опуститься ниже 1 этажа!");
                    twice = 1;
                }
            }
            else
                MessageBox.Show("Не введен этаж!");
        }

        public virtual void lift_go_up(TextBox txt, ref int new_lvl, ref int twice)
        {
            if (txt != null && txt.Text != "")
            {
                twice = 0;
                int cur_lvl = System.Convert.ToInt32(txt.Text);
                if (cur_lvl < 7)
                {
                    new_lvl = cur_lvl + 1;
                    txt.Text = System.Convert.ToString(new_lvl);
                    twice = 0;
                }
                else
                {
                    MessageBox.Show("Лифт не может подняться выше 7 этажа!");
                    twice = 1;
                }
            }
            else
                MessageBox.Show("Не введен этаж!");
        }

        public static bool check_people(TextBox txt)
        {
            if (txt.Text != "")
            {
                int cur_peop = System.Convert.ToInt32(txt.Text);
                if (cur_peop == 0)
                {
                    MessageBox.Show("Пустой лифт не может ехать!");
                    return false;
                }
                else if (cur_peop > 8)
                {
                    MessageBox.Show("Лифт переполнен!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Заполните поле людей в лифте!");
                return false;
            }
        }

        public virtual void lvl_change(TextBox txt1, ref int floor, ref int twice1, ref int twice7)
        {
            if (txt1.Text != "")
            {
                floor = System.Convert.ToInt32(txt1.Text);
                if (floor == 0)
                {
                    MessageBox.Show("Лифт не может опуститься ниже 1 этажа!");
                    twice1 = 1;
                }
                else if (floor > 7)
                {
                    MessageBox.Show("Лифт не может подняться выше 7 этажа!");
                    twice7 = 1;
                }
            }
        }
    }




    public class ImprovedLift: Lift
    {
        public override void lift_go_up(TextBox txt, ref int new_lvl, ref int twice)
        {
            base.lift_go_up (txt, ref new_lvl, ref twice);
            switch (new_lvl)
            {
                case 1:
                    MessageBox.Show("Вы на 1 этаже");
                    break;
                case 2:
                    MessageBox.Show("Вы на 2 этаже");
                    break;
                case 3:
                    MessageBox.Show("Вы на 3 этаже");
                    break;
                case 4:
                    MessageBox.Show("Вы на 4 этаже");
                    break;
                case 5:
                    MessageBox.Show("Вы на 5 этаже");
                    break;
                case 6:
                    MessageBox.Show("Вы на 6 этаже");
                    break;
                case 7:
                    if (twice == 0)
                            MessageBox.Show("Вы на 7 этаже");
                    break;
            }    
        }


        public override void lift_go_down(TextBox txt, ref int new_lvl, ref int twice)
        {
            base.lift_go_down(txt, ref new_lvl, ref twice);
            switch (new_lvl)
            {
                case 1:
                    if (twice == 0)
                        MessageBox.Show("Вы на 1 этаже");
                    break;
                case 2:
                    MessageBox.Show("Вы на 2 этаже");
                    break;
                case 3:
                    MessageBox.Show("Вы на 3 этаже");
                    break;
                case 4:
                    MessageBox.Show("Вы на 4 этаже");
                    break;
                case 5:
                    MessageBox.Show("Вы на 5 этаже");
                    break;
                case 6:
                    MessageBox.Show("Вы на 6 этаже");
                    break;
                case 7:
                    MessageBox.Show("Вы на 7 этаже");
                    break;
            }
        }

        public override void lvl_change(TextBox txt1, ref int floor, ref int twice1, ref int twice7)
        {
            base.lvl_change(txt1, ref floor, ref twice1, ref twice7);
            switch (floor)
            {
                case 1:
                    if (twice1 == 0)
                        MessageBox.Show("Вы на 1 этаже");
                    break;
                case 2:
                    MessageBox.Show("Вы на 2 этаже");
                    break;
                case 3:
                    MessageBox.Show("Вы на 3 этаже");
                    break;
                case 4:
                    MessageBox.Show("Вы на 4 этаже");
                    break;
                case 5:
                    MessageBox.Show("Вы на 5 этаже");
                    break;
                case 6:
                    MessageBox.Show("Вы на 6 этаже");
                    break;
                case 7:
                    if (twice7 == 0)
                        MessageBox.Show("Вы на 7 этаже");
                    break;
            }
        }

        public static void pic_visible (PictureBox pb1, PictureBox pb2, PictureBox pb3, PictureBox pb4, PictureBox pb5, PictureBox pb6, PictureBox pb7, int floor)
        {
            switch (floor)
            {
                case 1:
                    pb1.Visible = true;

                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = false;
                    pb6.Visible = false;
                    pb7.Visible = false;
                    break;


                case 2:
                    pb2.Visible = true;

                    pb1.Visible= false;
                    pb3.Visible = false;
                    pb4.Visible= false;
                    pb5.Visible = false;
                    pb6.Visible = false;
                    pb7.Visible = false;
                    break;


                case 3:
                    pb3.Visible = true;

                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = false;
                    pb6.Visible = false;
                    pb7.Visible = false;
                    break;


                case 4:
                    pb4.Visible = true;

                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb5.Visible = false;
                    pb6.Visible = false;
                    pb7.Visible = false;
                    break; 


                case 5:
                    pb5.Visible = true;

                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb6.Visible = false;
                    pb7.Visible = false;
                    break;


                case 6:
                    pb6.Visible = true;

                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = false;
                    pb7.Visible = false;
                    break;


                case 7:
                    pb7.Visible = true;

                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = false;
                    pb6.Visible = false;
                    break;
            }
        }
    }
}
