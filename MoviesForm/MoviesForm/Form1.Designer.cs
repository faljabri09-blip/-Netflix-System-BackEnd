namespace MoviesForm
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
            label1 = new Label();
            textUserName = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtGenre = new TextBox();
            label4 = new Label();
            txtRating = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // textUserName
            // 
            textUserName.BorderStyle = BorderStyle.None;
            textUserName.Location = new Point(400, 106);
            textUserName.Margin = new Padding(4);
            textUserName.Name = "textUserName";
            textUserName.RightToLeft = RightToLeft.No;
            textUserName.Size = new Size(156, 24);
            textUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "MovieName";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(400, 168);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.RightToLeft = RightToLeft.No;
            txtTitle.Size = new Size(156, 31);
            txtTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 248);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Gener";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(400, 245);
            txtGenre.Margin = new Padding(4);
            txtGenre.Name = "txtGenre";
            txtGenre.RightToLeft = RightToLeft.No;
            txtGenre.Size = new Size(156, 31);
            txtGenre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 314);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "Rating";
            // 
            // txtRating
            // 
            txtRating.Location = new Point(400, 314);
            txtRating.Margin = new Padding(4);
            txtRating.Name = "txtRating";
            txtRating.RightToLeft = RightToLeft.No;
            txtRating.Size = new Size(156, 31);
            txtRating.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 588);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(564, 235);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(194, 436);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 63);
            button1.TabIndex = 9;
            button1.Text = "Add Movies";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 436);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(118, 63);
            button2.TabIndex = 10;
            button2.Text = "Watch Movies";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(570, 436);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(118, 63);
            button3.TabIndex = 11;
            button3.Text = "Rate Movies";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.ForeColor = SystemColors.MenuText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "The From", "Maoukly", "Sandibad", "Maikl", "The Rock" });
            listBox1.Location = new Point(595, 624);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(269, 154);
            listBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(427, 25);
            label5.Name = "label5";
            label5.Size = new Size(304, 45);
            label5.TabIndex = 13;
            label5.Text = "Mini Netflix System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 855);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtRating);
            Controls.Add(label4);
            Controls.Add(txtGenre);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(textUserName);
            Controls.Add(label1);
            Cursor = Cursors.No;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textUserName;
        private Label label2;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtGenre;
        private Label label4;
        private TextBox txtRating;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Label label5;
    }
}
