namespace PP_Z11_WinForms_
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
            this.Zadanie = new System.Windows.Forms.GroupBox();
            this.remore = new System.Windows.Forms.Label();
            this.v3 = new System.Windows.Forms.Label();
            this.v2 = new System.Windows.Forms.Label();
            this.t_or_f = new System.Windows.Forms.Label();
            this.v1 = new System.Windows.Forms.Label();
            this.given = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Label();
            this.Zadanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie
            // 
            this.Zadanie.Controls.Add(this.print);
            this.Zadanie.Controls.Add(this.information);
            this.Zadanie.Controls.Add(this.Result);
            this.Zadanie.Controls.Add(this.remore);
            this.Zadanie.Controls.Add(this.v3);
            this.Zadanie.Controls.Add(this.v2);
            this.Zadanie.Controls.Add(this.t_or_f);
            this.Zadanie.Controls.Add(this.v1);
            this.Zadanie.Controls.Add(this.given);
            this.Zadanie.Location = new System.Drawing.Point(12, 12);
            this.Zadanie.Name = "Zadanie";
            this.Zadanie.Size = new System.Drawing.Size(547, 442);
            this.Zadanie.TabIndex = 0;
            this.Zadanie.TabStop = false;
            this.Zadanie.Text = "Задание";
            // 
            // remore
            // 
            this.remore.AutoSize = true;
            this.remore.Location = new System.Drawing.Point(6, 340);
            this.remore.Name = "remore";
            this.remore.Size = new System.Drawing.Size(0, 17);
            this.remore.TabIndex = 7;
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Location = new System.Drawing.Point(6, 323);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(465, 17);
            this.v3.TabIndex = 6;
            this.v3.Text = "Удалить из текста все фрагменты, соответствующие шаблону поля: ";
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Location = new System.Drawing.Point(6, 218);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(509, 17);
            this.v2.TabIndex = 4;
            this.v2.Text = "Вывести на экран все фрагменты текста, соответствующие шаблону поля: ";
            // 
            // t_or_f
            // 
            this.t_or_f.AutoSize = true;
            this.t_or_f.Location = new System.Drawing.Point(6, 180);
            this.t_or_f.Name = "t_or_f";
            this.t_or_f.Size = new System.Drawing.Size(0, 17);
            this.t_or_f.TabIndex = 3;
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Location = new System.Drawing.Point(6, 163);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(529, 17);
            this.v1.TabIndex = 2;
            this.v1.Text = "Определить, содержит ли текст фрагменты, соответствующие шаблону поля: ";
            // 
            // given
            // 
            this.given.AutoSize = true;
            this.given.Location = new System.Drawing.Point(6, 18);
            this.given.Name = "given";
            this.given.Size = new System.Drawing.Size(47, 17);
            this.given.TabIndex = 0;
            this.given.Text = "Дано:";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(152, 373);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(207, 54);
            this.Result.TabIndex = 8;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Location = new System.Drawing.Point(6, 35);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(0, 17);
            this.information.TabIndex = 9;
            // 
            // print
            // 
            this.print.AutoSize = true;
            this.print.Location = new System.Drawing.Point(6, 235);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(0, 17);
            this.print.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 458);
            this.Controls.Add(this.Zadanie);
            this.Name = "Form1";
            this.Text = "Практика 11";
            this.Zadanie.ResumeLayout(false);
            this.Zadanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie;
        private System.Windows.Forms.Label remore;
        private System.Windows.Forms.Label v3;
        private System.Windows.Forms.Label v2;
        private System.Windows.Forms.Label t_or_f;
        private System.Windows.Forms.Label v1;
        private System.Windows.Forms.Label given;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label print;
        private System.Windows.Forms.Label information;
    }
}

