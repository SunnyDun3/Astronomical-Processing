/* Blayke Stephens 30067035, Ctrl+Alt+Del+troids, Sprint2
 * Date: 1/05/25
 * Version: 2.3
 * Astronomical_Processing
 * form based Gui that stores 24 integers in a array, that comes from the local observetory.
 * edit values 
 * can search for certain values either with binary or sequential search
 * calculates modes, average, range, and mid extreme
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

            toolTip.SetToolTip(SearchInput, "Enter the number you want to search for.");
            toolTip.SetToolTip(button4, "Click to generate new random data.");
            toolTip.SetToolTip(SearchButton, "search for a binary number.");
            toolTip.SetToolTip(button3, "Click to sort the data in ascending order.");
            toolTip.SetToolTip(button4, "Click to generate new random data.");
            toolTip.SetToolTip(EditSub, "Click to edit the selected value in the list.");
            toolTip.SetToolTip(SequentialSearh1, "Click to perform a sequential search for the entered value.");
            toolTip.SetToolTip(mode, "Click to calculate the mode of the data.");
            toolTip.SetToolTip(midextreme, "Click to calculate the mid-extreme value of the data.");
            toolTip.SetToolTip(ave, "Click to calculate the average of the data.");
            toolTip.SetToolTip(rangebut, "Click to calculate the range of the data.");
        }
        #region old
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
        #endregion

        //Calculates the Mode 
        public static List<double> CalculateMode(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0) //checks if the array is empty 
            {
                // Throwing an exception if the list is null or empty
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

            return modes; // returns the modes
        }

        //Calculates the Mid-Extreme
        static double CalculateMidExtreme(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("this list coont be Empty or null");
            }
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var number in numbers) // finds the 2 values
            {
                if (number < min) // gets the min
                    min = number;
                if (number > max) // gets the max
                    max = number;
            }
            return (min + max) / 2; //returns the Mid-Extreme
        }
        // Method to calculate the range
        static double CalculateRange(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("This List cannot be empty or null");
            }
            double min = double.MinValue; // defines the lowest value
            double max = double.MaxValue; // defiens the highest value
            //loo[s through the numbes to find the min and max
            foreach (var number in numbers)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
            // returns the range 
            return max - min;
        }
        // Method to calculate the average of a list of numbers
        static double CalculateAverage(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                // Throwing an exception if the list is null or empty
                throw new ArgumentException("This List cannot be empty or null");
            }
            double average = 0;
            // Sum all the numbers in the list
            foreach (var number in numbers)
            {
                average += number;
            }
            // Return the average (sum divided by the number of elements)
            return average / numbers.Count;
        }


        // Event handler for calculating mode and displaying it in the result textbox
        private void mode_Click(object sender, EventArgs e)
        {
            // Convert 'numbers' to a list of doubles and calculate the mode
            List<double> numberList = numbers.Select(n => (double)n).ToList();
            var mode = CalculateMode(numberList);
            modetxt.Text = string.Join(", ", mode);
        }

        // Add functionality for the Mid Extreme button
        private void midextreme_Click(object sender, EventArgs e)
        {
            // Convert 'numbers' to a list of doubles and calculate the mid extreme value
            List<double> numberList = numbers.Select(n => (double)n).ToList();
            double midExtreme = CalculateMidExtreme(numberList);
            textBox6.Text = midExtreme.ToString("F2");

        }

        // Add functionality for the Average button
        private void ave_Click(object sender, EventArgs e)
        {
            // Convert 'numbers' to a list of doubles and calculate the average
            List<double> numberList = numbers.Select(n => (double)n).ToList();
            double average = CalculateAverage(numberList);
            avetext.Text = average.ToString("F2");
        }

        // Add functionality for the Range button
        private void rangebut_Click(object sender, EventArgs e)
        {
            // Convert 'numbers' to a list of doubles and calculate the range
            List<double> numberList = numbers.Select(n => (double)n).ToList();
            double range = CalculateRange(numberList);
            rantext.Text = range.ToString("F2");
        }

        // TextChanged events for the result textboxes (optional, if needed for other logic)
        private void modetxt_TextChanged(object sender, EventArgs e) { }

        private void midextremeTxt_TextChanged(object sender, EventArgs e) { }

        private void avetxt_TextChanged(object sender, EventArgs e) { }

        private void rantext_TextChanged(object sender, EventArgs e) { }

        // Event handler for performing sequential search on the numbers array
        private void SequentialSearh1_Click(object sender, EventArgs e)
        {
            // Define a helper method to perform a sequential search in an array
            int SequentialSearch(int[] array, int target)
            {
                // Loop through the array and return the index if the target is found
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == target)
                    {
                        return i;
                    }
                }
                // Return -1 if the target is not found
                return -1;
            }
            // Check if the input is a valid integer and attempt to perform the search
            if (int.TryParse(SearchInput.Text, out int target))
            {
                // Perform the sequential search and display the result
                int index = SequentialSearch(numbers, target);

                if (index != -1)
                {
                    // If the number is found, display the index in the text field
                    SearchInput.Text = $"Value Found: {target}, at Index: {index}";
                    Data.SelectedIndex = index;
                }
                else
                {
                    // If not found, show a message indicating that
                    SearchInput.Text = $"Value {target} not found.";
                }
            }
            else
            {
                // Show an error message if the input is not a valid number
                SearchInput.Text = "Please enter a valid number.";
            }
        }
    }
}


