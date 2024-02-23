using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_1
{
    public partial class Form5x5 : Form
    {
        public Form5x5()
        {
            InitializeComponent();
        }




        private Bitmap[,] bmps = new Bitmap[5, 5];
        private int[] correctOrder = new int[25];
        private int emptyIndex = 24; // индекс пустой картинки

        private void Form5x5_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\Users\\User\\source\\repos\\__C#__new___ITP\\LR_1\\9853.jpg"); //pict.jpg

            if (img.Width != 930 || img.Height != 600)
            {
                img = null;
                MessageBox.Show("Large size");
            }
            else
            {
                int widthFifth = img.Width / 5;      //ширина пятой части изображения
                int heightFifth = img.Height / 5;       //высота пятой части изображения



                Random rnd = new Random();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        bmps[i, j] = new Bitmap(widthFifth, heightFifth);
                        Graphics g = Graphics.FromImage(bmps[i, j]);
                        g.DrawImage(img, new Rectangle(0, 0, widthFifth, heightFifth), new Rectangle(j * widthFifth, i * heightFifth, widthFifth, heightFifth), GraphicsUnit.Pixel);
                        g.Dispose();
                    }
                }

                PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
                bool[] usedIndices = new bool[25];

                for (int i = 0; i < 25; i++)
                {
                    int index;
                    do
                    {
                        index = rnd.Next(0, 25);
                    } while (usedIndices[index]);
                    usedIndices[index] = true;

                    pictureBoxes[i].Image = bmps[index / 5, index % 5];
                    correctOrder[i] = index;

                    pictureBoxes[i].Tag = i;
                }

                pictureBoxes[emptyIndex].Visible = false;
            }
        }

        private void SwapImages(int index1, int index2)
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };


            // Обмен изображений
            Image temp = pictureBoxes[index1].Image;
            pictureBoxes[index1].Image = pictureBoxes[index2].Image;
            pictureBoxes[index2].Image = temp;


            // Обновление видимости
            pictureBoxes[index1].Visible = false;
            pictureBoxes[index2].Visible = true;


            // Обновление порядка
            int tempOrder = correctOrder[index1];
            correctOrder[index1] = correctOrder[index2];
            correctOrder[index2] = tempOrder;

            // Проверка на победу
            if (CheckWin())
            {
                pictureBoxes[index1].Visible = true;

                MessageBox.Show("Поздравляю, Вы собрали картинку!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool CheckWin()
        {
            for (int i = 0; i < 9; i++)
            {
                if (correctOrder[i] != i)
                {
                    return false;
                }
            }

            return true;
        }


        private void changing(PictureBox pictureBox)
        {
            int clickedIndex = int.Parse(pictureBox.Tag.ToString());

            // Проверка соседства с пустой картинкой

            if ((clickedIndex == emptyIndex - 1) || clickedIndex == emptyIndex + 1 || clickedIndex == emptyIndex - 5 || clickedIndex == emptyIndex + 5)
            {
                int row1 = clickedIndex / 5;
                int col1 = clickedIndex % 5;
                int row2 = emptyIndex / 5;
                int col2 = emptyIndex % 5;

                if (row1 == row2 || col1 == col2)
                {
                    SwapImages(clickedIndex, emptyIndex);
                    emptyIndex = clickedIndex;
                }
            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            changing(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            changing(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            changing(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            changing(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            changing(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            changing(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            changing(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            changing(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            changing(pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            changing(pictureBox10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            changing(pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            changing(pictureBox12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            changing(pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            changing(pictureBox14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            changing(pictureBox15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            changing(pictureBox16);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            changing(pictureBox17);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            changing(pictureBox18);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            changing(pictureBox19);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            changing(pictureBox20);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            changing(pictureBox21);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            changing(pictureBox22);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            changing(pictureBox23);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            changing(pictureBox24);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            changing(pictureBox25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f_main = new Form1();
            f_main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;

            pictureBox_Main1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f_pic = new Form_pic();
            f_pic.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5x5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
