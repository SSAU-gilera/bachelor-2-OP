namespace _1._2_lab8
{
    partial class Task4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.task3 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            this.task1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(40, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(740, 300);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(614, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 78);
            this.button1.TabIndex = 22;
            this.button1.Text = "Boss";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // task3
            // 
            this.task3.BackColor = System.Drawing.Color.White;
            this.task3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.task3.Location = new System.Drawing.Point(419, 12);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(161, 78);
            this.task3.TabIndex = 21;
            this.task3.Text = "Salesman";
            this.task3.UseVisualStyleBackColor = false;
            this.task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // task2
            // 
            this.task2.BackColor = System.Drawing.Color.White;
            this.task2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.task2.Location = new System.Drawing.Point(227, 12);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(159, 78);
            this.task2.TabIndex = 20;
            this.task2.Text = "Clerk";
            this.task2.UseVisualStyleBackColor = false;
            this.task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // task1
            // 
            this.task1.BackColor = System.Drawing.Color.White;
            this.task1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.task1.Location = new System.Drawing.Point(40, 12);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(157, 78);
            this.task1.TabIndex = 19;
            this.task1.Text = "Manager";
            this.task1.UseVisualStyleBackColor = false;
            this.task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.textBox1);
            this.Name = "Task4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать должность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button task3;
        private System.Windows.Forms.Button task2;
        private System.Windows.Forms.Button task1;
    }
}