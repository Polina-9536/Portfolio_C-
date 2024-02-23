using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_ITP_massive_odn;
using DLL_Word;

namespace ITP_LR_Massive
{
    public partial class Form1 : Form
    {
        private string[] answers;
        private string[] operations;
        public Form1()
        {
            InitializeComponent();
        }

        string str_mas;
        int innndex = 0;
        int must_be = 0;

        private void bth_gen_mass_Click(object sender, EventArgs e)
        {
            if (txt_kolvo_el.Text!="0" && txt_kolvo_el.Text != "" && txt_max_znach.Text != "" && txt_min_znach.Text != "")
            {
                int kolvo_el = Convert.ToInt32(txt_kolvo_el.Text);
                int mini = Convert.ToInt32(txt_min_znach.Text);
                int maxi = Convert.ToInt32(txt_max_znach.Text);

                if (mini > maxi)
                {
                    MessageBox.Show("Вы ввели минимальное значение = " + System.Convert.ToString(mini) + ", максимальное значение = " + System.Convert.ToString(maxi) + ". Поскольку введено минимальное значение больше максимального, границы измеенены на (" + System.Convert.ToString(maxi) + "; " + System.Convert.ToString(mini) + ").");
                    int tmp = mini;
                    mini = maxi;
                    maxi = tmp;
                    txt_max_znach.Text = System.Convert.ToString(maxi);
                    txt_min_znach.Text= System.Convert.ToString(mini);
                }

                double[] massive = new double[kolvo_el];
                Random rnd = new Random();
                for (int i = 0; i < kolvo_el; i++)
                    massive[i] = Convert.ToInt32(rnd.Next(mini, maxi));

                string mass_str = Convert.ToString(massive[0]);
                for (int i = 1; i < kolvo_el; i++)
                    mass_str = mass_str + " " + Convert.ToString(massive[i]);

                txt_ishod_mass.Text = mass_str;
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля из следующих: \n«Количество элементов массива»\n«Минимальное значение диапазона»\n«Максимальное значение диапазона»", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_kolvo_el_TextChanged(object sender, EventArgs e)
        {
            DLL_ITP_massive_odn.Class1.clearing(txt_ishod_mass, txt_result);
            str_mas = "";
            answers = null;
            operations = null;
        }

        private void txt_min_znach_TextChanged(object sender, EventArgs e)
        {
            DLL_ITP_massive_odn.Class1.clearing(txt_ishod_mass, txt_result);
            str_mas = "";
            answers = null;
            operations = null;
        }

        private void txt_max_znach_TextChanged(object sender, EventArgs e)
        {
            DLL_ITP_massive_odn.Class1.clearing(txt_ishod_mass, txt_result);
            str_mas = "";
            answers = null;
            operations = null;
        }

        private void txt_kolvo_el_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_ITP_massive_odn.Class1.shield_without_points_and_minus(txt_kolvo_el, e, txt_kolvo_el);
        }

        private void txt_min_znach_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_ITP_massive_odn.Class1.shield_without_points(txt_min_znach, e, txt_min_znach);
        }

        private void txt_max_znach_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_ITP_massive_odn.Class1.shield_without_points(txt_max_znach, e, txt_max_znach);
        }

        private void bth_do_Click(object sender, EventArgs e)
        { 
            if (innndex == must_be)
            {
                answers = new string[8];
                operations = new string[8];
                innndex++;
            }
            if (txt_ishod_mass.Text != "" && txt_ishod_mass.Text != " ")
            {
                try
                {
                    str_mas = txt_ishod_mass.Text;
                    str_mas = str_mas.Trim(new Char[] { ' ' });
                    string[] mass = str_mas.Split(new char[] { ' ' });
                    int lennght = mass.Length;
                    string operationn = "Сумма элементов: ";
                    string answ = "";


                    if (radb_summ.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_summ(ref operationn, ref mass, ref answ);
                        operations[0] = operationn;
                        answers[0] = answ;
                    }

                    else if (radb_srednee.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_sred(ref operationn, ref mass, ref answ);
                        operations[1] = operationn;
                        answers[1] = answ;
                    }

                    else if (radb_min_el.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_mini(ref operationn, ref mass, ref answ);
                        operations[2] = operationn;
                        answers[2] = answ;
                    }

                    else if (radb_max_el.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_maxi(ref operationn, ref mass, ref answ);
                        operations[3] = operationn;
                        answers[3] = answ;
                    }

                    else if (radb_chet_el.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_chet(ref operationn, ref mass, ref answ);
                        operations[4] = operationn;
                        answers[4] = answ;
                    }

                    else if (radb_ne_chet_el.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_nechet(ref operationn, ref mass, ref answ);
                        operations[5] = operationn;
                        answers[5] = answ;
                    }

                    else if (radb_sort_vozrast.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_vozrast(ref operationn, ref mass, ref answ);
                        operations[6] = operationn;
                        answers[6] = answ;
                    }

                    else if (radb_sort_ubivanie.Checked)
                    {
                        DLL_ITP_massive_odn.Class1.mass_ubivanie(ref operationn, ref mass, ref answ);
                        operations[7] = operationn;
                        answers[7] = answ;
                    }

                    txt_result.Text = operationn + answ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка " + ex);
                }
            }

            else
            {
                MessageBox.Show("Поле «Исходный мвссив массив» не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ishod_mass_TextChanged(object sender, EventArgs e)
        {
            txt_result.Text = "";
            str_mas = txt_ishod_mass.Text;
            answers = null;
            operations = null;
        }

        private void txt_ishod_mass_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_ITP_massive_odn.Class1.shield_without_points_with_space(txt_ishod_mass, e, txt_ishod_mass);
        }

        private void bth_from_file_Click(object sender, EventArgs e)
        {
            string new_mass = "";
            DLL_Word.Class1.FromWord(ref new_mass);

            try
            {
                new_mass = Regex.Replace(new_mass, "[^0-9]", " ");
                new_mass = Regex.Replace(new_mass, @"\s+", " ");

                new_mass = new_mass.Trim(new Char[] { ' ' });
                string[] new_masive = new_mass.Split(new char[] { ' ' });
                for (int i = 0; i < new_masive.Length; i++)
                {
                    int a = Convert.ToInt32(new_masive[i]);
                }
                txt_ishod_mass.Text = new_mass;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! В файле должны содержаться только числа в строку через пробел.");
            }

        }

        private void bth_zap_in_fail_Click(object sender, EventArgs e)
        {
            if (operations != null)
            {
                DLL_Word.Class1.ZapWord(operations, answers, str_mas);
                must_be++;
            }
            else
            {
                MessageBox.Show("Не были совершены действия над массивом!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bth_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
