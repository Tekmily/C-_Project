namespace TextboxsUygulamasıIleCarpma
{
    public partial class Hesaplama_P2 : Form
    {
        public Hesaplama_P2()
        {
            InitializeComponent();
        }

        private void shoveResults_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2) && int.TryParse(textBox3.Text, out num3))
            {
                int resultshow = (num1 + num2) * num3;
                result.Text = resultshow.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen sadece rakam giriniz!");
            }
        }

    }
}