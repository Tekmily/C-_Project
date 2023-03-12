namespace Fibonacci_Hesaplama
{
    partial class Hesaplama_P3
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
            button1 = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(159, 52);
            button1.TabIndex = 0;
            button1.Text = "Fibonacci Sırasını Bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 49);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(159, 23);
            txtInput.TabIndex = 1;
            txtInput.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Gold;
            lblResult.ForeColor = Color.DarkRed;
            lblResult.Location = new Point(14, 31);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(131, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Fibonacci sayısı: 159358";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(7, 11);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 3;
            label1.Text = "! İlk İki Sayı 1 Olarak Hesaplanır";
            // 
            // Hesaplama_P3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(185, 142);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Hesaplama_P3";
            Text = "Fibonacci Sayı Sırası Hesaplama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtInput;
        private Label lblResult;
        private Label label1;
    }
}