namespace Complex
{
    partial class ComplexForm
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
            this.textBoxRe = new System.Windows.Forms.TextBox();
            this.textBoxIm = new System.Windows.Forms.TextBox();
            this.textBoxToAlg = new System.Windows.Forms.TextBox();
            this.textBoxToModule = new System.Windows.Forms.TextBox();
            this.textBoxToAngle = new System.Windows.Forms.TextBox();
            this.buttonAlgToExp = new System.Windows.Forms.Button();
            this.buttonExpToAlg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMod = new System.Windows.Forms.TextBox();
            this.textBoxAng = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRe
            // 
            this.textBoxRe.Location = new System.Drawing.Point(22, 88);
            this.textBoxRe.Name = "textBoxRe";
            this.textBoxRe.Size = new System.Drawing.Size(100, 20);
            this.textBoxRe.TabIndex = 0;
            // 
            // textBoxIm
            // 
            this.textBoxIm.Location = new System.Drawing.Point(170, 88);
            this.textBoxIm.Name = "textBoxIm";
            this.textBoxIm.Size = new System.Drawing.Size(100, 20);
            this.textBoxIm.TabIndex = 1;
            // 
            // textBoxToAlg
            // 
            this.textBoxToAlg.Location = new System.Drawing.Point(487, 266);
            this.textBoxToAlg.Name = "textBoxToAlg";
            this.textBoxToAlg.ReadOnly = true;
            this.textBoxToAlg.Size = new System.Drawing.Size(146, 20);
            this.textBoxToAlg.TabIndex = 2;
            // 
            // textBoxToModule
            // 
            this.textBoxToModule.Location = new System.Drawing.Point(487, 88);
            this.textBoxToModule.Name = "textBoxToModule";
            this.textBoxToModule.ReadOnly = true;
            this.textBoxToModule.Size = new System.Drawing.Size(70, 20);
            this.textBoxToModule.TabIndex = 5;
            // 
            // textBoxToAngle
            // 
            this.textBoxToAngle.Location = new System.Drawing.Point(572, 88);
            this.textBoxToAngle.Name = "textBoxToAngle";
            this.textBoxToAngle.ReadOnly = true;
            this.textBoxToAngle.Size = new System.Drawing.Size(61, 20);
            this.textBoxToAngle.TabIndex = 6;
            // 
            // buttonAlgToExp
            // 
            this.buttonAlgToExp.Location = new System.Drawing.Point(340, 86);
            this.buttonAlgToExp.Name = "buttonAlgToExp";
            this.buttonAlgToExp.Size = new System.Drawing.Size(120, 23);
            this.buttonAlgToExp.TabIndex = 7;
            this.buttonAlgToExp.Text = "Перевести";
            this.buttonAlgToExp.UseVisualStyleBackColor = true;
            this.buttonAlgToExp.Click += new System.EventHandler(this.buttonAlgToExp_Click);
            // 
            // buttonExpToAlg
            // 
            this.buttonExpToAlg.Location = new System.Drawing.Point(340, 266);
            this.buttonExpToAlg.Name = "buttonExpToAlg";
            this.buttonExpToAlg.Size = new System.Drawing.Size(120, 23);
            this.buttonExpToAlg.TabIndex = 8;
            this.buttonExpToAlg.Text = "Перевести";
            this.buttonExpToAlg.UseVisualStyleBackColor = true;
            this.buttonExpToAlg.Click += new System.EventHandler(this.buttonExpToAlg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(224, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Модуль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(184, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Аргумент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(500, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Модуль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(569, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Аргумент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(142, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(415, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Из алгебраической в показательную";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(142, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(415, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Из показательной в алгебраическую";
            // 
            // textBoxMod
            // 
            this.textBoxMod.Location = new System.Drawing.Point(22, 269);
            this.textBoxMod.Name = "textBoxMod";
            this.textBoxMod.Size = new System.Drawing.Size(100, 20);
            this.textBoxMod.TabIndex = 17;
            // 
            // textBoxAng
            // 
            this.textBoxAng.Location = new System.Drawing.Point(170, 269);
            this.textBoxAng.Name = "textBoxAng";
            this.textBoxAng.Size = new System.Drawing.Size(100, 20);
            this.textBoxAng.TabIndex = 18;
            // 
            // ComplexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(649, 339);
            this.Controls.Add(this.textBoxAng);
            this.Controls.Add(this.textBoxMod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExpToAlg);
            this.Controls.Add(this.buttonAlgToExp);
            this.Controls.Add(this.textBoxToAngle);
            this.Controls.Add(this.textBoxToModule);
            this.Controls.Add(this.textBoxToAlg);
            this.Controls.Add(this.textBoxIm);
            this.Controls.Add(this.textBoxRe);
            this.MaximumSize = new System.Drawing.Size(665, 378);
            this.MinimumSize = new System.Drawing.Size(665, 378);
            this.Name = "ComplexForm";
            this.Text = "Перевод комплексных чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRe;
        private System.Windows.Forms.TextBox textBoxIm;
        private System.Windows.Forms.TextBox textBoxToAlg;
        private System.Windows.Forms.TextBox textBoxToModule;
        private System.Windows.Forms.TextBox textBoxToAngle;
        private System.Windows.Forms.Button buttonAlgToExp;
        private System.Windows.Forms.Button buttonExpToAlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMod;
        private System.Windows.Forms.TextBox textBoxAng;
    }
}

