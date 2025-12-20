using System.ComponentModel;

namespace CarDealership.Forms;

partial class ManagerTablesForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        filterGroupBox = new GroupBox();
        resetButton = new Button();
        applyButton = new Button();
        searchGroupBox = new GroupBox();
        searchButton = new Button();
        searchTextBox = new TextBox();
        dataGridView = new DataGridView();
        menuStrip1 = new MenuStrip();
        tablesToolStripMenuItem = new ToolStripMenuItem();
        modelsToolStripMenuItem = new ToolStripMenuItem();
        technicalCharacteristicsToolStripMenuItem = new ToolStripMenuItem();
        carsToolStripMenuItem = new ToolStripMenuItem();
        dealersToolStripMenuItem = new ToolStripMenuItem();
        accountsToolStripMenuItem = new ToolStripMenuItem();
        ordersToolStripMenuItem = new ToolStripMenuItem();
        contactDetailsToolStripMenuItem = new ToolStripMenuItem();
        tableLabel = new Label();
        filterGroupBox.SuspendLayout();
        searchGroupBox.SuspendLayout();
        ((ISupportInitialize)dataGridView).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // filterGroupBox
        // 
        filterGroupBox.Controls.Add(resetButton);
        filterGroupBox.Controls.Add(applyButton);
        filterGroupBox.Location = new Point(373, 31);
        filterGroupBox.Name = "filterGroupBox";
        filterGroupBox.Size = new Size(309, 65);
        filterGroupBox.TabIndex = 8;
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
        // 
        // applyButton
        // 
        applyButton.Location = new Point(6, 26);
        applyButton.Name = "applyButton";
        applyButton.Size = new Size(161, 29);
        applyButton.TabIndex = 0;
        applyButton.Text = "Накласти фільтр";
        applyButton.UseVisualStyleBackColor = true;
        // 
        // searchGroupBox
        // 
        searchGroupBox.Controls.Add(searchButton);
        searchGroupBox.Controls.Add(searchTextBox);
        searchGroupBox.Location = new Point(12, 31);
        searchGroupBox.Name = "searchGroupBox";
        searchGroupBox.Size = new Size(355, 65);
        searchGroupBox.TabIndex = 7;
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
        // 
        // searchTextBox
        // 
        searchTextBox.Location = new Point(6, 26);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.Size = new Size(243, 27);
        searchTextBox.TabIndex = 5;
        // 
        // dataGridView
        // 
        dataGridView.ColumnHeadersHeight = 29;
        dataGridView.Location = new Point(12, 127);
        dataGridView.Name = "dataGridView";
        dataGridView.RowHeadersWidth = 51;
        dataGridView.Size = new Size(670, 198);
        dataGridView.TabIndex = 6;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { tablesToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 28);
        menuStrip1.TabIndex = 9;
        menuStrip1.Text = "menuStrip1";
        // 
        // tablesToolStripMenuItem
        // 
        tablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modelsToolStripMenuItem, technicalCharacteristicsToolStripMenuItem, carsToolStripMenuItem, dealersToolStripMenuItem, accountsToolStripMenuItem, ordersToolStripMenuItem, contactDetailsToolStripMenuItem });
        tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
        tablesToolStripMenuItem.Size = new Size(78, 24);
        tablesToolStripMenuItem.Text = "Таблиці";
        // 
        // modelsToolStripMenuItem
        // 
        modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
        modelsToolStripMenuItem.Size = new Size(262, 26);
        modelsToolStripMenuItem.Text = "Моделі";
        modelsToolStripMenuItem.Click += modelsToolStripMenuItem_Click;
        // 
        // technicalCharacteristicsToolStripMenuItem
        // 
        technicalCharacteristicsToolStripMenuItem.Name = "technicalCharacteristicsToolStripMenuItem";
        technicalCharacteristicsToolStripMenuItem.Size = new Size(262, 26);
        technicalCharacteristicsToolStripMenuItem.Text = "Технічні характеристики";
        technicalCharacteristicsToolStripMenuItem.Click += technicalCharacteristicsToolStripMenuItem_Click;
        // 
        // carsToolStripMenuItem
        // 
        carsToolStripMenuItem.Name = "carsToolStripMenuItem";
        carsToolStripMenuItem.Size = new Size(262, 26);
        carsToolStripMenuItem.Text = "Автомобілі";
        carsToolStripMenuItem.Click += carsToolStripMenuItem_Click;
        // 
        // dealersToolStripMenuItem
        // 
        dealersToolStripMenuItem.Name = "dealersToolStripMenuItem";
        dealersToolStripMenuItem.Size = new Size(262, 26);
        dealersToolStripMenuItem.Text = "Дилери";
        dealersToolStripMenuItem.Click += dealersToolStripMenuItem_Click;
        // 
        // accountsToolStripMenuItem
        // 
        accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
        accountsToolStripMenuItem.Size = new Size(262, 26);
        accountsToolStripMenuItem.Text = "Акаунти";
        accountsToolStripMenuItem.Click += accountsToolStripMenuItem_Click;
        // 
        // ordersToolStripMenuItem
        // 
        ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
        ordersToolStripMenuItem.Size = new Size(262, 26);
        ordersToolStripMenuItem.Text = "Замовлення";
        ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
        // 
        // contactDetailsToolStripMenuItem
        // 
        contactDetailsToolStripMenuItem.Name = "contactDetailsToolStripMenuItem";
        contactDetailsToolStripMenuItem.Size = new Size(262, 26);
        contactDetailsToolStripMenuItem.Text = "Контактні дані";
        contactDetailsToolStripMenuItem.Click += contactDetailsToolStripMenuItem_Click;
        // 
        // tableLabel
        // 
        tableLabel.AutoSize = true;
        tableLabel.Location = new Point(12, 104);
        tableLabel.Name = "tableLabel";
        tableLabel.Size = new Size(50, 20);
        tableLabel.TabIndex = 10;
        tableLabel.Text = "label1";
        // 
        // ManagerTablesForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tableLabel);
        Controls.Add(filterGroupBox);
        Controls.Add(searchGroupBox);
        Controls.Add(dataGridView);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "ManagerTablesForm";
        Text = "ManagerTablesForm";
        Load += ManagerTablesForm_Load;
        filterGroupBox.ResumeLayout(false);
        searchGroupBox.ResumeLayout(false);
        searchGroupBox.PerformLayout();
        ((ISupportInitialize)dataGridView).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox filterGroupBox;
    private Button resetButton;
    private Button applyButton;
    private GroupBox searchGroupBox;
    private Button searchButton;
    private TextBox searchTextBox;
    private DataGridView dataGridView;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem tablesToolStripMenuItem;
    private ToolStripMenuItem modelsToolStripMenuItem;
    private ToolStripMenuItem technicalCharacteristicsToolStripMenuItem;
    private ToolStripMenuItem carsToolStripMenuItem;
    private ToolStripMenuItem dealersToolStripMenuItem;
    private ToolStripMenuItem accountsToolStripMenuItem;
    private ToolStripMenuItem ordersToolStripMenuItem;
    private ToolStripMenuItem contactDetailsToolStripMenuItem;
    private Label tableLabel;
}