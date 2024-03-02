namespace Hw2Draft
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
            Fill = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Fill
            // 
            Fill.Location = new Point(89, 312);
            Fill.Name = "Fill";
            Fill.Size = new Size(75, 23);
            Fill.TabIndex = 0;
            Fill.Text = "Fill";
            Fill.UseVisualStyleBackColor = true;
            Fill.Click += Fill_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(639, 203);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 196);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "License Plate";
            // 
            // button1
            // 
            button1.Location = new Point(364, 241);
            button1.Name = "button1";
            button1.Size = new Size(275, 23);
            button1.TabIndex = 4;
            button1.Text = "Place Rental";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlaceRental_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(35, 98);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(119, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "[2]-SUV ($40/Day)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(35, 123);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(152, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "[3]-Sports Car ($60/Day)";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(35, 73);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(150, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "[1]-Compact ($25/Day) ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(740, 98);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(153, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Extra Driver Charge($25)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(401, 9);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 10;
            label2.Text = "Car Rental Company";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(439, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(439, 119);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 73);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 13;
            label3.Text = "Rent Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 123);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 14;
            label4.Text = "Return Date";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 527);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Fill);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Fill;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
    }
}