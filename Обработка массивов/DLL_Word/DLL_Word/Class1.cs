using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;


namespace DLL_Word
{
    public class Class1
    {
        public static void ZapWord(string[] operations, string[] answers, string ish_mass)
        {
            // Создаем экземпляр диалогового окна SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Устанавливаем фильтр для диалогового окна, чтобы пользователь мог выбрать только файлы Word
            saveFileDialog.Filter = "Документ Word (*.docx)|*.docx";

            // Отображаем диалоговое окно и проверяем результат
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный путь и имя файла
                string filePath = saveFileDialog.FileName;

                // Создаем экземпляр приложения Word
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                // Создаем новый документ Word
                Document wordDoc = wordApp.Documents.Add();

                // Добавляем строки в документ
                wordDoc.Content.Text = "Операции над одномерным массивом";
                wordDoc.Content.Text += "Исходный массив: " + ish_mass;
                for (int i = 0; i < 8; i++)
                {
                    if (operations[i] != null && answers[i] != null)
                    {
                        wordDoc.Content.Text += operations[i] + answers[i];
                    }
                }

                // Сохраняем документ по указанному пути
                wordDoc.SaveAs(filePath);

                // Закрываем документ и приложение Word
                wordDoc.Close();
                wordApp.Quit();

                MessageBox.Show("Файл Word успешно создан.");
            }
        }



        public static void FromWord(ref string content)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Документы Word (*.docx)|*.docx|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                object missing = System.Reflection.Missing.Value;
                object readOnly = true;

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDoc = wordApp.Documents.Open(openFileDialog.FileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

                content = wordDoc.Content.Text;

                wordDoc.Close();
                wordApp.Quit();
            }
        }
    }
}
