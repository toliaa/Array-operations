using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ArrayOperationsApp
{
    public partial class ArrayOperationsForm : Form
    {
        private int[,] array;

        private Label rowsLabel;
        private Label columnsLabel;
        private TextBox rowsTextBox;
        private TextBox columnsTextBox;
        private Button initializeArrayButton;
        private Button showArrayButton;
        private Button showSecondColumnButton;
        private Label rowNumberLabel;
        private TextBox rowNumberTextBox;
        private Label label1;
        private Button showSpecificRowButton;

        public ArrayOperationsForm()
        {
            InitializeComponent();
        }

        private void InitializeArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(rowsTextBox.Text);
                int cols = int.Parse(columnsTextBox.Text);

                array = new int[rows, cols];

                // Request user input for array elements
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = int.Parse(Interaction.InputBox($"Enter element [{i + 1},{j + 1}]:", "Array Element"));
                    }
                }

                MessageBox.Show("Array initialized successfully!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values for the number of rows and columns.");
            }
        }

        private void ShowArrayButton_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Array was not initialized.");
                return;
            }

            string arrayStr = "Two-dimensional array:\n";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayStr += array[i, j] + " ";
                }
                arrayStr += "\n";
            }
            MessageBox.Show(arrayStr);
        }

        private void ShowSecondColumnButton_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Array was not initialized.");
                return;
            }

            string secondColumn = "Elements of the second column of the array:\n";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                secondColumn += array[i, 1] + "\n";
            }
            MessageBox.Show(secondColumn);
        }

        private void ShowSpecificRowButton_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Array was not initialized.");
                return;
            }

            try
            {
                int m = int.Parse(rowNumberTextBox.Text) - 1;

                if (m >= 0 && m < array.GetLength(0))
                {
                    string specificRow = $"Elements of the {m + 1}-th row of the array:\n";
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        specificRow += array[m, j] + " ";
                    }
                    MessageBox.Show(specificRow);
                }
                else
                {
                    MessageBox.Show("The entered row number is out of the array's dimension range.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid row number.");
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrayOperationsForm));
            this.rowsLabel = new System.Windows.Forms.Label();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.initializeArrayButton = new System.Windows.Forms.Button();
            this.showArrayButton = new System.Windows.Forms.Button();
            this.showSecondColumnButton = new System.Windows.Forms.Button();
            this.rowNumberLabel = new System.Windows.Forms.Label();
            this.rowNumberTextBox = new System.Windows.Forms.TextBox();
            this.showSpecificRowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(20, 20);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(109, 16);
            this.rowsLabel.TabIndex = 0;
            this.rowsLabel.Text = "Number of Rows:";
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Location = new System.Drawing.Point(20, 50);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(127, 16);
            this.columnsLabel.TabIndex = 1;
            this.columnsLabel.Text = "Number of Columns:";
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(150, 20);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(50, 22);
            this.rowsTextBox.TabIndex = 2;
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(150, 50);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(50, 22);
            this.columnsTextBox.TabIndex = 3;
            // 
            // initializeArrayButton
            // 
            this.initializeArrayButton.Location = new System.Drawing.Point(20, 80);
            this.initializeArrayButton.Name = "initializeArrayButton";
            this.initializeArrayButton.Size = new System.Drawing.Size(160, 23);
            this.initializeArrayButton.TabIndex = 4;
            this.initializeArrayButton.Text = "Initialize Array";
            this.initializeArrayButton.Click += new System.EventHandler(this.InitializeArrayButton_Click);
            // 
            // showArrayButton
            // 
            this.showArrayButton.Location = new System.Drawing.Point(20, 120);
            this.showArrayButton.Name = "showArrayButton";
            this.showArrayButton.Size = new System.Drawing.Size(160, 23);
            this.showArrayButton.TabIndex = 5;
            this.showArrayButton.Text = "Show Array";
            this.showArrayButton.Click += new System.EventHandler(this.ShowArrayButton_Click);
            // 
            // showSecondColumnButton
            // 
            this.showSecondColumnButton.Location = new System.Drawing.Point(20, 160);
            this.showSecondColumnButton.Name = "showSecondColumnButton";
            this.showSecondColumnButton.Size = new System.Drawing.Size(160, 23);
            this.showSecondColumnButton.TabIndex = 6;
            this.showSecondColumnButton.Text = "Show Second Column";
            this.showSecondColumnButton.Click += new System.EventHandler(this.ShowSecondColumnButton_Click);
            // 
            // rowNumberLabel
            // 
            this.rowNumberLabel.AutoSize = true;
            this.rowNumberLabel.Location = new System.Drawing.Point(220, 20);
            this.rowNumberLabel.Name = "rowNumberLabel";
            this.rowNumberLabel.Size = new System.Drawing.Size(88, 16);
            this.rowNumberLabel.TabIndex = 7;
            this.rowNumberLabel.Text = "Row Number:";
            // 
            // rowNumberTextBox
            // 
            this.rowNumberTextBox.Location = new System.Drawing.Point(310, 20);
            this.rowNumberTextBox.Name = "rowNumberTextBox";
            this.rowNumberTextBox.Size = new System.Drawing.Size(50, 22);
            this.rowNumberTextBox.TabIndex = 8;
            // 
            // showSpecificRowButton
            // 
            this.showSpecificRowButton.Location = new System.Drawing.Point(220, 50);
            this.showSpecificRowButton.Name = "showSpecificRowButton";
            this.showSpecificRowButton.Size = new System.Drawing.Size(234, 39);
            this.showSpecificRowButton.TabIndex = 9;
            this.showSpecificRowButton.Text = "Show Specific Row";
            this.showSpecificRowButton.Click += new System.EventHandler(this.ShowSpecificRowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "© 2024 Tolia Driapak";
            // 
            // ArrayOperationsForm
            // 
            this.ClientSize = new System.Drawing.Size(524, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.columnsLabel);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.columnsTextBox);
            this.Controls.Add(this.initializeArrayButton);
            this.Controls.Add(this.showArrayButton);
            this.Controls.Add(this.showSecondColumnButton);
            this.Controls.Add(this.rowNumberLabel);
            this.Controls.Add(this.rowNumberTextBox);
            this.Controls.Add(this.showSpecificRowButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArrayOperationsForm";
            this.Text = "Array Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
