using System.ComponentModel;

namespace CarDealership.Forms;

partial class UpsertOrderForm
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
        accountLabel = new Label();
        carLabel = new Label();
        createdDateLabel = new Label();
        overallPriceLabel = new Label();
        statusLabel = new Label();
        okButton = new Button();
        cancelButton = new Button();
        accountComboBox = new ComboBox();
        carComboBox = new ComboBox();
        statusComboBox = new ComboBox();
        orderCreationDateTimePicker = new DateTimePicker();
        overallPriceTextBox = new TextBox();
        SuspendLayout();
        // 
        // accountLabel
        // 
        accountLabel.AutoSize = true;
        accountLabel.Location = new Point(12, 9);
        accountLabel.Name = "accountLabel";
        accountLabel.Size = new Size(59, 20);
        accountLabel.TabIndex = 0;
        accountLabel.Text = "Акаунт:";
        // 
        // carLabel
        // 
        carLabel.AutoSize = true;
        carLabel.Location = new Point(12, 50);
        carLabel.Name = "carLabel";
        carLabel.Size = new Size(71, 20);
        carLabel.TabIndex = 1;
        carLabel.Text = "Машина:";
        // 
        // createdDateLabel
        // 
        createdDateLabel.AutoSize = true;
        createdDateLabel.Location = new Point(12, 87);
        createdDateLabel.Name = "createdDateLabel";
        createdDateLabel.Size = new Size(121, 20);
        createdDateLabel.TabIndex = 2;
        createdDateLabel.Text = "Дата створення:";
        // 
        // overallPriceLabel
        // 
        overallPriceLabel.AutoSize = true;
        overallPriceLabel.Location = new Point(12, 126);
        overallPriceLabel.Name = "overallPriceLabel";
        overallPriceLabel.Size = new Size(109, 20);
        overallPriceLabel.TabIndex = 3;
        overallPriceLabel.Text = "Загальна ціна:";
        // 
        // statusLabel
        // 
        statusLabel.AutoSize = true;
        statusLabel.Location = new Point(12, 165);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(55, 20);
        statusLabel.TabIndex = 4;
        statusLabel.Text = "Статус:";
        // 
        // okButton
        // 
        okButton.Location = new Point(89, 209);
        okButton.Name = "okButton";
        okButton.Size = new Size(94, 29);
        okButton.TabIndex = 5;
        okButton.Text = "ОК";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += okButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(235, 209);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(94, 29);
        cancelButton.TabIndex = 6;
        cancelButton.Text = "Відмінити";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        // 
        // accountComboBox
        // 
        accountComboBox.FormattingEnabled = true;
        accountComboBox.Location = new Point(77, 6);
        accountComboBox.Name = "accountComboBox";
        accountComboBox.Size = new Size(151, 28);
        accountComboBox.TabIndex = 7;
        // 
        // carComboBox
        // 
        carComboBox.FormattingEnabled = true;
        carComboBox.Location = new Point(89, 47);
        carComboBox.Name = "carComboBox";
        carComboBox.Size = new Size(151, 28);
        carComboBox.TabIndex = 8;
        // 
        // statusComboBox
        // 
        statusComboBox.FormattingEnabled = true;
        statusComboBox.Location = new Point(73, 162);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new Size(151, 28);
        statusComboBox.TabIndex = 9;
        // 
        // orderCreationDateTimePicker
        // 
        orderCreationDateTimePicker.Location = new Point(139, 82);
        orderCreationDateTimePicker.Name = "orderCreationDateTimePicker";
        orderCreationDateTimePicker.Size = new Size(250, 27);
        orderCreationDateTimePicker.TabIndex = 10;
        // 
        // overallPriceTextBox
        // 
        overallPriceTextBox.Location = new Point(127, 123);
        overallPriceTextBox.Name = "overallPriceTextBox";
        overallPriceTextBox.Size = new Size(125, 27);
        overallPriceTextBox.TabIndex = 11;
        // 
        // UpsertOrderForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(404, 248);
        Controls.Add(overallPriceTextBox);
        Controls.Add(orderCreationDateTimePicker);
        Controls.Add(statusComboBox);
        Controls.Add(carComboBox);
        Controls.Add(accountComboBox);
        Controls.Add(cancelButton);
        Controls.Add(okButton);
        Controls.Add(statusLabel);
        Controls.Add(overallPriceLabel);
        Controls.Add(createdDateLabel);
        Controls.Add(carLabel);
        Controls.Add(accountLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "UpsertOrderForm";
        StartPosition = FormStartPosition.CenterScreen;
        Load += UpsertOrderForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label accountLabel;
    private Label carLabel;
    private Label createdDateLabel;
    private Label overallPriceLabel;
    private Label statusLabel;
    private Button okButton;
    private Button cancelButton;
    private ComboBox accountComboBox;
    private ComboBox carComboBox;
    private ComboBox statusComboBox;
    private DateTimePicker orderCreationDateTimePicker;
    private TextBox overallPriceTextBox;
}