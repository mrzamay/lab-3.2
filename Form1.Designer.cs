namespace TestInput
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRez = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(163, 25);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(47, 20);
            this.tbA.TabIndex = 0;
            this.tbA.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "a =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "b =";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(163, 58);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(47, 20);
            this.tbB.TabIndex = 3;
            this.tbB.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат";
            // 
            // tbRez
            // 
            this.tbRez.Location = new System.Drawing.Point(163, 149);
            this.tbRez.Name = "tbRez";
            this.tbRez.ReadOnly = true;
            this.tbRez.Size = new System.Drawing.Size(47, 20);
            this.tbRez.TabIndex = 5;
            this.tbRez.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "d =";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(163, 91);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(47, 20);
            this.tbD.TabIndex = 9;
            this.tbD.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Пример обработки ошибок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRez;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbD;
    }
}

