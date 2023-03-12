namespace _5AdetIslevselUygulaması
{
    partial class Hesaplama_P
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
            progressBar2 = new ProgressBar();
            listBox1 = new ListBox();
            dataOpen = new Button();
            dataSave = new Button();
            selecteClean = new Button();
            dataClean = new Button();
            btnTransport = new Button();
            btnCalculate1 = new Button();
            btn_Clear = new Button();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            comboBox1 = new ComboBox();
            num2 = new TextBox();
            num1 = new TextBox();
            label2 = new Label();
            addThemes = new Button();
            removeThemes = new Button();
            SuspendLayout();
            // 
            // progressBar2
            // 
            progressBar2.Anchor = AnchorStyles.None;
            progressBar2.BackColor = Color.DarkOliveGreen;
            progressBar2.Cursor = Cursors.AppStarting;
            progressBar2.ForeColor = Color.YellowGreen;
            progressBar2.Location = new Point(407, 6);
            progressBar2.Maximum = 1;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(368, 10);
            progressBar2.TabIndex = 73;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.Anchor = AnchorStyles.None;
            listBox1.BackColor = Color.MistyRose;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Cursor = Cursors.Hand;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Maroon;
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.AlphaFull;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(407, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(368, 240);
            listBox1.TabIndex = 68;
            // 
            // dataOpen
            // 
            dataOpen.Anchor = AnchorStyles.None;
            dataOpen.Location = new Point(781, 198);
            dataOpen.Name = "dataOpen";
            dataOpen.Size = new Size(101, 28);
            dataOpen.TabIndex = 72;
            dataOpen.Text = "Veri Al";
            dataOpen.UseVisualStyleBackColor = true;
            dataOpen.Click += dataOpen_Click;
            // 
            // dataSave
            // 
            dataSave.Anchor = AnchorStyles.None;
            dataSave.BackColor = Color.GreenYellow;
            dataSave.ForeColor = Color.Navy;
            dataSave.Location = new Point(781, 232);
            dataSave.Name = "dataSave";
            dataSave.Size = new Size(101, 28);
            dataSave.TabIndex = 71;
            dataSave.Text = "Kaydet";
            dataSave.UseVisualStyleBackColor = false;
            dataSave.Click += dataSave_Click;
            // 
            // selecteClean
            // 
            selecteClean.Anchor = AnchorStyles.None;
            selecteClean.BackColor = Color.Brown;
            selecteClean.ForeColor = SystemColors.Control;
            selecteClean.Location = new Point(781, 2);
            selecteClean.Name = "selecteClean";
            selecteClean.Size = new Size(101, 28);
            selecteClean.TabIndex = 70;
            selecteClean.Text = "Seçili Olanı Sil";
            selecteClean.UseVisualStyleBackColor = false;
            selecteClean.Click += selecteClean_Click;
            // 
            // dataClean
            // 
            dataClean.Anchor = AnchorStyles.None;
            dataClean.BackColor = Color.DarkRed;
            dataClean.ForeColor = SystemColors.ControlLightLight;
            dataClean.Location = new Point(781, 43);
            dataClean.Name = "dataClean";
            dataClean.Size = new Size(101, 28);
            dataClean.TabIndex = 69;
            dataClean.Text = "Data Temizle";
            dataClean.UseVisualStyleBackColor = false;
            dataClean.Click += dataClean_Click;
            // 
            // btnTransport
            // 
            btnTransport.Anchor = AnchorStyles.None;
            btnTransport.BackColor = Color.Goldenrod;
            btnTransport.Location = new Point(177, 94);
            btnTransport.Name = "btnTransport";
            btnTransport.Size = new Size(158, 38);
            btnTransport.TabIndex = 67;
            btnTransport.Text = "Listeye Akatar -->";
            btnTransport.UseVisualStyleBackColor = false;
            btnTransport.Click += btnTransport_Click;
            // 
            // btnCalculate1
            // 
            btnCalculate1.Anchor = AnchorStyles.None;
            btnCalculate1.BackColor = Color.YellowGreen;
            btnCalculate1.Location = new Point(6, 49);
            btnCalculate1.Name = "btnCalculate1";
            btnCalculate1.Size = new Size(330, 39);
            btnCalculate1.TabIndex = 66;
            btnCalculate1.Text = "Hesapla";
            btnCalculate1.UseVisualStyleBackColor = false;
            btnCalculate1.Click += btnCalculate1_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Anchor = AnchorStyles.None;
            btn_Clear.BackColor = Color.DarkRed;
            btn_Clear.Location = new Point(6, 94);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(165, 38);
            btn_Clear.TabIndex = 65;
            btn_Clear.Text = "Temizle";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(8, 148);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 64;
            label3.Text = "Toplam :  ?";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.BackColor = Color.DarkOliveGreen;
            progressBar1.Cursor = Cursors.AppStarting;
            progressBar1.ForeColor = Color.YellowGreen;
            progressBar1.Location = new Point(1, 266);
            progressBar1.Maximum = 1;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(896, 18);
            progressBar1.TabIndex = 63;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(25, 2);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 60;
            label1.Text = "1.Sayı";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = SystemColors.GradientInactiveCaption;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Topla", "Cıkar", "Böl", "Çarp" });
            comboBox1.Location = new Point(120, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(102, 23);
            comboBox1.TabIndex = 62;
            comboBox1.Text = "Islem Sec";
            // 
            // num2
            // 
            num2.Anchor = AnchorStyles.None;
            num2.Cursor = Cursors.IBeam;
            num2.Location = new Point(228, 20);
            num2.Name = "num2";
            num2.Size = new Size(105, 23);
            num2.TabIndex = 58;
            num2.TextAlign = HorizontalAlignment.Center;
            num2.TextChanged += num2_TextChanged;
            // 
            // num1
            // 
            num1.Anchor = AnchorStyles.None;
            num1.BackColor = SystemColors.Window;
            num1.Cursor = Cursors.IBeam;
            num1.Location = new Point(8, 20);
            num1.Name = "num1";
            num1.Size = new Size(106, 23);
            num1.TabIndex = 59;
            num1.TextAlign = HorizontalAlignment.Center;
            num1.TextChanged += num1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(272, 2);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 61;
            label2.Text = "2.Sayı";
            // 
            // addThemes
            // 
            addThemes.BackColor = Color.ForestGreen;
            addThemes.ForeColor = Color.Ivory;
            addThemes.Location = new Point(218, 278);
            addThemes.Name = "addThemes";
            addThemes.Size = new Size(679, 38);
            addThemes.TabIndex = 74;
            addThemes.Text = "Tema Ekle";
            addThemes.UseVisualStyleBackColor = false;
            addThemes.Click += addThemes_Click;
            // 
            // removeThemes
            // 
            removeThemes.BackColor = Color.Brown;
            removeThemes.ForeColor = Color.MistyRose;
            removeThemes.Location = new Point(1, 278);
            removeThemes.Name = "removeThemes";
            removeThemes.Size = new Size(222, 38);
            removeThemes.TabIndex = 75;
            removeThemes.Text = "Tema Kaldırma";
            removeThemes.UseVisualStyleBackColor = false;
            removeThemes.Click += removeThemes_Click;
            // 
            // Hesaplama_P
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 318);
            Controls.Add(removeThemes);
            Controls.Add(addThemes);
            Controls.Add(progressBar2);
            Controls.Add(listBox1);
            Controls.Add(dataOpen);
            Controls.Add(dataSave);
            Controls.Add(selecteClean);
            Controls.Add(dataClean);
            Controls.Add(btnTransport);
            Controls.Add(btnCalculate1);
            Controls.Add(btn_Clear);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Hesaplama_P";
            RightToLeft = RightToLeft.No;
            Text = "Hesaplama_P";
            Load += Hesaplama_P_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalculate_Click;
        private Button btnCalculate;
        private ProgressBar progressBar2;
        private ListBox listBox1;
        private Button dataOpen;
        private Button dataSave;
        private Button selecteClean;
        private Button dataClean;
        private Button btnTransport;
        private Button btnCalculate1;
        private Button btn_Clear;
        private Label label3;
        private ProgressBar progressBar1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox num2;
        private TextBox num1;
        private Label label2;
        private Button addThemes;
        private Button removeThemes;
    }
}