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
            menuStrip = new MenuStrip();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            deleteOrderToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            filterGroupBox.SuspendLayout();
            searchGroupBox.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(12, 102);
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.Size = new Size(539, 150);
            ordersDataGridView.TabIndex = 0;
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(resetButton);
            filterGroupBox.Controls.Add(applyButton);
            filterGroupBox.Location = new Point(285, 31);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(266, 65);
            filterGroupBox.TabIndex = 7;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Фільтрація";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(147, 26);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(109, 29);
            resetButton.TabIndex = 1;
            resetButton.Text = "Зняти фільтр";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(6, 26);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(135, 29);
            applyButton.TabIndex = 0;
            applyButton.Text = "Накласти фільтр";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Controls.Add(searchTextBox);
            searchGroupBox.Location = new Point(12, 31);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(267, 65);
            searchGroupBox.TabIndex = 6;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Пошук";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(163, 24);
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
            searchTextBox.Size = new Size(151, 27);
            searchTextBox.TabIndex = 5;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(562, 28);
            menuStrip.TabIndex = 8;
            menuStrip.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem, deleteOrderToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(41, 24);
            actionsToolStripMenuItem.Text = "Дії";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(247, 26);
            exportToolStripMenuItem.Text = "Експортувати";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // deleteOrderToolStripMenuItem
            // 
            deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            deleteOrderToolStripMenuItem.Size = new Size(247, 26);
            deleteOrderToolStripMenuItem.Text = "Видалити замовлення";
            deleteOrderToolStripMenuItem.Click += deleteOrderToolStripMenuItem_Click;
            // 
            // UserOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 263);
            Controls.Add(filterGroupBox);
            Controls.Add(searchGroupBox);
            Controls.Add(ordersDataGridView);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "UserOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Замовлення";
            Load += UserOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            filterGroupBox.ResumeLayout(false);
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ordersDataGridView;
        private GroupBox filterGroupBox;
        private Button resetButton;
        private Button applyButton;
        private GroupBox searchGroupBox;
        private Button searchButton;
        private TextBox searchTextBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem deleteOrderToolStripMenuItem;
    }
}