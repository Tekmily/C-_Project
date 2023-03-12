namespace TextboxsUygulamasıIleCarpma
{
    partial class Hesaplama_P2
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
            shoveResults = new Button();
            response = new Label();
            num3 = new Label();
            num2 = new Label();
            num1 = new Label();
            result = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // shoveResults
            // 
            shoveResults.BackColor = Color.SteelBlue;
            shoveResults.Location = new Point(323, 14);
            shoveResults.Name = "shoveResults";
            shoveResults.Size = new Size(97, 103);
            shoveResults.TabIndex = 17;
            shoveResults.Text = "Sonuç Göster";
            shoveResults.UseVisualStyleBackColor = false;
            shoveResults.Click += shoveResults_Click;
            // 
            // response
            // 
            response.AutoSize = true;
            response.Location = new Point(146, 57);
            response.Name = "response";
            response.Size = new Size(47, 15);
            response.TabIndex = 16;
            response.Text = "SONUÇ";
            // 
            // num3
            // 
            num3.AutoSize = true;
            num3.Location = new Point(247, 9);
            num3.Name = "num3";
            num3.Size = new Size(37, 15);
            num3.TabIndex = 15;
            num3.Text = "3.Sayı";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(146, 9);
            num2.Name = "num2";
            num2.Size = new Size(37, 15);
            num2.TabIndex = 14;
            num2.Text = "2.Sayı";
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(32, 9);
            num1.Name = "num1";
            num1.Size = new Size(37, 15);
            num1.TabIndex = 13;
            num1.Text = "1.Sayı";
            // 
            // result
            // 
            result.BackColor = Color.Orange;
            result.Enabled = false;
            result.Location = new Point(3, 75);
            result.Name = "result";
            result.Size = new Size(312, 23);
            result.TabIndex = 12;
            result.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Olive;
            textBox3.ForeColor = SystemColors.Info;
            textBox3.Location = new Point(215, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Olive;
            textBox2.ForeColor = SystemColors.Info;
            textBox2.Location = new Point(109, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Olive;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(3, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Hesaplama_P2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 125);
            Controls.Add(shoveResults);
            Controls.Add(response);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(result);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Hesaplama_P2";
            Text = "Hesaplama_P2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button shoveResults;
        private Label response;
        private Label num3;
        private Label num2;
        private Label num1;
        private TextBox result;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}