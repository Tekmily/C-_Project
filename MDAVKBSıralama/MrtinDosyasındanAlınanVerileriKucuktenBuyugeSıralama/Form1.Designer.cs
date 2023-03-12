namespace MrtinDosyasındanAlınanVerileriKucuktenBuyugeSıralama
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
            openFilesTxt = new Button();
            Clean = new Button();
            textBoxMonitor = new TextBox();
            textV = new TextBox();
            SuspendLayout();
            // 
            // openFilesTxt
            // 
            openFilesTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            openFilesTxt.Location = new Point(2, 464);
            openFilesTxt.Name = "openFilesTxt";
            openFilesTxt.Size = new Size(318, 60);
            openFilesTxt.TabIndex = 0;
            openFilesTxt.Text = "İçe Aktar";
            openFilesTxt.UseVisualStyleBackColor = true;
            openFilesTxt.Click += openFilesTxt_Click;
            // 
            // Clean
            // 
            Clean.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Clean.Location = new Point(326, 464);
            Clean.Name = "Clean";
            Clean.Size = new Size(157, 60);
            Clean.TabIndex = 1;
            Clean.Text = "Ekranı Temizle";
            Clean.UseVisualStyleBackColor = true;
            Clean.Click += Clean_Click;
            // 
            // textBoxMonitor
            // 
            textBoxMonitor.Dock = DockStyle.Top;
            textBoxMonitor.Location = new Point(0, 0);
            textBoxMonitor.Multiline = true;
            textBoxMonitor.Name = "textBoxMonitor";
            textBoxMonitor.Size = new Size(484, 458);
            textBoxMonitor.TabIndex = 2;
            // 
            // textV
            // 
            textV.Location = new Point(0, 0);
            textV.Name = "textV";
            textV.Size = new Size(8, 23);
            textV.TabIndex = 3;
            textV.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 524);
            Controls.Add(textV);
            Controls.Add(textBoxMonitor);
            Controls.Add(Clean);
            Controls.Add(openFilesTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFilesTxt;
        private Button Clean;
        private TextBox textBoxMonitor;
        private TextBox textV;
    }
}