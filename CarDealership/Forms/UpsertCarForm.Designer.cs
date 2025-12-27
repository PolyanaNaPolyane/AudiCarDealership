using System.ComponentModel;

namespace CarDealership.Forms;

partial class UpsertCarForm
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
        vinLabel = new Label();
        priceLabel = new Label();
        imageUrlLabel = new Label();
        colorLabel = new Label();
        statusLabel = new Label();
        yearLabel = new Label();
        technicalCharacteristicsLabel = new Label();
        dealerLabel = new Label();
        okButton = new Button();
        cancelButton = new Button();
        vinTextBox = new TextBox();
        priceTextBox = new TextBox();
        imageUrlTextBox = new TextBox();
        colorTextBox = new TextBox();
        yearTextBox = new TextBox();
        statusComboBox = new ComboBox();
        dealerComboBox = new ComboBox();
        technicalCharacteristicsComboBox = new ComboBox();
        SuspendLayout();
        // 
        // vinLabel
        // 
        vinLabel.AutoSize = true;
        vinLabel.Location = new Point(12, 9);
        vinLabel.Name = "vinLabel";
        vinLabel.Size = new Size(36, 20);
        vinLabel.TabIndex = 0;
        vinLabel.Text = "VIN:";
        // 
        // priceLabel
        // 
        priceLabel.AutoSize = true;
        priceLabel.Location = new Point(12, 53);
        priceLabel.Name = "priceLabel";
        priceLabel.Size = new Size(44, 20);
        priceLabel.TabIndex = 1;
        priceLabel.Text = "Ціна:";
        // 
        // imageUrlLabel
        // 
        imageUrlLabel.AutoSize = true;
        imageUrlLabel.Location = new Point(12, 101);
        imageUrlLabel.Name = "imageUrlLabel";
        imageUrlLabel.Size = new Size(77, 20);
        imageUrlLabel.TabIndex = 2;
        imageUrlLabel.Text = "Картинка:";
        // 
        // colorLabel
        // 
        colorLabel.AutoSize = true;
        colorLabel.Location = new Point(12, 153);
        colorLabel.Name = "colorLabel";
        colorLabel.Size = new Size(51, 20);
        colorLabel.TabIndex = 3;
        colorLabel.Text = "Колір:";
        // 
        // statusLabel
        // 
        statusLabel.AutoSize = true;
        statusLabel.Location = new Point(12, 255);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(55, 20);
        statusLabel.TabIndex = 4;
        statusLabel.Text = "Статус:";
        // 
        // yearLabel
        // 
        yearLabel.AutoSize = true;
        yearLabel.Location = new Point(12, 202);
        yearLabel.Name = "yearLabel";
        yearLabel.Size = new Size(31, 20);
        yearLabel.TabIndex = 5;
        yearLabel.Text = "Рік:";
        // 
        // technicalCharacteristicsLabel
        // 
        technicalCharacteristicsLabel.AutoSize = true;
        technicalCharacteristicsLabel.Location = new Point(12, 302);
        technicalCharacteristicsLabel.Name = "technicalCharacteristicsLabel";
        technicalCharacteristicsLabel.Size = new Size(182, 20);
        technicalCharacteristicsLabel.TabIndex = 6;
        technicalCharacteristicsLabel.Text = "Технічні характеристики:";
        // 
        // dealerLabel
        // 
        dealerLabel.AutoSize = true;
        dealerLabel.Location = new Point(17, 341);
        dealerLabel.Name = "dealerLabel";
        dealerLabel.Size = new Size(56, 20);
        dealerLabel.TabIndex = 7;
        dealerLabel.Text = "Дилер:";
        // 
        // okButton
        // 
        okButton.Location = new Point(54, 394);
        okButton.Name = "okButton";
        okButton.Size = new Size(94, 29);
        okButton.TabIndex = 8;
        okButton.Text = "ОК";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += okButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(230, 394);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(94, 29);
        cancelButton.TabIndex = 9;
        cancelButton.Text = "Відмінити";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        // 
        // vinTextBox
        // 
        vinTextBox.Enabled = false;
        vinTextBox.Location = new Point(54, 6);
        vinTextBox.Name = "vinTextBox";
        vinTextBox.Size = new Size(125, 27);
        vinTextBox.TabIndex = 10;
        // 
        // priceTextBox
        // 
        priceTextBox.Location = new Point(62, 53);
        priceTextBox.Name = "priceTextBox";
        priceTextBox.Size = new Size(125, 27);
        priceTextBox.TabIndex = 11;
        // 
        // imageUrlTextBox
        // 
        imageUrlTextBox.Location = new Point(95, 98);
        imageUrlTextBox.Name = "imageUrlTextBox";
        imageUrlTextBox.Size = new Size(125, 27);
        imageUrlTextBox.TabIndex = 12;
        // 
        // colorTextBox
        // 
        colorTextBox.Location = new Point(69, 150);
        colorTextBox.Name = "colorTextBox";
        colorTextBox.Size = new Size(125, 27);
        colorTextBox.TabIndex = 13;
        // 
        // yearTextBox
        // 
        yearTextBox.Location = new Point(49, 195);
        yearTextBox.Name = "yearTextBox";
        yearTextBox.Size = new Size(125, 27);
        yearTextBox.TabIndex = 14;
        // 
        // statusComboBox
        // 
        statusComboBox.FormattingEnabled = true;
        statusComboBox.Location = new Point(73, 252);
        statusComboBox.Name = "statusComboBox";
        statusComboBox.Size = new Size(151, 28);
        statusComboBox.TabIndex = 15;
        // 
        // dealerComboBox
        // 
        dealerComboBox.FormattingEnabled = true;
        dealerComboBox.Location = new Point(79, 338);
        dealerComboBox.Name = "dealerComboBox";
        dealerComboBox.Size = new Size(151, 28);
        dealerComboBox.TabIndex = 16;
        // 
        // technicalCharacteristicsComboBox
        // 
        technicalCharacteristicsComboBox.FormattingEnabled = true;
        technicalCharacteristicsComboBox.Location = new Point(200, 299);
        technicalCharacteristicsComboBox.Name = "technicalCharacteristicsComboBox";
        technicalCharacteristicsComboBox.Size = new Size(151, 28);
        technicalCharacteristicsComboBox.TabIndex = 17;
        // 
        // UpsertCarForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(362, 450);
        Controls.Add(technicalCharacteristicsComboBox);
        Controls.Add(dealerComboBox);
        Controls.Add(statusComboBox);
        Controls.Add(yearTextBox);
        Controls.Add(colorTextBox);
        Controls.Add(imageUrlTextBox);
        Controls.Add(priceTextBox);
        Controls.Add(vinTextBox);
        Controls.Add(cancelButton);
        Controls.Add(okButton);
        Controls.Add(dealerLabel);
        Controls.Add(technicalCharacteristicsLabel);
        Controls.Add(yearLabel);
        Controls.Add(statusLabel);
        Controls.Add(colorLabel);
        Controls.Add(imageUrlLabel);
        Controls.Add(priceLabel);
        Controls.Add(vinLabel);
        Name = "UpsertCarForm";
        Load += UpsertCarForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label vinLabel;
    private Label priceLabel;
    private Label imageUrlLabel;
    private Label colorLabel;
    private Label statusLabel;
    private Label yearLabel;
    private Label technicalCharacteristicsLabel;
    private Label dealerLabel;
    private Button okButton;
    private Button cancelButton;
    private TextBox vinTextBox;
    private TextBox priceTextBox;
    private TextBox imageUrlTextBox;
    private TextBox colorTextBox;
    private TextBox yearTextBox;
    private ComboBox statusComboBox;
    private ComboBox dealerComboBox;
    private ComboBox technicalCharacteristicsComboBox;
}