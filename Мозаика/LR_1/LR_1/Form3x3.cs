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
    public partial class Form3x3 : Form
    {
        public Form3x3()
        {
            InitializeComponent();
        }


        private Bitmap[,] bmps = new Bitmap[3, 3];
        private int[] correctOrder = new int[9];
        private int emptyIndex = 8; // индекс пустой картинки


        private void Form3x3_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("C:\\Users\\User\\source\\repos\\__C#__new___ITP\\LR_1\\9853.jpg");
            if (img.Width != 930 || img.Height != 600)
            {
                img = null;
                MessageBox.Show("Large size");
            }
            else
            {
                int widthThird = img.Width / 3;      //ширина трети изображения
                int heightThird = img.Height / 3;       //высота трети изображения



                Random rnd = new Random();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        bmps[i, j] = new Bitmap(widthThird, heightThird);
                        Graphics g = Graphics.FromImage(bmps[i, j]);
                        g.DrawImage(img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, i * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);
                        g.Dispose();
                    }
                }

                PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
                bool[] usedIndices = new bool[9];

                for (int i = 0; i < 9; i++)
                {
                    int index;
                    do
                    {
                        index = rnd.Next(0, 9);
                    } while (usedIndices[index]);
                    usedIndices[index] = true;

                    pictureBoxes[i].Image = bmps[index / 3, index % 3];
                    correctOrder[i] = index;

                    pictureBoxes[i].Tag = i;
                }

                pictureBoxes[emptyIndex].Visible = false;
            }
        }

        private void SwapImages(int index1, int index2)
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };


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

            if ((clickedIndex == emptyIndex - 1) || clickedIndex == emptyIndex + 1 || clickedIndex == emptyIndex - 3 || clickedIndex == emptyIndex + 3)
            {
                int row1 = clickedIndex / 3;
                int col1 = clickedIndex % 3;
                int row2 = emptyIndex / 3;
                int col2 = emptyIndex % 3;

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


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            pictureBox_Main1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f_main = new Form1();
            f_main.Show();  
            this.Hide();
        }


        private Form_pic f_pic;
        private void button4_Click(object sender, EventArgs e)
        {
            Form f_pic = new Form_pic();
            f_pic.Show();
        }

        private void Form3x3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
