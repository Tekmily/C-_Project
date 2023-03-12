namespace MrtinDosyasındanAlınanVerileriKucuktenBuyugeSıralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFilesTxt_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            openFileDialog.Title = "Metin Dosyası Seçin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string temp="";
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                List<double> numbers = new List<double>();
                foreach (string line in lines)
                {
                    string[] tokens = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string token in tokens)
                    {
                        double number;
                        if (double.TryParse(token, out number))
                        {
                            numbers.Add(number);
                        }
                    }
                }
                numbers.Sort();
                foreach (double number in numbers)
                {
                    temp = number.ToString() + " ";
                    textV.Text += temp;
                    temp += textV.Text;

                    
                }
                textBoxMonitor.AppendText(temp + Environment.NewLine);
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            textBoxMonitor.Clear();
        }
    }
}