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
        orderCountGroupBox = new GroupBox();
        carsCountLabel = new Label();
        spentMoneyGroupBox = new GroupBox();
        mostPopularCarsLabel = new Label();
        welcomeGroupBox = new GroupBox();
        accountLabel = new Label();
        welcomeLabel = new Label();
        statisticsGroupBox.SuspendLayout();
        orderCountGroupBox.SuspendLayout();
        spentMoneyGroupBox.SuspendLayout();
        welcomeGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // statisticsGroupBox
        // 
        statisticsGroupBox.Controls.Add(orderCountGroupBox);
        statisticsGroupBox.Controls.Add(spentMoneyGroupBox);
        statisticsGroupBox.Location = new Point(12, 99);
        statisticsGroupBox.Name = "statisticsGroupBox";
        statisticsGroupBox.Size = new Size(422, 168);
        statisticsGroupBox.TabIndex = 3;
        statisticsGroupBox.TabStop = false;
        statisticsGroupBox.Text = "Статистика";
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
        spentMoneyGroupBox.Text = "Найпопулярніша модель";
        // 
        // mostPopularCarsLabel
        // 
        mostPopularCarsLabel.Location = new Point(6, 57);
        mostPopularCarsLabel.Name = "mostPopularCarsLabel";
        mostPopularCarsLabel.Size = new Size(168, 23);
        mostPopularCarsLabel.TabIndex = 1;
        mostPopularCarsLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // welcomeGroupBox
        // 
        welcomeGroupBox.Controls.Add(accountLabel);
        welcomeGroupBox.Controls.Add(welcomeLabel);
        welcomeGroupBox.Location = new Point(12, 12);
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
        // MainManagerForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(447, 282);
        Controls.Add(welcomeGroupBox);
        Controls.Add(statisticsGroupBox);
        Name = "MainManagerForm";
        Text = "MainManagerForm";
        Load += MainManagerForm_Load;
        statisticsGroupBox.ResumeLayout(false);
        orderCountGroupBox.ResumeLayout(false);
        spentMoneyGroupBox.ResumeLayout(false);
        welcomeGroupBox.ResumeLayout(false);
        ResumeLayout(false);
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
}