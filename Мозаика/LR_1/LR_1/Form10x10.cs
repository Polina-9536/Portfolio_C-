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
    public partial class Form10x10 : Form
    {
        public Form10x10()
        {
            InitializeComponent();
        }


        private Bitmap[,] bmps = new Bitmap[10, 10];
        private int[] correctOrder = new int[100];
        private int emptyIndex = 99; // индекс пустой картинки

        private void Form10x10_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\Users\\User\\source\\repos\\__C#__new___ITP\\LR_1\\9853.jpg");

            if (img.Width != 930 || img.Height != 600)
            {
                img = null;
                MessageBox.Show("Large size");
            }
            else
            {
                int widthTen = img.Width / 10;      //ширина изображения
                int heightTen = img.Height / 10;       //высота изображения



                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        bmps[i, j] = new Bitmap(widthTen, heightTen);
                        Graphics g = Graphics.FromImage(bmps[i, j]);
                        g.DrawImage(img, new Rectangle(0, 0, widthTen, heightTen), new Rectangle(j * widthTen, i * heightTen, widthTen, heightTen), GraphicsUnit.Pixel);
                        g.Dispose();
                    }
                }

                PictureBox[] pictureBoxes = {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30,
                pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40,
                pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50,
                pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60,
                pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66, pictureBox67, pictureBox68, pictureBox69, pictureBox70,
                pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75, pictureBox76, pictureBox77, pictureBox78, pictureBox79, pictureBox80,
                pictureBox81, pictureBox82, pictureBox83, pictureBox84, pictureBox85, pictureBox86, pictureBox87, pictureBox88, pictureBox89, pictureBox90,
                pictureBox91, pictureBox92, pictureBox93, pictureBox94, pictureBox95, pictureBox96, pictureBox97, pictureBox98, pictureBox99, pictureBox100 };
                bool[] usedIndices = new bool[100];

                for (int i = 0; i < 100; i++)
                {
                    int index;
                    do
                    {
                        index = rnd.Next(0, 100);
                    } while (usedIndices[index]);
                    usedIndices[index] = true;

                    pictureBoxes[i].Image = bmps[index / 10, index % 10];
                    correctOrder[i] = index;

                    pictureBoxes[i].Tag = i;
                }

                pictureBoxes[emptyIndex].Visible = false;
            }
        }


        private void SwapImages(int index1, int index2)
        {
            PictureBox[] pictureBoxes = {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30,
                pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40,
                pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50,
                pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60,
                pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66, pictureBox67, pictureBox68, pictureBox69, pictureBox70,
                pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75, pictureBox76, pictureBox77, pictureBox78, pictureBox79, pictureBox80,
                pictureBox81, pictureBox82, pictureBox83, pictureBox84, pictureBox85, pictureBox86, pictureBox87, pictureBox88, pictureBox89, pictureBox90,
                pictureBox91, pictureBox92, pictureBox93, pictureBox94, pictureBox95, pictureBox96, pictureBox97, pictureBox98, pictureBox99, pictureBox100 };


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
            for (int i = 0; i < 100; i++)
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

            if ((clickedIndex == emptyIndex - 1) || clickedIndex == emptyIndex + 1 || clickedIndex == emptyIndex - 10 || clickedIndex == emptyIndex + 10)
            {
                int row1 = clickedIndex / 10;
                int col1 = clickedIndex % 10;
                int row2 = emptyIndex / 10;
                int col2 = emptyIndex % 10;

                if (row1 == row2 || col1 == col2)
                {
                    SwapImages(clickedIndex, emptyIndex);
                    emptyIndex = clickedIndex;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            changing(pictureBox);
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
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox72.Visible = false;
            pictureBox73.Visible = false;
            pictureBox74.Visible = false;
            pictureBox75.Visible = false;
            pictureBox76.Visible = false;
            pictureBox77.Visible = false;
            pictureBox78.Visible = false;
            pictureBox79.Visible = false;
            pictureBox80.Visible = false;
            pictureBox81.Visible = false;
            pictureBox82.Visible = false;
            pictureBox83.Visible = false;
            pictureBox84.Visible = false;
            pictureBox85.Visible = false;
            pictureBox86.Visible = false;
            pictureBox87.Visible = false;
            pictureBox88.Visible = false;
            pictureBox89.Visible = false;
            pictureBox90.Visible = false;
            pictureBox91.Visible = false;
            pictureBox92.Visible = false;
            pictureBox93.Visible = false;
            pictureBox94.Visible = false;
            pictureBox95.Visible = false;
            pictureBox96.Visible = false;
            pictureBox97.Visible = false;
            pictureBox98.Visible = false;
            pictureBox99.Visible = false;
            pictureBox100.Visible = false;

            pictureBox_Main1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f_pic = new Form_pic();
            f_pic.Show();
        }

        private void Form10x10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
