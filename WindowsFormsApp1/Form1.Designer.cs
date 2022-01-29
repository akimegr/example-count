
namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.field_x = new System.Windows.Forms.TextBox();
            this.field_y = new System.Windows.Forms.TextBox();
            this.field_z = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(325, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // field_x
            // 
            this.field_x.Location = new System.Drawing.Point(407, 24);
            this.field_x.Name = "field_x";
            this.field_x.Size = new System.Drawing.Size(157, 22);
            this.field_x.TabIndex = 1;
            this.field_x.Text = "1";
            this.field_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // field_y
            // 
            this.field_y.Location = new System.Drawing.Point(407, 73);
            this.field_y.Name = "field_y";
            this.field_y.Size = new System.Drawing.Size(157, 22);
            this.field_y.TabIndex = 2;
            this.field_y.Text = "2";
            this.field_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // field_z
            // 
            this.field_z.Location = new System.Drawing.Point(407, 121);
            this.field_z.Name = "field_z";
            this.field_z.Size = new System.Drawing.Size(157, 22);
            this.field_z.TabIndex = 3;
            this.field_z.Text = "3";
            this.field_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите значение X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(211, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите значение Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(211, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите значение Z:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.field_z);
            this.Controls.Add(this.field_y);
            this.Controls.Add(this.field_x);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox field_x;
        private System.Windows.Forms.TextBox field_y;
        private System.Windows.Forms.TextBox field_z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

