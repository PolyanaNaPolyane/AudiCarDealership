using System.ComponentModel;

namespace CarDealership.Forms;

partial class UserCarsForm
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
        components = new Container();
        carsBindingSource = new BindingSource(components);
        carsDataGridView = new DataGridView();
        menuStrip1 = new MenuStrip();
        діїToolStripMenuItem = new ToolStripMenuItem();
        orderToolStripMenuItem = new ToolStripMenuItem();
        viewDetailsToolStripMenuItem = new ToolStripMenuItem();
        searchGroupBox = new GroupBox();
        searchButton = new Button();
        searchTextBox = new TextBox();
        filterGroupBox = new GroupBox();
        resetButton = new Button();
        applyButton = new Button();
        ((ISupportInitialize)carsBindingSource).BeginInit();
        ((ISupportInitialize)carsDataGridView).BeginInit();
        menuStrip1.SuspendLayout();
        searchGroupBox.SuspendLayout();
        filterGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // carsDataGridView
        // 
        carsDataGridView.ColumnHeadersHeight = 29;
        carsDataGridView.Location = new Point(12, 102);
        carsDataGridView.Name = "carsDataGridView";
        carsDataGridView.RowHeadersWidth = 51;
        carsDataGridView.Size = new Size(670, 198);
        carsDataGridView.TabIndex = 0;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { діїToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(696, 28);
        menuStrip1.TabIndex = 3;
        menuStrip1.Text = "menuStrip1";
        // 
        // діїToolStripMenuItem
        // 
        діїToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { orderToolStripMenuItem, viewDetailsToolStripMenuItem });
        діїToolStripMenuItem.Name = "діїToolStripMenuItem";
        діїToolStripMenuItem.Size = new Size(41, 24);
        діїToolStripMenuItem.Text = "Дії";
        // 
        // orderToolStripMenuItem
        // 
        orderToolStripMenuItem.Name = "orderToolStripMenuItem";
        orderToolStripMenuItem.Size = new Size(227, 26);
        orderToolStripMenuItem.Text = "Замовити";
        orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
        // 
        // viewDetailsToolStripMenuItem
        // 
        viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
        viewDetailsToolStripMenuItem.Size = new Size(227, 26);
        viewDetailsToolStripMenuItem.Text = "Переглянути деталі";
        viewDetailsToolStripMenuItem.Click += viewDetailsToolStripMenuItem_Click;
        // 
        // searchGroupBox
        // 
        searchGroupBox.Controls.Add(searchButton);
        searchGroupBox.Controls.Add(searchTextBox);
        searchGroupBox.Location = new Point(12, 31);
        searchGroupBox.Name = "searchGroupBox";
        searchGroupBox.Size = new Size(355, 65);
        searchGroupBox.TabIndex = 4;
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
        // filterGroupBox
        // 
        filterGroupBox.Controls.Add(resetButton);
        filterGroupBox.Controls.Add(applyButton);
        filterGroupBox.Location = new Point(373, 31);
        filterGroupBox.Name = "filterGroupBox";
        filterGroupBox.Size = new Size(309, 65);
        filterGroupBox.TabIndex = 5;
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
        // UserCarsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(696, 314);
        Controls.Add(filterGroupBox);
        Controls.Add(searchGroupBox);
        Controls.Add(carsDataGridView);
        Controls.Add(menuStrip1);
        Name = "UserCarsForm";
        Text = "Автомобілі";
        Load += CarsForm_Load;
        ((ISupportInitialize)carsBindingSource).EndInit();
        ((ISupportInitialize)carsDataGridView).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        searchGroupBox.ResumeLayout(false);
        searchGroupBox.PerformLayout();
        filterGroupBox.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.BindingSource carsBindingSource;
    private System.Windows.Forms.DataGridView carsDataGridView;

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem діїToolStripMenuItem;
    private ToolStripMenuItem orderToolStripMenuItem;
    private ToolStripMenuItem viewDetailsToolStripMenuItem;
    private GroupBox searchGroupBox;
    private Button searchButton;
    private TextBox searchTextBox;
    private GroupBox filterGroupBox;
    private Button resetButton;
    private Button applyButton;
}