namespace Software_Lab5_Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
        }
        int x = 0;
        int y = 0;

        #region Основная функция

        private void Calculate()
        {
            double result = 0;
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                result = Convert.ToDouble(Math.Pow(x, 4));
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                result = Convert.ToDouble(Math.Pow(y, 3));
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                result = Convert.ToDouble(Math.Sqrt(x / y) + Math.Pow(y, 2));
            }
            toolStripStatusLabel2.Text = result.ToString();
        }

        #endregion

        #region Обработчики событий

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = (int)e.X;
            y = (int)e.Y;
            toolStripStatusLabel1.Text = string.Format($"Координаты: {x}, {y}");
            Calculate();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        #endregion

    }
}
