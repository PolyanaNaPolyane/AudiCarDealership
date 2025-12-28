using System.ComponentModel;

namespace CarDealership.Forms;

partial class MainCustomerForm
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
        orderCountGroupBox = new GroupBox();
        ordersCountLabel = new Label();
        spentMoneyGroupBox = new GroupBox();
        spentMoneyLabel = new Label();
        customerStatisticsGroupBox = new GroupBox();
        welcomeGroupBox = new GroupBox();
        accountLabel = new Label();
        welcomeLabel = new Label();
        mainCustomerFormMenuStrip = new MenuStrip();
        carsToolStripMenuItem = new ToolStripMenuItem();
        ordersToolStripMenuItem = new ToolStripMenuItem();
        deleteAccountToolStripMenuItem = new ToolStripMenuItem();
        orderCountGroupBox.SuspendLayout();
        spentMoneyGroupBox.SuspendLayout();
        customerStatisticsGroupBox.SuspendLayout();
        welcomeGroupBox.SuspendLayout();
        mainCustomerFormMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // orderCountGroupBox
        // 
        orderCountGroupBox.Controls.Add(ordersCountLabel);
        orderCountGroupBox.Location = new Point(53, 61);
        orderCountGroupBox.Name = "orderCountGroupBox";
        orderCountGroupBox.Size = new Size(120, 120);
        orderCountGroupBox.TabIndex = 0;
        orderCountGroupBox.TabStop = false;
        orderCountGroupBox.Text = "Кількість замовлень";
        // 
        // ordersCountLabel
        // 
        ordersCountLabel.Location = new Point(6, 57);
        ordersCountLabel.Name = "ordersCountLabel";
        ordersCountLabel.Size = new Size(108, 23);
        ordersCountLabel.TabIndex = 0;
        ordersCountLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // spentMoneyGroupBox
        // 
        spentMoneyGroupBox.Controls.Add(spentMoneyLabel);
        spentMoneyGroupBox.Location = new Point(238, 61);
        spentMoneyGroupBox.Name = "spentMoneyGroupBox";
        spentMoneyGroupBox.Size = new Size(120, 120);
        spentMoneyGroupBox.TabIndex = 1;
        spentMoneyGroupBox.TabStop = false;
        spentMoneyGroupBox.Text = "Витрачена сума";
        // 
        // spentMoneyLabel
        // 
        spentMoneyLabel.Location = new Point(6, 57);
        spentMoneyLabel.Name = "spentMoneyLabel";
        spentMoneyLabel.Size = new Size(108, 23);
        spentMoneyLabel.TabIndex = 1;
        spentMoneyLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // customerStatisticsGroupBox
        // 
        customerStatisticsGroupBox.Controls.Add(orderCountGroupBox);
        customerStatisticsGroupBox.Controls.Add(spentMoneyGroupBox);
        customerStatisticsGroupBox.Location = new Point(12, 118);
        customerStatisticsGroupBox.Name = "customerStatisticsGroupBox";
        customerStatisticsGroupBox.Size = new Size(422, 195);
        customerStatisticsGroupBox.TabIndex = 2;
        customerStatisticsGroupBox.TabStop = false;
        customerStatisticsGroupBox.Text = "Статистика";
        // 
        // welcomeGroupBox
        // 
        welcomeGroupBox.Controls.Add(accountLabel);
        welcomeGroupBox.Controls.Add(welcomeLabel);
        welcomeGroupBox.Location = new Point(12, 31);
        welcomeGroupBox.Name = "welcomeGroupBox";
        welcomeGroupBox.Size = new Size(422, 81);
        welcomeGroupBox.TabIndex = 3;
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
        // mainCustomerFormMenuStrip
        // 
        mainCustomerFormMenuStrip.ImageScalingSize = new Size(20, 20);
        mainCustomerFormMenuStrip.Items.AddRange(new ToolStripItem[] { carsToolStripMenuItem, ordersToolStripMenuItem, deleteAccountToolStripMenuItem });
        mainCustomerFormMenuStrip.Location = new Point(0, 0);
        mainCustomerFormMenuStrip.Name = "mainCustomerFormMenuStrip";
        mainCustomerFormMenuStrip.Size = new Size(447, 28);
        mainCustomerFormMenuStrip.TabIndex = 4;
        mainCustomerFormMenuStrip.Text = "menuStrip1";
        // 
        // carsToolStripMenuItem
        // 
        carsToolStripMenuItem.Name = "carsToolStripMenuItem";
        carsToolStripMenuItem.Size = new Size(101, 24);
        carsToolStripMenuItem.Text = "Автомобілі";
        carsToolStripMenuItem.Click += carsToolStripMenuItem_Click;
        // 
        // ordersToolStripMenuItem
        // 
        ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
        ordersToolStripMenuItem.Size = new Size(109, 24);
        ordersToolStripMenuItem.Text = "Замовлення";
        ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
        // 
        // deleteAccountToolStripMenuItem
        // 
        deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
        deleteAccountToolStripMenuItem.Size = new Size(138, 24);
        deleteAccountToolStripMenuItem.Text = "Видалити акаунт";
        deleteAccountToolStripMenuItem.Click += deleteAccountToolStripMenuItem_Click;
        // 
        // MainCustomerForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(447, 324);
        Controls.Add(welcomeGroupBox);
        Controls.Add(customerStatisticsGroupBox);
        Controls.Add(mainCustomerFormMenuStrip);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = mainCustomerFormMenuStrip;
        MaximizeBox = false;
        Name = "MainCustomerForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Головне меню користувача";
        orderCountGroupBox.ResumeLayout(false);
        spentMoneyGroupBox.ResumeLayout(false);
        customerStatisticsGroupBox.ResumeLayout(false);
        welcomeGroupBox.ResumeLayout(false);
        mainCustomerFormMenuStrip.ResumeLayout(false);
        mainCustomerFormMenuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.MenuStrip mainCustomerFormMenuStrip;

    private System.Windows.Forms.Label accountLabel;

    private System.Windows.Forms.GroupBox welcomeGroupBox;
    private System.Windows.Forms.Label welcomeLabel;

    private System.Windows.Forms.GroupBox spentMoneyGroupBox;

    private System.Windows.Forms.GroupBox customerStatisticsGroupBox;
    private System.Windows.Forms.Label spentMoneyLabel;

    private System.Windows.Forms.GroupBox orderCountGroupBox;
    private System.Windows.Forms.Label ordersCountLabel;

    #endregion

    private ToolStripMenuItem carsToolStripMenuItem;
    private ToolStripMenuItem ordersToolStripMenuItem;
    private ToolStripMenuItem deleteAccountToolStripMenuItem;
}