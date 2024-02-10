namespace _1._2_lab8
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
            this.Task = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Numberofsotrudnikov = new System.Windows.Forms.Label();
            this.dolzhnost = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.zarplata = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.dolzhnosttext = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.task1 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            this.task3 = new System.Windows.Forms.Button();
            this.task4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.num = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Task.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Task.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Task.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Task.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Task.Location = new System.Drawing.Point(726, 16);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(142, 54);
            this.Task.TabIndex = 0;
            this.Task.Text = "Задание";
            this.Task.UseVisualStyleBackColor = false;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лабораторная работа №8\r\nГижевская Валерия, 6113-020302D";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(128, 177);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 25);
            this.name.TabIndex = 2;
            this.name.Text = "Имя:";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Info.Location = new System.Drawing.Point(50, 133);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(338, 29);
            this.Info.TabIndex = 3;
            this.Info.Text = "Информация о сотруднике:";
            // 
            // Numberofsotrudnikov
            // 
            this.Numberofsotrudnikov.AutoSize = true;
            this.Numberofsotrudnikov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Numberofsotrudnikov.Location = new System.Drawing.Point(12, 90);
            this.Numberofsotrudnikov.Name = "Numberofsotrudnikov";
            this.Numberofsotrudnikov.Size = new System.Drawing.Size(443, 31);
            this.Numberofsotrudnikov.TabIndex = 4;
            this.Numberofsotrudnikov.Text = "Введите количество сотрудников:";
            // 
            // dolzhnost
            // 
            this.dolzhnost.AutoSize = true;
            this.dolzhnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dolzhnost.Location = new System.Drawing.Point(128, 222);
            this.dolzhnost.Name = "dolzhnost";
            this.dolzhnost.Size = new System.Drawing.Size(129, 25);
            this.dolzhnost.TabIndex = 5;
            this.dolzhnost.Text = "Должность:";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data.Location = new System.Drawing.Point(447, 222);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(143, 25);
            this.data.TabIndex = 6;
            this.data.Text = "Дата приема:";
            // 
            // zarplata
            // 
            this.zarplata.AutoSize = true;
            this.zarplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zarplata.Location = new System.Drawing.Point(447, 177);
            this.zarplata.Name = "zarplata";
            this.zarplata.Size = new System.Drawing.Size(107, 25);
            this.zarplata.TabIndex = 7;
            this.zarplata.Text = "Зарплата:";
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.menu.Location = new System.Drawing.Point(12, 381);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(286, 36);
            this.menu.TabIndex = 8;
            this.menu.Text = "Меню программы:";
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nametext.Location = new System.Drawing.Point(194, 176);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(211, 26);
            this.nametext.TabIndex = 10;
            // 
            // dolzhnosttext
            // 
            this.dolzhnosttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dolzhnosttext.FormattingEnabled = true;
            this.dolzhnosttext.Items.AddRange(new object[] {
            "Manager",
            "Clerk",
            "Salesman",
            "Boss"});
            this.dolzhnosttext.Location = new System.Drawing.Point(264, 222);
            this.dolzhnosttext.Name = "dolzhnosttext";
            this.dolzhnosttext.Size = new System.Drawing.Size(141, 109);
            this.dolzhnosttext.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(560, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 26);
            this.textBox1.TabIndex = 12;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.White;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enter.Location = new System.Drawing.Point(693, 318);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(98, 39);
            this.enter.TabIndex = 14;
            this.enter.Text = "Ввод";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // task1
            // 
            this.task1.BackColor = System.Drawing.Color.White;
            this.task1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.task1.Location = new System.Drawing.Point(55, 437);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(175, 78);
            this.task1.TabIndex = 15;
            this.task1.Text = "Информация о сотрудниках";
            this.task1.UseVisualStyleBackColor = false;
            this.task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // task2
            // 
            this.task2.BackColor = System.Drawing.Color.White;
            this.task2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.task2.Location = new System.Drawing.Point(264, 437);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(175, 78);
            this.task2.TabIndex = 16;
            this.task2.Text = "Менеджеры, по зарплате";
            this.task2.UseVisualStyleBackColor = false;
            this.task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // task3
            // 
            this.task3.BackColor = System.Drawing.Color.White;
            this.task3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.task3.Location = new System.Drawing.Point(478, 437);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(175, 78);
            this.task3.TabIndex = 17;
            this.task3.Text = "Принятые после босса";
            this.task3.UseVisualStyleBackColor = false;
            this.task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // task4
            // 
            this.task4.BackColor = System.Drawing.Color.White;
            this.task4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.task4.Location = new System.Drawing.Point(693, 437);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(175, 78);
            this.task4.TabIndex = 18;
            this.task4.Text = "Выбрать должность";
            this.task4.UseVisualStyleBackColor = false;
            this.task4.Click += new System.EventHandler(this.Task4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(461, 91);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 30);
            this.numericUpDown1.TabIndex = 19;
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.White;
            this.num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.num.Location = new System.Drawing.Point(574, 90);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(94, 30);
            this.num.TabIndex = 20;
            this.num.Text = "Ввод";
            this.num.UseVisualStyleBackColor = false;
            this.num.Click += new System.EventHandler(this.Num_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 26);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(941, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----------------------\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-9, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(941, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "----------------------\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(922, 543);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dolzhnosttext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.zarplata);
            this.Controls.Add(this.data);
            this.Controls.Add(this.dolzhnost);
            this.Controls.Add(this.Numberofsotrudnikov);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Numberofsotrudnikov;
        private System.Windows.Forms.Label dolzhnost;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label zarplata;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.CheckedListBox dolzhnosttext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Button task2;
        private System.Windows.Forms.Button task3;
        private System.Windows.Forms.Button task4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button num;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

