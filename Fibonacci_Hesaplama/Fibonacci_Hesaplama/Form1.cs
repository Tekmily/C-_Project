namespace Fibonacci_Hesaplama
{
    public partial class Hesaplama_P3 : Form
    {
        public Hesaplama_P3()
        {
            InitializeComponent();
        }

        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                int a = 1;
                int b = 1;
                int fibonacciNumber = 0;

                for (int i = 4; i <= n; i++)
                {
                    fibonacciNumber = a + b;
                    a = b;
                    b = fibonacciNumber;
                }

                return fibonacciNumber;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtInput.Text, out int inputNumber))
            {

                int fibonacciNumber = Fibonacci(inputNumber);
                lblResult.Text = "Fibonacci sayýsý: " + fibonacciNumber.ToString();
            }
            else
            {
                lblResult.Text = "Lütfen bir sayý girin.";
            }
        }
    }
}