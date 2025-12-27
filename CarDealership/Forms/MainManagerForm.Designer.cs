using System.ComponentModel;

namespace CarDealership.Forms;

partial class MainManagerForm
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
        statisticsGroupBox = new GroupBox();
        overallProfitGroupBox = new GroupBox();
        overallProfitLabel = new Label();
        orderCountGroupBox = new GroupBox();
        carsCountLabel = new Label();
        spentMoneyGroupBox = new GroupBox();
        mostPopularCarsLabel = new Label();
        welcomeGroupBox = new GroupBox();
        accountLabel = new Label();
        welcomeLabel = new Label();
        menuStrip1 = new MenuStrip();
        statisticsToolStripMenuItem = new ToolStripMenuItem();
        tablesToolStripMenuItem = new ToolStripMenuItem();
        statisticsPanel = new Panel();
        statisticsGroupBox.SuspendLayout();
        overallProfitGroupBox.SuspendLayout();
        orderCountGroupBox.SuspendLayout();
        spentMoneyGroupBox.SuspendLayout();
        welcomeGroupBox.SuspendLayout();
        menuStrip1.SuspendLayout();
        statisticsPanel.SuspendLayout();
        SuspendLayout();
        // 
        // statisticsGroupBox
        // 
        statisticsGroupBox.Controls.Add(overallProfitGroupBox);
        statisticsGroupBox.Controls.Add(orderCountGroupBox);
        statisticsGroupBox.Controls.Add(spentMoneyGroupBox);
        statisticsGroupBox.Location = new Point(15, 90);
        statisticsGroupBox.Name = "statisticsGroupBox";
        statisticsGroupBox.Size = new Size(422, 250);
        statisticsGroupBox.TabIndex = 3;
        statisticsGroupBox.TabStop = false;
        statisticsGroupBox.Text = "Статистика";
        // 
        // overallProfitGroupBox
        // 
        overallProfitGroupBox.Controls.Add(overallProfitLabel);
        overallProfitGroupBox.Location = new Point(87, 161);
        overallProfitGroupBox.Name = "overallProfitGroupBox";
        overallProfitGroupBox.Size = new Size(250, 77);
        overallProfitGroupBox.TabIndex = 2;
        overallProfitGroupBox.TabStop = false;
        overallProfitGroupBox.Text = "Загальний прибуток";
        // 
        // overallProfitLabel
        // 
        overallProfitLabel.Location = new Point(6, 32);
        overallProfitLabel.Name = "overallProfitLabel";
        overallProfitLabel.Size = new Size(238, 23);
        overallProfitLabel.TabIndex = 1;
        overallProfitLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // orderCountGroupBox
        // 
        orderCountGroupBox.Controls.Add(carsCountLabel);
        orderCountGroupBox.Location = new Point(6, 35);
        orderCountGroupBox.Name = "orderCountGroupBox";
        orderCountGroupBox.Size = new Size(203, 120);
        orderCountGroupBox.TabIndex = 0;
        orderCountGroupBox.TabStop = false;
        orderCountGroupBox.Text = "Кількість автомобілей для продажу";
        // 
        // carsCountLabel
        // 
        carsCountLabel.Location = new Point(6, 57);
        carsCountLabel.Name = "carsCountLabel";
        carsCountLabel.Size = new Size(191, 23);
        carsCountLabel.TabIndex = 0;
        carsCountLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // spentMoneyGroupBox
        // 
        spentMoneyGroupBox.Controls.Add(mostPopularCarsLabel);
        spentMoneyGroupBox.Location = new Point(227, 35);
        spentMoneyGroupBox.Name = "spentMoneyGroupBox";
        spentMoneyGroupBox.Size = new Size(180, 120);
        spentMoneyGroupBox.TabIndex = 1;
        spentMoneyGroupBox.TabStop = false;
        spentMoneyGroupBox.Text = "Найпопулярніші моделі";
        // 
        // mostPopularCarsLabel
        // 
        mostPopularCarsLabel.Location = new Point(6, 39);
        mostPopularCarsLabel.Name = "mostPopularCarsLabel";
        mostPopularCarsLabel.Size = new Size(168, 60);
        mostPopularCarsLabel.TabIndex = 1;
        mostPopularCarsLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // welcomeGroupBox
        // 
        welcomeGroupBox.Controls.Add(accountLabel);
        welcomeGroupBox.Controls.Add(welcomeLabel);
        welcomeGroupBox.Location = new Point(15, 3);
        welcomeGroupBox.Name = "welcomeGroupBox";
        welcomeGroupBox.Size = new Size(422, 81);
        welcomeGroupBox.TabIndex = 4;
        welcomeGroupBox.TabStop = false;
        // 
        // accountLabel
        // 
        accountLabel.Location = new Point(6, 46);
        accountLabel.Name = "accountLabel";
        accountLabel.Size = new Size(410, 23);
        accountLabel.TabIndex = 1;
        accountLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // welcomeLabel
        // 
        welcomeLabel.Location = new Point(6, 23);
        welcomeLabel.Name = "welcomeLabel";
        welcomeLabel.Size = new Size(410, 23);
        welcomeLabel.TabIndex = 0;
        welcomeLabel.Text = "Ласкаво просимо";
        welcomeLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { statisticsToolStripMenuItem, tablesToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(478, 28);
        menuStrip1.TabIndex = 5;
        menuStrip1.Text = "menuStrip";
        // 
        // statisticsToolStripMenuItem
        // 
        statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
        statisticsToolStripMenuItem.Size = new Size(98, 24);
        statisticsToolStripMenuItem.Text = "Статистика";
        // 
        // tablesToolStripMenuItem
        // 
        tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
        tablesToolStripMenuItem.Size = new Size(78, 24);
        tablesToolStripMenuItem.Text = "Таблиці";
        tablesToolStripMenuItem.Click += tablesToolStripMenuItem_Click;
        // 
        // statisticsPanel
        // 
        statisticsPanel.Controls.Add(welcomeGroupBox);
        statisticsPanel.Controls.Add(statisticsGroupBox);
        statisticsPanel.Location = new Point(12, 31);
        statisticsPanel.Name = "statisticsPanel";
        statisticsPanel.Size = new Size(454, 353);
        statisticsPanel.TabIndex = 6;
        // 
        // MainManagerForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(478, 398);
        Controls.Add(statisticsPanel);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "MainManagerForm";
        Text = "Головне меню менеджера";
        Load += MainManagerForm_Load;
        statisticsGroupBox.ResumeLayout(false);
        overallProfitGroupBox.ResumeLayout(false);
        orderCountGroupBox.ResumeLayout(false);
        spentMoneyGroupBox.ResumeLayout(false);
        welcomeGroupBox.ResumeLayout(false);
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statisticsPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox statisticsGroupBox;
    private GroupBox orderCountGroupBox;
    private Label carsCountLabel;
    private GroupBox spentMoneyGroupBox;
    private Label mostPopularCarsLabel;
    private GroupBox welcomeGroupBox;
    private Label accountLabel;
    private Label welcomeLabel;
    private GroupBox overallProfitGroupBox;
    private Label overallProfitLabel;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem statisticsToolStripMenuItem;
    private ToolStripMenuItem tablesToolStripMenuItem;
    private Panel statisticsPanel;
}