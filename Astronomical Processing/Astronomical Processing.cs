/* Blayke Stephens, Ctrl+Alt+Del+troids, Sprint1
 * Date: 17/04/25
 * Version: 1.2
 * Astronomical_Processing
 * form based Gui that stores 24 integers in a array, that comes from the local observetory.
 * edit values 
 * can search for certain values
 * sort the data in ascending order
 */
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
        private void label1_Click(object sender, EventArgs e) { 
        
        }
        private void label2_Click(object sender, EventArgs e) {
        }
        private void label3_Click(object sender, EventArgs e) { 
        }
        private void textBox4_TextChanged(object sender, EventArgs e) { 
        }
        private void Data_SelectedIndexChanged(object sender, EventArgs e) { 
        }
        private void SearchInput_TextChanged(object sender, EventArgs e) {
        }
        private void Form1_Load(object sender, EventArgs e) { 
        }

        private void textEditValue_TextChanged(object sender, EventArgs e) {
        }
        #endregion
    }
}
