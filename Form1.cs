namespace calculadora_basica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(tbvalue1.Text);
            double value2 = Convert.ToDouble(tbvalue2.Text);
            result.Text = Convert.ToString(value1 + value2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(tbvalue1.Text);
            double value2 = Convert.ToDouble(tbvalue2.Text);
            result.Text = Convert.ToString(value1 - value2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(tbvalue1.Text);
            double value2 = Convert.ToDouble(tbvalue2.Text);
            result.Text = Convert.ToString(value1 / value2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(tbvalue1.Text);
            double value2 = Convert.ToDouble(tbvalue2.Text);
            result.Text = Convert.ToString(value1 * value2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(tbvalue1.Text);
            double value2 = Convert.ToDouble(tbvalue2.Text);
            result.Text = Convert.ToString(value1 % value2);
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(result.Text);
        }
    }
}
