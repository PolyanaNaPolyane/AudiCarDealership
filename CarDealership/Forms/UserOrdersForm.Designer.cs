namespace CarDealership.Forms
{
    partial class UserOrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ordersDataGridView = new DataGridView();
            filterGroupBox = new GroupBox();
            resetButton = new Button();
            applyButton = new Button();
            searchGroupBox = new GroupBox();
            searchButton = new Button();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            filterGroupBox.SuspendLayout();
            searchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(12, 83);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.Size = new Size(670, 198);
            ordersDataGridView.TabIndex = 0;
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(resetButton);
            filterGroupBox.Controls.Add(applyButton);
            filterGroupBox.Location = new Point(373, 12);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(309, 65);
            filterGroupBox.TabIndex = 7;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Фільтрація";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(173, 26);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(127, 29);
            resetButton.TabIndex = 1;
            resetButton.Text = "Зняти фільтр";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(6, 26);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(161, 29);
            applyButton.TabIndex = 0;
            applyButton.Text = "Накласти фільтр";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Controls.Add(searchTextBox);
            searchGroupBox.Location = new Point(12, 12);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(355, 65);
            searchGroupBox.TabIndex = 6;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Пошук";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(255, 25);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 5;
            searchButton.Text = "Шукати";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(6, 26);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(243, 27);
            searchTextBox.TabIndex = 5;
            // 
            // UserOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 296);
            Controls.Add(filterGroupBox);
            Controls.Add(searchGroupBox);
            Controls.Add(ordersDataGridView);
            Name = "UserOrdersForm";
            Text = "UserOrdersForm";
            Load += UserOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            filterGroupBox.ResumeLayout(false);
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ordersDataGridView;
        private GroupBox filterGroupBox;
        private Button resetButton;
        private Button applyButton;
        private GroupBox searchGroupBox;
        private Button searchButton;
        private TextBox searchTextBox;
    }
}