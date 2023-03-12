using System.Text;

namespace GirilenSayıKadarCarpımProgramı
{
    public partial class Hesaplama_P2 : Form
    {
        public Hesaplama_P2()
        {
            InitializeComponent();
            showbox.Enabled = false;
            input.Focus();
        }

        private void start_Click(object sender, EventArgs e)
        {


            int n;
            if (int.TryParse(input.Text, out n) && n >= 1 && n <= 15)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            sb.Append("    ");
                        }
                        else if (i == 0)
                        {
                            sb.AppendFormat("{0,4}", j);
                        }
                        else if (j == 0)
                        {
                            sb.AppendFormat("{0,4}", i);
                        }
                        else
                        {
                            sb.AppendFormat("{0,4}", i * j);
                        }
                    }
                    sb.AppendLine();
                }

                showbox.Text = sb.ToString();
                label1.BackColor = Color.Transparent;
                progressBar1.Value = 1;
            }
            else
            {
                label1.Text = "Lütfen 1 ile 15 arasında bir tam sayı giriniz.";
                label1.BackColor = Color.Red;

                progressBar1.Value = 0;
            }


        }
    }
}