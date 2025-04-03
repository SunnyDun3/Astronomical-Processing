namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        private int[] neutrinoData = new int[24];
        private Random random = new Random();
        int[] arr = neutrinoData;
        public Form1()
        {
            InitializeComponent();
        }
        private void GenerateRandomData()
        {
            for (int i = 0; i < neutrinoData.Length; i++)
            {
                neutrinoData[i] = random.Next(10, 91);
            }
        }

        private void DisplayData()
        {
            Data.Items.Clear();
            foreach (int value in neutrinoData)
            {
                Data.Items.Add(value);
            }
        }
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        private void btnGenerateNewData_Click(object sender, EventArgs ev)
        {
            GenerateRandomData();
            DisplayData();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleSort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BubbleSort();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateRandomData();
            DisplayData();
        }

        private void Data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
