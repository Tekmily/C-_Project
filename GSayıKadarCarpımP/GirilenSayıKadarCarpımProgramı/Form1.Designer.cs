namespace GirilenSayıKadarCarpımProgramı
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
            start = new Button();
            input = new TextBox();
            label1 = new Label();
            showbox = new TextBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(8, 613);
            start.Name = "start";
            start.Size = new Size(748, 42);
            start.TabIndex = 0;
            start.Text = "Başlat";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // input
            // 
            input.BackColor = Color.LightCoral;
            input.Location = new Point(8, 27);
            input.Name = "input";
            input.Size = new Size(748, 23);
            input.TabIndex = 1;
            input.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 2;
            label1.Text = "Lütfen 1 ile 15 arasında bir tam sayı giriniz.";
            // 
            // showbox
            // 
            showbox.BackColor = SystemColors.InactiveCaption;
            showbox.Location = new Point(8, 56);
            showbox.Multiline = true;
            showbox.Name = "showbox";
            showbox.Size = new Size(748, 551);
            showbox.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(8, 46);
            progressBar1.Maximum = 1;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(748, 10);
            progressBar1.TabIndex = 5;
            // 
            // Hesaplama_P2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 667);
            Controls.Add(progressBar1);
            Controls.Add(showbox);
            Controls.Add(label1);
            Controls.Add(input);
            Controls.Add(start);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Hesaplama_P2";
            Text = "1 ile 15 Arasındaki Sayıların Matrix Dizilimi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private TextBox input;
        private Label label1;
        private ListBox listBox1;
        private TextBox showbox;
        private ProgressBar progressBar1;
    }
}