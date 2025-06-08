
namespace GUI_UI_PL
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Findlocations = new Button();
            AllFoundplaces = new ListBox();
            finds_word = new ListBox();
            textBox4 = new TextBox();
            look_for_word = new Button();
            find_gimatry = new Button();
            Gimatry = new ListBox();
            look_for_in_Chumash = new Button();
            Finds_Chumash = new ListBox();
            textBox5 = new TextBox();
            label1 = new Label();
            text = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1699, 253);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "הכנס מילה";
            textBox1.Size = new Size(89, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1713, 308);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "הכנס חומש";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Findlocations
            // 
            Findlocations.Location = new Point(1619, 162);
            Findlocations.Name = "Findlocations";
            Findlocations.Size = new Size(103, 62);
            Findlocations.TabIndex = 3;
            Findlocations.Text = "כל התנך";
            Findlocations.UseVisualStyleBackColor = true;
            Findlocations.Click += Findlocations_Click;
            // 
            // AllFoundplaces
            // 
            AllFoundplaces.FormattingEnabled = true;
            AllFoundplaces.ItemHeight = 20;
            AllFoundplaces.Location = new Point(374, 91);
            AllFoundplaces.Name = "AllFoundplaces";
            AllFoundplaces.Size = new Size(969, 224);
            AllFoundplaces.TabIndex = 4;
            AllFoundplaces.SelectedIndexChanged += AllFoundplaces_SelectedIndexChanged;
            // 
            // finds_word
            // 
            finds_word.FormattingEnabled = true;
            finds_word.ItemHeight = 20;
            finds_word.Location = new Point(374, 345);
            finds_word.Name = "finds_word";
            finds_word.Size = new Size(969, 264);
            finds_word.TabIndex = 6;
            finds_word.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1685, 361);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "הכנס מספר";
            textBox4.Size = new Size(89, 27);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // look_for_word
            // 
            look_for_word.Location = new Point(1582, 246);
            look_for_word.Name = "look_for_word";
            look_for_word.Size = new Size(94, 40);
            look_for_word.TabIndex = 10;
            look_for_word.Text = "חפוש";
            look_for_word.UseVisualStyleBackColor = true;
            look_for_word.Click += look_for_word_Click;
            // 
            // find_gimatry
            // 
            find_gimatry.Location = new Point(1406, 361);
            find_gimatry.Name = "find_gimatry";
            find_gimatry.Size = new Size(133, 37);
            find_gimatry.TabIndex = 11;
            find_gimatry.Text = "חפוש גימטריא";
            find_gimatry.UseVisualStyleBackColor = true;
            find_gimatry.Click += find_gimatry_Click;
            // 
            // Gimatry
            // 
            Gimatry.FormattingEnabled = true;
            Gimatry.ItemHeight = 20;
            Gimatry.Location = new Point(118, 229);
            Gimatry.Name = "Gimatry";
            Gimatry.Size = new Size(159, 464);
            Gimatry.TabIndex = 12;
            Gimatry.SelectedIndexChanged += Gimatry_SelectedIndexChanged;
            // 
            // look_for_in_Chumash
            // 
            look_for_in_Chumash.Location = new Point(1419, 301);
            look_for_in_Chumash.Name = "look_for_in_Chumash";
            look_for_in_Chumash.Size = new Size(120, 40);
            look_for_in_Chumash.TabIndex = 14;
            look_for_in_Chumash.Text = "חפוש בחומש";
            look_for_in_Chumash.UseVisualStyleBackColor = true;
            look_for_in_Chumash.Click += look_for_in_Chumash_Click;
            // 
            // Finds_Chumash
            // 
            Finds_Chumash.FormattingEnabled = true;
            Finds_Chumash.ItemHeight = 20;
            Finds_Chumash.Location = new Point(374, 639);
            Finds_Chumash.Name = "Finds_Chumash";
            Finds_Chumash.Size = new Size(969, 224);
            Finds_Chumash.TabIndex = 15;
            Finds_Chumash.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1567, 308);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "הכנס פרשה";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(618, 28);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 17;
            label1.Text = "ברוכים הבאים לאהבתי תורתך";
            label1.Click += label1_Click;
            // 
            // text
            // 
            text.Location = new Point(1551, 366);
            text.Name = "text";
            text.PlaceholderText = "הכנס  טקסט";
            text.Size = new Size(125, 27);
            text.TabIndex = 18;
            text.TextChanged += textBox3_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1786, 649);
            Controls.Add(text);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(Finds_Chumash);
            Controls.Add(look_for_in_Chumash);
            Controls.Add(Gimatry);
            Controls.Add(find_gimatry);
            Controls.Add(look_for_word);
            Controls.Add(textBox4);
            Controls.Add(finds_word);
            Controls.Add(AllFoundplaces);
            Controls.Add(Findlocations);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Findlocations;
        private ListBox AllFoundplaces;
        private ListBox finds_word;
        private TextBox textBox4;
        private Button look_for_word;
        private Button find_gimatry;
        private ListBox Gimatry;
        private Button look_for_in_Chumash;
        private ListBox Finds_Chumash;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox3;
        private TextBox text;
    }
}