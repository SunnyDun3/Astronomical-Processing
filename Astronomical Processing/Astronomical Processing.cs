/* Blayke Stephens 30067035, Ctrl+Alt+Del+troids, Sprint1
 * Date: 17/04/25
 * Version: 2
 * Astronomical_Processing
 * form based Gui that stores 24 integers in a array, that comes from the local observetory.
 * edit values 
 * can search for certain values
 * sort the data in ascending order
 */
using System.Globalization;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        // array to store 24 integers for sorting
        private int[] numbers = new int[24];
        // random number generator for creating data
        private Random random = new Random();
        private readonly string placeholderText = "Enter number to search";
        private readonly string editPlaceholderText = "";

        public Form1()
        {
            InitializeComponent();
            SearchInput.Text = placeholderText;
            SearchInput.Click += SearchInput_Click;
            SearchInput.Leave += SearchInput_Leave;
            textEditValue.Text = editPlaceholderText;
            textEditValue.Click += TextEditValue_Click;
            textEditValue.Leave += TextEditValue_Leave;
        }

        public static List<double> CalculateMode(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list cannot be null or empty");
            }

            var frequency = numbers
                .GroupBy(n => n)
                .ToDictionary(g => g.Key, g => g.Count());

            int maxFrequency = frequency.Values.Max();

            var modes = frequency
                .Where(kvp => kvp.Value == maxFrequency)
                .Select(kvp => kvp.Key)
                .ToList();

            return modes;
        }
        public static double CalculateMidExtreme(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("this list coont be Empty or null");
            }
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var number in numbers)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
            return (min + max) / 2;

        }
        static double CalculateRange(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("This List cannot be empty or null");
            }
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var number in numbers)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
            return max - min;
        }

        static double CalculateAverage(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("This List cannot be empty or null");
            }
            double average = 0;
            foreach (var number in numbers)
            {
                average += number;
            }
            return average / numbers.Count;
        }
        private List<double> GetDoubleListFromNumbers()
        {
            return numbers.Select(n => (double)n).ToList();
        }

        private void GenerateRandomData()
        {
            for (int i = 0; i < 24; i++)
            {
                numbers[i] = random.Next(10, 91);
            }
            DisplayData();
        }

        private void DisplayData()
        {
            Data.Items.Clear();
            foreach (int value in numbers)
            {
                Data.Items.Add(value);
            }
        }

        private void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        private int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                    return mid;
                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

        private void btnGenerateNewData_Click(object sender, EventArgs ev)
        {
            GenerateRandomData();
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleSort(numbers);
            DisplayData();

            if (int.TryParse(SearchInput.Text, out int target))
            {
                int index = BinarySearch(numbers, target);

                if (index != -1)
                {
                    SearchInput.Text = $"Value Found: {target}, at Index: {index}";
                    Data.SelectedIndex = index;
                }
                else
                {
                    SearchInput.Text = $"Value {target} not found.";
                }
            }
            else
            {
                SearchInput.Text = "Please enter a valid number.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BubbleSort(numbers);
            DisplayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateRandomData();
            DisplayData();
        }

        private void EditSub_Click(object sender, EventArgs e)
        {
            int selectedIndex = Data.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please Select a value to edit from the list");
                return;
            }

            if (int.TryParse(textEditValue.Text, out int newValue))
            {
                if (newValue < 10 || newValue > 90)
                {
                    MessageBox.Show("Please enter a value between 10 and 90");
                    return;
                }

                numbers[selectedIndex] = newValue;
                DisplayData();
                Data.SelectedIndex = selectedIndex;

                textEditValue.Text = editPlaceholderText;
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }
        }

        // Clear system-generated messages or placeholder on click
        private void SearchInput_Click(object sender, EventArgs e)
        {
            string currentText = SearchInput.Text;

            if (currentText == placeholderText ||
                currentText.StartsWith("Value Found:") ||
                currentText.Contains("not found") ||
                currentText == "Please enter a valid number.")
            {
                SearchInput.Clear();
            }
        }

        // Restore placeholder if left empty
        private void SearchInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchInput.Text))
            {
                SearchInput.Text = placeholderText;
            }
        }

        private void TextEditValue_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEditValue.Text))
            {
                textEditValue.Text = editPlaceholderText;
            }
        }

        private void TextEditValue_Click(object? sender, EventArgs e)
        {
            string currentText = textEditValue.Text;

            if (currentText == placeholderText ||
                currentText.StartsWith("Enter a valid number") ||
                currentText.Contains("Please enter a value between 10 and 90") ||
                currentText == "Please Select a value to edit from the list")
            {
                textEditValue.Clear();
            }
        }

        #region unused
        private void label1_Click(object sender, EventArgs e)
        {

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
        private void Data_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textEditValue_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void MidExt_Click(object sender, EventArgs e)
        {
            double result = CalculateMidExtreme(GetDoubleListFromNumbers());
            textBox4.Text = result.ToString("F2");

        }

        private void Mode_Click(object sender, EventArgs e)
        {
            List<double> modeValues = CalculateMode(GetDoubleListFromNumbers());
            string modeText = string.Join(", ", modeValues); // if multiple modes
            textBox1.Text = $"{modeText}";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Average_Click(object sender, EventArgs e)
        {
            double average = CalculateAverage(GetDoubleListFromNumbers());
            textBox2.Text = $"{average:F2}";
            Console.WriteLine(numbers);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Range_Click(object sender, EventArgs e)
        {
            double range = CalculateRange(GetDoubleListFromNumbers());
            textBox3.Text = $"{range:F2}";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
