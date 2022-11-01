namespace GUI_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_first_number = new System.Windows.Forms.TextBox();
            this.textBox2_second_number = new System.Windows.Forms.TextBox();
            this.textBox3_therd_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_first_number
            // 
            this.textBox1_first_number.Location = new System.Drawing.Point(37, 36);
            this.textBox1_first_number.Name = "textBox1_first_number";
            this.textBox1_first_number.Size = new System.Drawing.Size(129, 23);
            this.textBox1_first_number.TabIndex = 1;
            this.textBox1_first_number.TextChanged += new System.EventHandler(this.textBox1_first_number_TextChanged);
            // 
            // textBox2_second_number
            // 
            this.textBox2_second_number.Location = new System.Drawing.Point(191, 36);
            this.textBox2_second_number.Name = "textBox2_second_number";
            this.textBox2_second_number.Size = new System.Drawing.Size(128, 23);
            this.textBox2_second_number.TabIndex = 2;
            this.textBox2_second_number.TextChanged += new System.EventHandler(this.textBox2_second_number_TextChanged);
            // 
            // textBox3_therd_number
            // 
            this.textBox3_therd_number.Location = new System.Drawing.Point(338, 36);
            this.textBox3_therd_number.Name = "textBox3_therd_number";
            this.textBox3_therd_number.Size = new System.Drawing.Size(125, 23);
            this.textBox3_therd_number.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите первое число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите второе число";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите третье число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 153);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3_therd_number);
            this.Controls.Add(this.textBox2_second_number);
            this.Controls.Add(this.textBox1_first_number);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Прооизведение наименьших чисел";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1_first_number;
        private TextBox textBox2_second_number;
        private TextBox textBox3_therd_number;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}