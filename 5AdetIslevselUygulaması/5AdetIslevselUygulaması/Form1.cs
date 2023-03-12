using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace _5AdetIslevselUygulaması

{
    public partial class Hesaplama_P : Form
    {
        public Hesaplama_P()
        {
            InitializeComponent();



        }



        private void num1_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (num2.Text.Length == 0)
            {
                label3.Text = "Lütfen 1.Sayıyı Giriniz!";

            }
            else
            {
                btnCalculate1.Enabled = true;
            }
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (num1.Text.Length == 0)
            {
                label3.Text = "Lütfen 2.Sayıyı Giriniz!";

            }
            else
            {
                btnCalculate1.Enabled = true;
            }
        }

        private void selectbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num2.Clear();
            num1.Clear();
            num2.Focus();
            progressBar1.Value = 0;
        }



        private void btnCalculate1_Click(object sender, EventArgs e)
        {
            double sum, num1 = 0, num2 = 0;
            string process;
            try
            {
                num1 = Convert.ToInt32(this.num2.Text);
                num2 = Convert.ToInt32(this.num1.Text);
                process = comboBox1.Text;
                if (process != null)
                {

                    btnTransport.Enabled = true;
                    btnTransport.Text = "Listeyi Aktar -->";

                    if (process.Equals("Topla"))
                    {
                        sum = num1 + num2;
                        label3.Text = "Toplam: " + sum;
                        progressBar1.Value = 1;


                    }
                    else if (process.Equals("Cıkar"))
                    {
                        sum = num1 - num2;
                        label3.Text = "Toplam: " + sum;

                        progressBar1.Value = 1;
                    }
                    else if (process.Equals("Böl"))
                    {
                        sum = num1 / num2;
                        label3.Text = "Toplam: " + sum;
                        progressBar1.Value = 1;
                    }
                    else if (process.Equals("Çarp"))
                    {
                        sum = num1 * num2;
                        label3.Text = "Toplam: " + sum;
                        progressBar1.Value = 1;
                    }
                    else if (process.Equals("Islem Sec"))
                    {
                        label3.Text = "İşlem Seçimi Yapmadınız";
                    }
                    else
                    {
                        label3.Text = "İşlem Seçimi Yapmadınız";
                    }

                }
                else
                {
                    label3.Text = "Lütfen 1.Sayı ve 2.Sayı Giriniz";
                }
            }
            catch
            {
                MessageBox.Show("Lütfen 1.Sayı ve 2.Sayı Boş Bırakmayınız veya Yanlış Veri Türü Giriniz");
            }
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {

            if (label3.Equals(label3.Text))
            {
                btnTransport.Enabled = false;
            }
            else
            {
                listBox1.Items.Add(label3.Text);
                label3.Text = "Toplam: ?";
                progressBar1.Value = 0;
            }
        }

        private void Hesaplama_P_Load(object sender, EventArgs e)
        {
            btnCalculate1.Enabled = false;
            btnTransport.Enabled = false;
            if (btnTransport.Enabled != true)
            {

                btnTransport.Text = "------";
            }
        }

        private void dataClean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void selecteClean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems);
        }

        private void dataSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Metin Dosyası (*.txt)|*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                    {
                        foreach (var item in listBox1.Items)
                        {
                            sw.WriteLine(item.ToString());
                            progressBar2.Value = 1;

                        }
                        MessageBox.Show("Dosya başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        progressBar2.Value = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya kaydedilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Title = "Dosya Seç";


            openFileDialog.InitialDirectory = "C:\\";


            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";

            openFileDialog.Multiselect = false;


            ListBox listBox = new ListBox();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(satir);
                        progressBar2.Value = 1;
                    }
                }


                this.Controls.Add(listBox1);
                progressBar2.Value = 0;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addThemes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif, *.bmp)|*.jpg;*.png;*.gif;*.bmp";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                SetFormBackgroundImage(filePath);
            }


        }

        private void removeThemes_Click(object sender, EventArgs e)
        {
            RemoveFormBackgroundImage();
        }
        private void SetFormBackgroundImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
            }
        }


        private void RemoveFormBackgroundImage()
        {
            this.BackgroundImage = null;
        }
    }

}
