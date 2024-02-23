namespace ITP_LR_Massive
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_kolvo_el = new System.Windows.Forms.TextBox();
            this.txt_min_znach = new System.Windows.Forms.TextBox();
            this.txt_max_znach = new System.Windows.Forms.TextBox();
            this.txt_ishod_mass = new System.Windows.Forms.TextBox();
            this.radb_summ = new System.Windows.Forms.RadioButton();
            this.radb_srednee = new System.Windows.Forms.RadioButton();
            this.radb_min_el = new System.Windows.Forms.RadioButton();
            this.radb_max_el = new System.Windows.Forms.RadioButton();
            this.radb_sort_ubivanie = new System.Windows.Forms.RadioButton();
            this.radb_sort_vozrast = new System.Windows.Forms.RadioButton();
            this.radb_ne_chet_el = new System.Windows.Forms.RadioButton();
            this.radb_chet_el = new System.Windows.Forms.RadioButton();
            this.bth_gen_mass = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.bth_do = new System.Windows.Forms.Button();
            this.bth_from_file = new System.Windows.Forms.Button();
            this.bth_zap_in_fail = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bth_close = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество элементов массива:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Минимальное значение диапазона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Максимальное значение диапазона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(34, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Исходный массив:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(34, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Операции с массивом:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(34, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Результат операции:";
            // 
            // txt_kolvo_el
            // 
            this.txt_kolvo_el.Location = new System.Drawing.Point(339, 62);
            this.txt_kolvo_el.Name = "txt_kolvo_el";
            this.txt_kolvo_el.Size = new System.Drawing.Size(100, 22);
            this.txt_kolvo_el.TabIndex = 9;
            this.txt_kolvo_el.TextChanged += new System.EventHandler(this.txt_kolvo_el_TextChanged);
            this.txt_kolvo_el.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kolvo_el_KeyPress);
            // 
            // txt_min_znach
            // 
            this.txt_min_znach.Location = new System.Drawing.Point(339, 90);
            this.txt_min_znach.Name = "txt_min_znach";
            this.txt_min_znach.Size = new System.Drawing.Size(100, 22);
            this.txt_min_znach.TabIndex = 10;
            this.txt_min_znach.TextChanged += new System.EventHandler(this.txt_min_znach_TextChanged);
            this.txt_min_znach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_min_znach_KeyPress);
            // 
            // txt_max_znach
            // 
            this.txt_max_znach.Location = new System.Drawing.Point(339, 117);
            this.txt_max_znach.Name = "txt_max_znach";
            this.txt_max_znach.Size = new System.Drawing.Size(100, 22);
            this.txt_max_znach.TabIndex = 11;
            this.txt_max_znach.TextChanged += new System.EventHandler(this.txt_max_znach_TextChanged);
            this.txt_max_znach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_max_znach_KeyPress);
            // 
            // txt_ishod_mass
            // 
            this.txt_ishod_mass.Location = new System.Drawing.Point(37, 243);
            this.txt_ishod_mass.Multiline = true;
            this.txt_ishod_mass.Name = "txt_ishod_mass";
            this.txt_ishod_mass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ishod_mass.Size = new System.Drawing.Size(402, 65);
            this.txt_ishod_mass.TabIndex = 12;
            this.txt_ishod_mass.TextChanged += new System.EventHandler(this.txt_ishod_mass_TextChanged);
            this.txt_ishod_mass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ishod_mass_KeyPress);
            // 
            // radb_summ
            // 
            this.radb_summ.AutoSize = true;
            this.radb_summ.Checked = true;
            this.radb_summ.Location = new System.Drawing.Point(57, 358);
            this.radb_summ.Name = "radb_summ";
            this.radb_summ.Size = new System.Drawing.Size(146, 20);
            this.radb_summ.TabIndex = 14;
            this.radb_summ.TabStop = true;
            this.radb_summ.Text = "Сумма элементов\r\n";
            this.radb_summ.UseVisualStyleBackColor = true;
            // 
            // radb_srednee
            // 
            this.radb_srednee.AutoSize = true;
            this.radb_srednee.Location = new System.Drawing.Point(57, 384);
            this.radb_srednee.Name = "radb_srednee";
            this.radb_srednee.Size = new System.Drawing.Size(152, 20);
            this.radb_srednee.TabIndex = 15;
            this.radb_srednee.TabStop = true;
            this.radb_srednee.Text = "Среднее значение";
            this.radb_srednee.UseVisualStyleBackColor = true;
            // 
            // radb_min_el
            // 
            this.radb_min_el.AutoSize = true;
            this.radb_min_el.Location = new System.Drawing.Point(57, 410);
            this.radb_min_el.Name = "radb_min_el";
            this.radb_min_el.Size = new System.Drawing.Size(179, 20);
            this.radb_min_el.TabIndex = 16;
            this.radb_min_el.TabStop = true;
            this.radb_min_el.Text = "Минимальный элемент";
            this.radb_min_el.UseVisualStyleBackColor = true;
            // 
            // radb_max_el
            // 
            this.radb_max_el.AutoSize = true;
            this.radb_max_el.Location = new System.Drawing.Point(57, 436);
            this.radb_max_el.Name = "radb_max_el";
            this.radb_max_el.Size = new System.Drawing.Size(185, 20);
            this.radb_max_el.TabIndex = 17;
            this.radb_max_el.TabStop = true;
            this.radb_max_el.Text = "Максимальный элемент";
            this.radb_max_el.UseVisualStyleBackColor = true;
            // 
            // radb_sort_ubivanie
            // 
            this.radb_sort_ubivanie.AutoSize = true;
            this.radb_sort_ubivanie.Location = new System.Drawing.Point(253, 436);
            this.radb_sort_ubivanie.Name = "radb_sort_ubivanie";
            this.radb_sort_ubivanie.Size = new System.Drawing.Size(196, 20);
            this.radb_sort_ubivanie.TabIndex = 21;
            this.radb_sort_ubivanie.TabStop = true;
            this.radb_sort_ubivanie.Text = "Сортировка по убыванию";
            this.radb_sort_ubivanie.UseVisualStyleBackColor = true;
            // 
            // radb_sort_vozrast
            // 
            this.radb_sort_vozrast.AutoSize = true;
            this.radb_sort_vozrast.Location = new System.Drawing.Point(253, 410);
            this.radb_sort_vozrast.Name = "radb_sort_vozrast";
            this.radb_sort_vozrast.Size = new System.Drawing.Size(217, 20);
            this.radb_sort_vozrast.TabIndex = 20;
            this.radb_sort_vozrast.TabStop = true;
            this.radb_sort_vozrast.Text = "Сортировка по возрастанию";
            this.radb_sort_vozrast.UseVisualStyleBackColor = true;
            // 
            // radb_ne_chet_el
            // 
            this.radb_ne_chet_el.AutoSize = true;
            this.radb_ne_chet_el.Location = new System.Drawing.Point(253, 384);
            this.radb_ne_chet_el.Name = "radb_ne_chet_el";
            this.radb_ne_chet_el.Size = new System.Drawing.Size(162, 20);
            this.radb_ne_chet_el.TabIndex = 19;
            this.radb_ne_chet_el.TabStop = true;
            this.radb_ne_chet_el.Text = "Нечетные элементы";
            this.radb_ne_chet_el.UseVisualStyleBackColor = true;
            // 
            // radb_chet_el
            // 
            this.radb_chet_el.AutoSize = true;
            this.radb_chet_el.Location = new System.Drawing.Point(253, 358);
            this.radb_chet_el.Name = "radb_chet_el";
            this.radb_chet_el.Size = new System.Drawing.Size(145, 20);
            this.radb_chet_el.TabIndex = 18;
            this.radb_chet_el.TabStop = true;
            this.radb_chet_el.Text = "Четные элементы";
            this.radb_chet_el.UseVisualStyleBackColor = true;
            // 
            // bth_gen_mass
            // 
            this.bth_gen_mass.BackColor = System.Drawing.Color.GhostWhite;
            this.bth_gen_mass.Location = new System.Drawing.Point(37, 157);
            this.bth_gen_mass.Name = "bth_gen_mass";
            this.bth_gen_mass.Size = new System.Drawing.Size(402, 46);
            this.bth_gen_mass.TabIndex = 22;
            this.bth_gen_mass.Text = "Генерация массива";
            this.bth_gen_mass.UseVisualStyleBackColor = false;
            this.bth_gen_mass.Click += new System.EventHandler(this.bth_gen_mass_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(37, 562);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_result.Size = new System.Drawing.Size(402, 65);
            this.txt_result.TabIndex = 23;
            // 
            // bth_do
            // 
            this.bth_do.BackColor = System.Drawing.Color.GhostWhite;
            this.bth_do.Location = new System.Drawing.Point(37, 479);
            this.bth_do.Name = "bth_do";
            this.bth_do.Size = new System.Drawing.Size(402, 46);
            this.bth_do.TabIndex = 24;
            this.bth_do.Text = "Выполнить";
            this.bth_do.UseVisualStyleBackColor = false;
            this.bth_do.Click += new System.EventHandler(this.bth_do_Click);
            // 
            // bth_from_file
            // 
            this.bth_from_file.BackColor = System.Drawing.Color.GhostWhite;
            this.bth_from_file.Location = new System.Drawing.Point(482, 111);
            this.bth_from_file.Name = "bth_from_file";
            this.bth_from_file.Size = new System.Drawing.Size(122, 197);
            this.bth_from_file.TabIndex = 25;
            this.bth_from_file.Text = "Ввод из файла";
            this.bth_from_file.UseVisualStyleBackColor = false;
            this.bth_from_file.Click += new System.EventHandler(this.bth_from_file_Click);
            // 
            // bth_zap_in_fail
            // 
            this.bth_zap_in_fail.BackColor = System.Drawing.Color.GhostWhite;
            this.bth_zap_in_fail.Location = new System.Drawing.Point(482, 331);
            this.bth_zap_in_fail.Name = "bth_zap_in_fail";
            this.bth_zap_in_fail.Size = new System.Drawing.Size(122, 194);
            this.bth_zap_in_fail.TabIndex = 26;
            this.bth_zap_in_fail.Text = "Запись в файл";
            this.bth_zap_in_fail.UseVisualStyleBackColor = false;
            this.bth_zap_in_fail.Click += new System.EventHandler(this.bth_zap_in_fail_Click);
            // 
            // bth_close
            // 
            this.bth_close.BackColor = System.Drawing.Color.GhostWhite;
            this.bth_close.Location = new System.Drawing.Point(482, 562);
            this.bth_close.Name = "bth_close";
            this.bth_close.Size = new System.Drawing.Size(122, 65);
            this.bth_close.TabIndex = 27;
            this.bth_close.Text = "Закрыть";
            this.bth_close.UseVisualStyleBackColor = false;
            this.bth_close.Click += new System.EventHandler(this.bth_close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(629, 650);
            this.Controls.Add(this.bth_close);
            this.Controls.Add(this.bth_zap_in_fail);
            this.Controls.Add(this.bth_from_file);
            this.Controls.Add(this.bth_do);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.bth_gen_mass);
            this.Controls.Add(this.radb_sort_ubivanie);
            this.Controls.Add(this.radb_sort_vozrast);
            this.Controls.Add(this.radb_ne_chet_el);
            this.Controls.Add(this.radb_chet_el);
            this.Controls.Add(this.radb_max_el);
            this.Controls.Add(this.radb_min_el);
            this.Controls.Add(this.radb_srednee);
            this.Controls.Add(this.radb_summ);
            this.Controls.Add(this.txt_ishod_mass);
            this.Controls.Add(this.txt_max_znach);
            this.Controls.Add(this.txt_min_znach);
            this.Controls.Add(this.txt_kolvo_el);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Обработка массива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_kolvo_el;
        private System.Windows.Forms.TextBox txt_min_znach;
        private System.Windows.Forms.TextBox txt_max_znach;
        private System.Windows.Forms.TextBox txt_ishod_mass;
        private System.Windows.Forms.RadioButton radb_summ;
        private System.Windows.Forms.RadioButton radb_srednee;
        private System.Windows.Forms.RadioButton radb_min_el;
        private System.Windows.Forms.RadioButton radb_max_el;
        private System.Windows.Forms.RadioButton radb_sort_ubivanie;
        private System.Windows.Forms.RadioButton radb_sort_vozrast;
        private System.Windows.Forms.RadioButton radb_ne_chet_el;
        private System.Windows.Forms.RadioButton radb_chet_el;
        private System.Windows.Forms.Button bth_gen_mass;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button bth_do;
        private System.Windows.Forms.Button bth_from_file;
        private System.Windows.Forms.Button bth_zap_in_fail;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bth_close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

