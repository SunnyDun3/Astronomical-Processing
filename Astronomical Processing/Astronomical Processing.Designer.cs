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
            midextreme = new Button();
            ave = new Button();
            rangebut = new Button();
            modetxt = new TextBox();
            textBox6 = new TextBox();
            rantext = new TextBox();
            avetext = new TextBox();
            SequentialSearh1 = new Button();
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
            // 
            // modetext
            // 
            modetext.Location = new Point(122, 258);
            modetext.Name = "modetext";
            modetext.Size = new Size(124, 23);
            modetext.TabIndex = 15;
            // 
            // rangetext
            // 
            rangetext.Location = new Point(122, 287);
            rangetext.Name = "rangetext";
            rangetext.Size = new Size(62, 23);
            rangetext.TabIndex = 17;
            // 
            // MidExtText
            // 
            MidExtText.Location = new Point(122, 202);
            MidExtText.Name = "MidExtText";
            MidExtText.Size = new Size(62, 23);
            MidExtText.TabIndex = 19;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // SequentialSearch
            // 
            SequentialSearch.Location = new Point(0, 0);
            SequentialSearch.Name = "SequentialSearch";
            SequentialSearch.Size = new Size(75, 23);
            SequentialSearch.TabIndex = 0;
            // 
            // mid_Extreme
            // 
            mid_Extreme.Location = new Point(0, 0);
            mid_Extreme.Name = "mid_Extreme";
            mid_Extreme.Size = new Size(75, 23);
            mid_Extreme.TabIndex = 0;
            // 
            // mode
            // 
            mode.Location = new Point(54, 229);
            mode.Name = "mode";
            mode.Size = new Size(75, 23);
            mode.TabIndex = 0;
            mode.Text = "Mode";
            mode.Click += mode_Click;
            // 
            // Average
            // 
            Average.Location = new Point(0, 0);
            Average.Name = "Average";
            Average.Size = new Size(75, 23);
            Average.TabIndex = 0;
            // 
            // Range
            // 
            Range.Location = new Point(0, 0);
            Range.Name = "Range";
            Range.Size = new Size(75, 23);
            Range.TabIndex = 0;
            // 
            // midextreme
            // 
            midextreme.Location = new Point(23, 258);
            midextreme.Name = "midextreme";
            midextreme.Size = new Size(106, 23);
            midextreme.TabIndex = 12;
            midextreme.Text = "Mid-Extreme";
            midextreme.Click += midextreme_Click;
            // 
            // ave
            // 
            ave.Location = new Point(54, 287);
            ave.Name = "ave";
            ave.Size = new Size(75, 23);
            ave.TabIndex = 13;
            ave.Text = "Average";
            ave.Click += ave_Click;
            // 
            // rangebut
            // 
            rangebut.Location = new Point(54, 316);
            rangebut.Name = "rangebut";
            rangebut.Size = new Size(75, 23);
            rangebut.TabIndex = 14;
            rangebut.Text = "Range";
            rangebut.Click += rangebut_Click;
            // 
            // modetxt
            // 
            modetxt.Location = new Point(135, 229);
            modetxt.Name = "modetxt";
            modetxt.Size = new Size(100, 23);
            modetxt.TabIndex = 15;
            modetxt.TextChanged += modetxt_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(135, 259);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 16;
            // 
            // rantext
            // 
            rantext.Location = new Point(135, 316);
            rantext.Name = "rantext";
            rantext.Size = new Size(100, 23);
            rantext.TabIndex = 18;
            rantext.TextChanged += rantext_TextChanged;
            // 
            // avetext
            // 
            avetext.Location = new Point(135, 286);
            avetext.Name = "avetext";
            avetext.Size = new Size(100, 23);
            avetext.TabIndex = 17;
            // 
            // SequentialSearh1
            // 
            SequentialSearh1.Location = new Point(216, 114);
            SequentialSearh1.Name = "SequentialSearh1";
            SequentialSearh1.Size = new Size(111, 30);
            SequentialSearh1.TabIndex = 19;
            SequentialSearh1.Text = "Sequential search";
            SequentialSearh1.UseVisualStyleBackColor = true;
            SequentialSearh1.Click += SequentialSearh1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 361);
            Controls.Add(SequentialSearh1);
            Controls.Add(rantext);
            Controls.Add(avetext);
            Controls.Add(textBox6);
            Controls.Add(modetxt);
            Controls.Add(rangebut);
            Controls.Add(ave);
            Controls.Add(midextreme);
            Controls.Add(mode);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button SequentialSearh1;
        private Button MidExt;
        private Button Mode;
        private Button midextreme;
        private Button ave;
        private Button rangebut;
        private TextBox modetxt;
        private TextBox textBox6;
        private TextBox rantext;
        private TextBox avetext;
    }
}
