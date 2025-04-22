namespace Astronomical_Processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Data = new ListBox();
            label1 = new Label();
            SearchButton = new Button();
            EditSub = new Button();
            button3 = new Button();
            Searchlab = new Label();
            textEditValue = new TextBox();
            editLabel = new Label();
            button4 = new Button();
            SearchInput = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            MidExt = new Button();
            Mode = new Button();
            Average = new Button();
            Range = new Button();
            SuspendLayout();
            // 
            // Data
            // 
            Data.FormattingEnabled = true;
            Data.ItemHeight = 15;
            Data.Location = new Point(333, 12);
            Data.Name = "Data";
            Data.Size = new Size(120, 319);
            Data.TabIndex = 0;
            Data.SelectedIndexChanged += Data_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(54, 12);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 1;
            label1.Text = "Astronomical Processing";
            label1.Click += label1_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(252, 85);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += button1_Click;
            // 
            // EditSub
            // 
            EditSub.Location = new Point(122, 125);
            EditSub.Name = "EditSub";
            EditSub.Size = new Size(75, 23);
            EditSub.TabIndex = 3;
            EditSub.Text = "Edit";
            EditSub.UseVisualStyleBackColor = true;
            EditSub.Click += EditSub_Click;
            // 
            // button3
            // 
            button3.Location = new Point(54, 173);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Sort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Searchlab
            // 
            Searchlab.AutoSize = true;
            Searchlab.Location = new Point(12, 91);
            Searchlab.Name = "Searchlab";
            Searchlab.Size = new Size(45, 15);
            Searchlab.TabIndex = 5;
            Searchlab.Text = "Search:";
            Searchlab.Click += label2_Click;
            // 
            // textEditValue
            // 
            textEditValue.Location = new Point(54, 126);
            textEditValue.Name = "textEditValue";
            textEditValue.Size = new Size(62, 23);
            textEditValue.TabIndex = 8;
            // 
            // editLabel
            // 
            editLabel.AutoSize = true;
            editLabel.Location = new Point(23, 129);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(30, 15);
            editLabel.TabIndex = 7;
            editLabel.Text = "Edit:";
            editLabel.Click += label3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(356, 337);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Random ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SearchInput
            // 
            SearchInput.Location = new Point(54, 86);
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(192, 23);
            SearchInput.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(106, 23);
            textBox4.TabIndex = 19;
            textBox4.TextChanged += textBox4_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(70, 326);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 20;
            button1.Text = "Sequential Sort";
            // 
            // MidExt
            // 
            MidExt.Location = new Point(8, 201);
            MidExt.Name = "MidExt";
            MidExt.Size = new Size(91, 23);
            MidExt.TabIndex = 21;
            MidExt.Text = "Mid-Extreme";
            MidExt.UseVisualStyleBackColor = true;
            MidExt.Click += MidExt_Click;
            // 
            // Mode
            // 
            Mode.Location = new Point(8, 229);
            Mode.Name = "Mode";
            Mode.Size = new Size(75, 23);
            Mode.TabIndex = 22;
            Mode.Text = "Mode";
            Mode.UseVisualStyleBackColor = true;
            Mode.Click += Mode_Click;
            // 
            // Average
            // 
            Average.Location = new Point(8, 258);
            Average.Name = "Average";
            Average.Size = new Size(75, 23);
            Average.TabIndex = 23;
            Average.Text = "Average";
            Average.UseVisualStyleBackColor = true;
            Average.Click += Average_Click;
            // 
            // Range
            // 
            Range.Location = new Point(8, 287);
            Range.Name = "Range";
            Range.Size = new Size(75, 23);
            Range.TabIndex = 24;
            Range.Text = "Range";
            Range.UseVisualStyleBackColor = true;
            Range.Click += Range_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 361);
            Controls.Add(Range);
            Controls.Add(Average);
            Controls.Add(Mode);
            Controls.Add(MidExt);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(textEditValue);
            Controls.Add(editLabel);
            Controls.Add(SearchInput);
            Controls.Add(Searchlab);
            Controls.Add(button3);
            Controls.Add(EditSub);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(Data);
            Location = new Point(100, 100);
            Name = "Form1";
            Text = "Astronomical Processing";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Data;
        private Label label1;
        private Button SearchButton;
        private Button EditSub;
        private Button button3;
        private Label Searchlab;
        private TextBox textEditValue;
        private Label editLabel;
        private Button button4;
        private TextBox SearchInput;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button MidExt;
        private Button Mode;
        private Button Average;
        private Button Range;
    }
}
