/* Blayke Stephens, Ctrl+Alt+Del+troids, Sprint1
 * Date: 17/04/25
 * Version: 1.1
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
        public Form1()
        {
            InitializeComponent();
        }

        // generates 24 random integers between 10 and 90 and stores them in array
        private void GenerateRandomData()
        {
            for (int i = 0; i < 24; i++)
            {
                numbers[i] = random.Next(10, 91); // generates the random numbers
            }
            DisplayData(); // puts numbers in UI
        }

        // Displays the current array values in the Listbox
        private void DisplayData()
        {
            Data.Items.Clear(); // clears previous data
            foreach (int value in numbers)
            {
                Data.Items.Add(value); // add each number to the list box
            }
        }

        // standard bubble sort algorithm that sorts the array in ascending order
        private void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    // swap if the current element is greater than the next
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleSort(numbers);
            DisplayData();

            if (int.TryParse(SearchInput.Text, out int target))
            {
                // Perform binary search
                int index = BinarySearch(numbers, target);

                if (index != -1)
                {
                    SearchInput.Text = $"Value Found {target} ";
                    Data.SelectedIndex = index; // Optionally highlight the value in the ListBox
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
            BubbleSort(numbers); // calls the bubblesort algorithim
            DisplayData(); // calls display data method
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
            GenerateRandomData(); //  generates the random vlaues
            DisplayData(); // puts the new sorted values in to list box
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

        private void SearchInput_TextChanged_1(object sender, EventArgs e)
        {

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

    numbers[selectedIndex] = newValue; // Update the array
    DisplayData(); // Refresh the display
    Data.SelectedIndex = selectedIndex; // Keep the selection
}
else
{
    MessageBox.Show("Enter a valid number");
}
        }

        private void textEditValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
