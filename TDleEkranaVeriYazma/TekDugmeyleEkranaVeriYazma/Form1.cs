namespace TekDugmeyleEkranaVeriYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateshow_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    if (i >= 100)
                    {
                        listBox1.Items.Add("zagzig ");
                        Console.WriteLine("zagzig ");
                    }
                    else
                    {
                        listBox1.Items.Add("zigzag ");
                        Console.WriteLine("zigzag ");
                    }
                }
                else if (i % 3 == 0)
                {

                    listBox1.Items.Add("zig ");
                    Console.WriteLine("zig ");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("zag ");
                    Console.WriteLine("zag ");
                }
                else
                {
                    listBox1.Items.Add(i + " ");
                    Console.WriteLine(i + " ");
                }
            }
            Console.ReadLine();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}