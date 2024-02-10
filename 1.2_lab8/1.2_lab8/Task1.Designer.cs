namespace _1._2_lab8
{
    partial class Task1
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
            this.zadanie1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zadanie1
            // 
            this.zadanie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.zadanie1.Location = new System.Drawing.Point(40, 40);
            this.zadanie1.Multiline = true;
            this.zadanie1.Name = "zadanie1";
            this.zadanie1.Size = new System.Drawing.Size(740, 365);
            this.zadanie1.TabIndex = 0;
            this.zadanie1.Text = "ИМЯ      ДОЛЖНОСТЬ       ЗАРПЛАТА              ДАТА";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.zadanie1);
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о сотрудниках";
            this.Load += new System.EventHandler(this.Task1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zadanie1;
    }
}