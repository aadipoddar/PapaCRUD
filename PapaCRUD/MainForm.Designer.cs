namespace PapaCRUD
{
    partial class MainForm
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
            this.productIdLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.deisgnLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.designTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.inserButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(33, 43);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(63, 15);
            this.productIdLabel.TabIndex = 0;
            this.productIdLabel.Text = "Product ID";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(33, 111);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(66, 15);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Item Name";
            // 
            // deisgnLabel
            // 
            this.deisgnLabel.AutoSize = true;
            this.deisgnLabel.Location = new System.Drawing.Point(33, 179);
            this.deisgnLabel.Name = "deisgnLabel";
            this.deisgnLabel.Size = new System.Drawing.Size(43, 15);
            this.deisgnLabel.TabIndex = 2;
            this.deisgnLabel.Text = "Design";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(33, 247);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(36, 15);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Color";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(160, 40);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(235, 23);
            this.productIdTextBox.TabIndex = 4;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(160, 108);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(235, 23);
            this.itemNameTextBox.TabIndex = 5;
            // 
            // designTextBox
            // 
            this.designTextBox.Location = new System.Drawing.Point(160, 176);
            this.designTextBox.Name = "designTextBox";
            this.designTextBox.Size = new System.Drawing.Size(235, 23);
            this.designTextBox.TabIndex = 6;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 300);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(667, 259);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // inserButton
            // 
            this.inserButton.Location = new System.Drawing.Point(477, 40);
            this.inserButton.Name = "inserButton";
            this.inserButton.Size = new System.Drawing.Size(165, 47);
            this.inserButton.TabIndex = 10;
            this.inserButton.Text = "Insert";
            this.inserButton.UseVisualStyleBackColor = true;
            this.inserButton.Click += new System.EventHandler(this.inserButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(477, 135);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(165, 47);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(477, 230);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(165, 47);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "White",
            "Black"});
            this.colorComboBox.Location = new System.Drawing.Point(160, 244);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(235, 23);
            this.colorComboBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 571);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.inserButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.designTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.deisgnLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.productIdLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productIdLabel;
        private Label itemNameLabel;
        private Label deisgnLabel;
        private Label colorLabel;
        private TextBox productIdTextBox;
        private TextBox itemNameTextBox;
        private TextBox designTextBox;
        private DataGridView dataGridView;
        private Button inserButton;
        private Button updateButton;
        private Button deleteButton;
        private ComboBox colorComboBox;
    }
}