namespace TekDugmeyleEkranaVeriYazma
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
            calculateshow = new Button();
            listBox1 = new ListBox();
            close = new Button();
            SuspendLayout();
            // 
            // calculateshow
            // 
            calculateshow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calculateshow.BackColor = SystemColors.ActiveCaption;
            calculateshow.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            calculateshow.ForeColor = SystemColors.ControlDarkDark;
            calculateshow.Location = new Point(0, 610);
            calculateshow.Name = "calculateshow";
            calculateshow.Size = new Size(151, 94);
            calculateshow.TabIndex = 0;
            calculateshow.Text = "Göster";
            calculateshow.UseVisualStyleBackColor = false;
            calculateshow.Click += calculateshow_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.WindowFrame;
            listBox1.Dock = DockStyle.Top;
            listBox1.ForeColor = SystemColors.Info;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 604);
            listBox1.TabIndex = 1;
            // 
            // close
            // 
            close.BackColor = Color.Red;
            close.Dock = DockStyle.Bottom;
            close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = Color.Yellow;
            close.Location = new Point(0, 709);
            close.Name = "close";
            close.Size = new Size(151, 38);
            close.TabIndex = 2;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(151, 747);
            ControlBox = false;
            Controls.Add(close);
            Controls.Add(listBox1);
            Controls.Add(calculateshow);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button calculateshow;
        private ListBox listBox1;
        private Button close;
    }
}