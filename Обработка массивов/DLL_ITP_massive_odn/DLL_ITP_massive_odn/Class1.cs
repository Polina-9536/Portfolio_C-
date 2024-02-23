using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace DLL_ITP_massive_odn
{
    public class Class1
    {
        public static void shield_without_points(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox txtbx)
        {
            if (!Char.IsDigit(e.KeyChar))
                // Запрет на ввод более одного знака минуса.
                if (e.KeyChar != '-' || txtbx.Text.IndexOf('-') != -1)
                    // Если нажатая клавиша не является клавишей BackSpace.
                    if (e.KeyChar != (char)Keys.Back)
                        e.Handled = true; // Запрет ввода

            // запрет последовательного ввода после имеющегося нуля
            if (txtbx.Text == "0" && e.KeyChar != 8 && e.KeyChar != ',' || txtbx.Text == "-0" && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            // запрет на ввод нуля при перемещении курсора в начало
            if (e.KeyChar == 48 && txtbx.SelectionStart == 0 && txtbx.Text != "")
                e.Handled = true;

            // Перенос точки ввода минуса в начало (ввод минуса только спереди)
            if (e.KeyChar == '-' && txtbx.Text.IndexOf('-') == -1)
                txtbx.SelectionStart = 0; // Текстовый курсор в начало
        }

        public static void shield_without_points_and_minus(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox txtbx)
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

        public static void shield_without_points_with_space(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox txtbx)
        {
            // Проверяем, является ли введенный символ цифрой, пробелом или минусом
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Запрещаем ввод символа
                return;
            }

            // Проверяем, является ли введенный символ пробелом
            if (e.KeyChar == ' ')
            {
                // Проверяем, есть ли уже пробелы перед текущим символом
                int selectionStart = txtbx.SelectionStart;
                if (selectionStart > 0 && txtbx.Text[selectionStart - 1] == ' ')
                {
                    e.Handled = true; // Запрещаем ввод больше одного пробела подряд
                }
                if (selectionStart > 0 && txtbx.Text[selectionStart - 1] == '-')
                {
                    e.Handled = true; // Запрещаем ввод больше одного пробела подряд
                }
                return;
            }

            // Проверяем, является ли введенный символ минусом
            if (e.KeyChar == '-')
            {
                // Проверяем, есть ли уже минус перед текущим символом
                int selectionStart = txtbx.SelectionStart;
                if (selectionStart > 0 && txtbx.Text[selectionStart - 1] == '-')
                {
                    e.Handled = true; // Запрещаем ввод больше одного минуса подряд
                }
                if (selectionStart > 0 && txtbx.Text[selectionStart - 1] != ' ')
                {
                    e.Handled = true; // Запрещаем ввод больше одного минуса подряд
                }
                return;
            }

            // Проверяем, является ли введенный символ 0
            if (e.KeyChar == '0')
            {
                // Проверяем, есть ли уже 0 перед текущим символом
                int selectionStart = txtbx.SelectionStart;
                if (selectionStart > 0 && txtbx.Text[selectionStart - 1] == '0')
                {
                    e.Handled = true; // Запрещаем ввод больше одного минуса подряд
                }
                if (selectionStart > 0 && txtbx.Text[selectionStart - 1] == '-')
                {
                    e.Handled = true; // Запрещаем ввод больше одного минуса подряд
                }
                return;
            }
        }


        public static void clearing(System.Windows.Forms.TextBox txtbx1, System.Windows.Forms.TextBox txtbx2) 
        {
            txtbx1.Text = "";
            txtbx2.Text = "";
        }

        public static void mass_summ(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Сумма элементов: ";
            int lennght = mass.Length;
            int summ = 0;
            for (int i = 0; i < lennght; i++)
            {
                summ += System.Convert.ToInt32(mass[i]);
            }
            answ = System.Convert.ToString(summ);
        }


        public static void mass_sred(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Среднее значение: ";
            int lennght = mass.Length;
            int summ = 0;
            for (int i = 0; i < lennght; i++)
            {
                summ += System.Convert.ToInt32(mass[i]);
            }
            answ = System.Convert.ToString(summ / mass.Length);
        }


        public static void mass_mini(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Минимальный элемент: ";
            int lennght = mass.Length;
            int mini = System.Convert.ToInt32(mass[0]);
            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(mass[i]);
                if (a < mini)
                {
                    mini = a;
                }
            }
            answ = System.Convert.ToString(mini);

        }


        public static void mass_maxi(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Максимальный элемент: ";
            int lennght = mass.Length;
            int maxi = System.Convert.ToInt32(mass[0]);
            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(mass[i]);
                if (a > maxi)
                {
                    maxi = a;
                }
            }
            answ = System.Convert.ToString(maxi);
        }


        public static void mass_chet(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Четные элементы: ";
            int lennght = mass.Length;
            int[] chet = new int[lennght];
            int numb = 0;
            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(mass[i]);
                if (a % 2 == 0)
                {
                    chet[numb] = a;
                    numb++;
                }
            }

            for (int i = 0; i < numb; i++)
            {
                int a = System.Convert.ToInt32(chet[i]);
                answ += a + " ";
            }
            answ = answ.Trim(new Char[] { ' ' });

            if (answ == "")
            {
                answ = "Четных элементов нет!";
            }
        }


        public static void mass_nechet(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Нечетные элементы: ";
            int lennght = mass.Length;
            int[] nechet = new int[lennght];
            int numb = 0;
            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(mass[i]);
                if (a % 2 != 0)
                {
                    nechet[numb] = a;
                    numb++;
                }
            }

            for (int i = 0; i < numb; i++)
            {
                int a = System.Convert.ToInt32(nechet[i]);
                answ += a + " ";
            }
            answ = answ.Trim(new Char[] { ' ' });

            if (answ == "")
            {
                answ = "Нечетных элементов нет!";
            }
        }


        public static void mass_vozrast(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Сортировка по возрастанию: ";
            int lennght = mass.Length;
            int[] arr = new int[lennght];
            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(mass[i]);
                arr[i] = a;
            }

            Array.Sort(arr);

            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(arr[i]);
                answ += a + " ";
            }
            answ = answ.Trim(new Char[] { ' ' });
        }


        public static void mass_ubivanie(ref string operationn, ref string[] mass, ref string answ)
        {
            operationn = "Сортировка по убыванию: ";
            int lennght = mass.Length;
            int[] arr = new int[lennght];
            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(mass[i]);
                arr[i] = a;
            }

            Array.Sort(arr, (x, y) => y.CompareTo(x));

            for (int i = 0; i < lennght; i++)
            {
                int a = System.Convert.ToInt32(arr[i]);
                answ += a + " ";
            }
            answ = answ.Trim(new Char[] { ' ' });
        }

    }
}
