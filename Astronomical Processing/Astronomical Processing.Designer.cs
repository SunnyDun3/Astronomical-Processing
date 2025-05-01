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
            components = new System.ComponentModel.Container();
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
            avtext = new TextBox();
            modetext = new TextBox();
            rangetext = new TextBox();
            MidExtText = new TextBox();
            label5 = new Label();
            SequentialSearch = new Button();
            mid_Extreme = new Button();
            mode = new Button();
            Average = new Button();
            Range = new Button();
            toolTip = new ToolTip(components);
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
            // avtext
            // 
            avtext.Location = new Point(122, 229);
            avtext.Name = "avtext";
            avtext.Size = new Size(62, 23);
            avtext.TabIndex = 13;
            avtext.TextChanged += avtext_TextChanged;
            // 
            // modetext
            // 
            modetext.Location = new Point(122, 258);
            modetext.Name = "modetext";
            modetext.Size = new Size(124, 23);
            modetext.TabIndex = 15;
            modetext.TextChanged += modetext_TextChanged;
            // 
            // rangetext
            // 
            rangetext.Location = new Point(122, 287);
            rangetext.Name = "rangetext";
            rangetext.Size = new Size(62, 23);
            rangetext.TabIndex = 17;
            rangetext.TextChanged += rangetext_TextChanged;
            // 
            // MidExtText
            // 
            MidExtText.Location = new Point(122, 202);
            MidExtText.Name = "MidExtText";
            MidExtText.Size = new Size(62, 23);
            MidExtText.TabIndex = 19;
            MidExtText.TextChanged += MidExtText_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 205);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 18;
            // 
            // SequentialSearch
            // 
            SequentialSearch.Location = new Point(70, 326);
            SequentialSearch.Name = "SequentialSearch";
            SequentialSearch.Size = new Size(141, 23);
            SequentialSearch.TabIndex = 20;
            SequentialSearch.Text = "Sequential Sort";
            SequentialSearch.UseVisualStyleBackColor = true;
            SequentialSearch.Click += SequentialSearch_Click;
            // 
            // mid_Extreme
            // 
            mid_Extreme.Location = new Point(21, 201);
            mid_Extreme.Name = "mid_Extreme";
            mid_Extreme.RightToLeft = RightToLeft.Yes;
            mid_Extreme.Size = new Size(95, 23);
            mid_Extreme.TabIndex = 21;
            mid_Extreme.Text = "Mid Extreme";
            mid_Extreme.UseVisualStyleBackColor = true;
            mid_Extreme.Click += mid_Extreme_Click;
            // 
            // mode
            // 
            mode.Location = new Point(23, 257);
            mode.Name = "mode";
            mode.RightToLeft = RightToLeft.Yes;
            mode.Size = new Size(95, 23);
            mode.TabIndex = 22;
            mode.Text = "Mode";
            mode.UseVisualStyleBackColor = true;
            mode.Click += mode_Click;
            // 
            // Average
            // 
            Average.Location = new Point(21, 228);
            Average.Name = "Average";
            Average.RightToLeft = RightToLeft.Yes;
            Average.Size = new Size(95, 23);
            Average.TabIndex = 23;
            Average.Text = "Average";
            Average.UseVisualStyleBackColor = true;
            Average.Click += Average_Click;
            // 
            // Range
            // 
            Range.Location = new Point(23, 286);
            Range.Name = "Range";
            Range.RightToLeft = RightToLeft.Yes;
            Range.Size = new Size(95, 23);
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
            Controls.Add(mode);
            Controls.Add(mid_Extreme);
            Controls.Add(SequentialSearch);
            Controls.Add(MidExtText);
            Controls.Add(label5);
            Controls.Add(rangetext);
            Controls.Add(modetext);
            Controls.Add(avtext);
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
        private TextBox avtext;
        private TextBox modetext;
        private TextBox rangetext;
        private TextBox MidExtText;
        private Label label5;
        private Button SequentialSearch;
        private Button mid_Extreme;
        private Button mode;
        private Button Average;
        private Button Range;
        private ToolTip toolTip;
    }
}
