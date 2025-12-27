using System.ComponentModel;

namespace CarDealership.Forms;

partial class CarsFilteringForm
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
        colorCheckedListBox = new CheckedListBox();
        priceFromLabel = new Label();
        priceToLabel = new Label();
        priceFromTextBox = new TextBox();
        priceToTextBox = new TextBox();
        okButton = new Button();
        colorGroupBox = new GroupBox();
        priceGroupBox = new GroupBox();
        bodyTypeGroupBox = new GroupBox();
        bodyTypeCheckedListBox = new CheckedListBox();
        engineTypeGroupBox = new GroupBox();
        engineCheckedListBox = new CheckedListBox();
        transmissionTypeGroupBox = new GroupBox();
        transmissionCheckedListBox = new CheckedListBox();
        colorGroupBox.SuspendLayout();
        priceGroupBox.SuspendLayout();
        bodyTypeGroupBox.SuspendLayout();
        engineTypeGroupBox.SuspendLayout();
        transmissionTypeGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // colorCheckedListBox
        // 
        colorCheckedListBox.FormattingEnabled = true;
        colorCheckedListBox.Items.AddRange(new object[] { "Red", "White", "Blue", "Black", "Pink", "Yellow" });
        colorCheckedListBox.Location = new Point(15, 26);
        colorCheckedListBox.Name = "colorCheckedListBox";
        colorCheckedListBox.Size = new Size(150, 114);
        colorCheckedListBox.TabIndex = 0;
        // 
        // priceFromLabel
        // 
        priceFromLabel.AutoSize = true;
        priceFromLabel.Location = new Point(6, 23);
        priceFromLabel.Name = "priceFromLabel";
        priceFromLabel.Size = new Size(33, 20);
        priceFromLabel.TabIndex = 1;
        priceFromLabel.Text = "Від:";
        // 
        // priceToLabel
        // 
        priceToLabel.AutoSize = true;
        priceToLabel.Location = new Point(6, 59);
        priceToLabel.Name = "priceToLabel";
        priceToLabel.Size = new Size(31, 20);
        priceToLabel.TabIndex = 2;
        priceToLabel.Text = "До:";
        // 
        // priceFromTextBox
        // 
        priceFromTextBox.Location = new Point(71, 23);
        priceFromTextBox.Name = "priceFromTextBox";
        priceFromTextBox.Size = new Size(125, 27);
        priceFromTextBox.TabIndex = 3;
        // 
        // priceToTextBox
        // 
        priceToTextBox.Location = new Point(71, 56);
        priceToTextBox.Name = "priceToTextBox";
        priceToTextBox.Size = new Size(125, 27);
        priceToTextBox.TabIndex = 4;
        // 
        // okButton
        // 
        okButton.Location = new Point(272, 305);
        okButton.Name = "okButton";
        okButton.Size = new Size(94, 29);
        okButton.TabIndex = 5;
        okButton.Text = "ОК";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += okButton_Click;
        // 
        // colorGroupBox
        // 
        colorGroupBox.Controls.Add(colorCheckedListBox);
        colorGroupBox.Location = new Point(12, 12);
        colorGroupBox.Name = "colorGroupBox";
        colorGroupBox.Size = new Size(183, 155);
        colorGroupBox.TabIndex = 6;
        colorGroupBox.TabStop = false;
        colorGroupBox.Text = "Колір";
        // 
        // priceGroupBox
        // 
        priceGroupBox.Controls.Add(priceFromLabel);
        priceGroupBox.Controls.Add(priceToLabel);
        priceGroupBox.Controls.Add(priceFromTextBox);
        priceGroupBox.Controls.Add(priceToTextBox);
        priceGroupBox.Location = new Point(201, 12);
        priceGroupBox.Name = "priceGroupBox";
        priceGroupBox.Size = new Size(209, 100);
        priceGroupBox.TabIndex = 7;
        priceGroupBox.TabStop = false;
        priceGroupBox.Text = "Ціна";
        // 
        // bodyTypeGroupBox
        // 
        bodyTypeGroupBox.Controls.Add(bodyTypeCheckedListBox);
        bodyTypeGroupBox.Location = new Point(12, 173);
        bodyTypeGroupBox.Name = "bodyTypeGroupBox";
        bodyTypeGroupBox.Size = new Size(183, 114);
        bodyTypeGroupBox.TabIndex = 8;
        bodyTypeGroupBox.TabStop = false;
        bodyTypeGroupBox.Text = "Тип кузова";
        // 
        // bodyTypeCheckedListBox
        // 
        bodyTypeCheckedListBox.FormattingEnabled = true;
        bodyTypeCheckedListBox.Items.AddRange(new object[] { "Седан", "Хетчбек", "Купе" });
        bodyTypeCheckedListBox.Location = new Point(18, 26);
        bodyTypeCheckedListBox.Name = "bodyTypeCheckedListBox";
        bodyTypeCheckedListBox.Size = new Size(147, 70);
        bodyTypeCheckedListBox.TabIndex = 11;
        // 
        // engineTypeGroupBox
        // 
        engineTypeGroupBox.Controls.Add(engineCheckedListBox);
        engineTypeGroupBox.Location = new Point(416, 12);
        engineTypeGroupBox.Name = "engineTypeGroupBox";
        engineTypeGroupBox.Size = new Size(183, 136);
        engineTypeGroupBox.TabIndex = 9;
        engineTypeGroupBox.TabStop = false;
        engineTypeGroupBox.Text = "Тип двигуна";
        // 
        // engineCheckedListBox
        // 
        engineCheckedListBox.FormattingEnabled = true;
        engineCheckedListBox.Items.AddRange(new object[] { "Дизельний", "Бензиновий", "Електричний", "Гібридний" });
        engineCheckedListBox.Location = new Point(19, 26);
        engineCheckedListBox.Name = "engineCheckedListBox";
        engineCheckedListBox.Size = new Size(150, 92);
        engineCheckedListBox.TabIndex = 0;
        // 
        // transmissionTypeGroupBox
        // 
        transmissionTypeGroupBox.Controls.Add(transmissionCheckedListBox);
        transmissionTypeGroupBox.Location = new Point(201, 118);
        transmissionTypeGroupBox.Name = "transmissionTypeGroupBox";
        transmissionTypeGroupBox.Size = new Size(183, 90);
        transmissionTypeGroupBox.TabIndex = 10;
        transmissionTypeGroupBox.TabStop = false;
        transmissionTypeGroupBox.Text = "Трансміссія";
        // 
        // transmissionCheckedListBox
        // 
        transmissionCheckedListBox.FormattingEnabled = true;
        transmissionCheckedListBox.Items.AddRange(new object[] { "Ручна", "Автоматична" });
        transmissionCheckedListBox.Location = new Point(15, 26);
        transmissionCheckedListBox.Name = "transmissionCheckedListBox";
        transmissionCheckedListBox.Size = new Size(150, 48);
        transmissionCheckedListBox.TabIndex = 0;
        // 
        // CarsFilteringForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(612, 359);
        Controls.Add(transmissionTypeGroupBox);
        Controls.Add(engineTypeGroupBox);
        Controls.Add(bodyTypeGroupBox);
        Controls.Add(priceGroupBox);
        Controls.Add(colorGroupBox);
        Controls.Add(okButton);
        Name = "CarsFilteringForm";
        Text = "Фільтрація автомобілей";
        colorGroupBox.ResumeLayout(false);
        priceGroupBox.ResumeLayout(false);
        priceGroupBox.PerformLayout();
        bodyTypeGroupBox.ResumeLayout(false);
        engineTypeGroupBox.ResumeLayout(false);
        transmissionTypeGroupBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private CheckedListBox colorCheckedListBox;
    private Label priceFromLabel;
    private Label priceToLabel;
    private TextBox priceFromTextBox;
    private TextBox priceToTextBox;
    private Button okButton;
    private GroupBox colorGroupBox;
    private GroupBox priceGroupBox;
    private GroupBox bodyTypeGroupBox;
    private GroupBox engineTypeGroupBox;
    private GroupBox transmissionTypeGroupBox;
    private CheckedListBox bodyTypeCheckedListBox;
    private CheckedListBox engineCheckedListBox;
    private CheckedListBox transmissionCheckedListBox;
}