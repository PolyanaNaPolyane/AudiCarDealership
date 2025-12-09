using System.ComponentModel;

namespace CarDealership.Forms;

partial class CarDetailsForm
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
        exportButton = new Button();
        generalGroupBox = new GroupBox();
        modelValueLabel = new Label();
        priceValueLabel = new Label();
        colorValueLabel = new Label();
        VINValueLabel = new Label();
        yearValueLabel = new Label();
        brandValueLabel = new Label();
        classValueLabel = new Label();
        colorLabel = new Label();
        priceLabel = new Label();
        classLabel = new Label();
        yearLabel = new Label();
        VINlabel = new Label();
        modelLabel = new Label();
        brandLabel = new Label();
        technicalCharacteristicsGroupBox = new GroupBox();
        bodyTypeVauleLabel = new Label();
        driveTrainTypeValueLabel = new Label();
        powerValueLabel = new Label();
        topSpeedValueLabel = new Label();
        transmissionTypeValueLabel = new Label();
        engineTypeValueLabel = new Label();
        fuelConsumptionValueLabel = new Label();
        EngineTypeLabel = new Label();
        divetrainTypeLabel = new Label();
        bodyTypeLabel = new Label();
        topSpeedLabel = new Label();
        transmissionTypeLabel = new Label();
        powerLabel = new Label();
        fuelConsumptionLabel = new Label();
        generalGroupBox.SuspendLayout();
        technicalCharacteristicsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // exportButton
        // 
        exportButton.Location = new Point(304, 269);
        exportButton.Name = "exportButton";
        exportButton.Size = new Size(126, 29);
        exportButton.TabIndex = 0;
        exportButton.Text = "Експортувати";
        exportButton.UseVisualStyleBackColor = true;
        exportButton.Click += exportButton_Click;
        // 
        // generalGroupBox
        // 
        generalGroupBox.Controls.Add(modelValueLabel);
        generalGroupBox.Controls.Add(priceValueLabel);
        generalGroupBox.Controls.Add(colorValueLabel);
        generalGroupBox.Controls.Add(VINValueLabel);
        generalGroupBox.Controls.Add(yearValueLabel);
        generalGroupBox.Controls.Add(brandValueLabel);
        generalGroupBox.Controls.Add(classValueLabel);
        generalGroupBox.Controls.Add(colorLabel);
        generalGroupBox.Controls.Add(priceLabel);
        generalGroupBox.Controls.Add(classLabel);
        generalGroupBox.Controls.Add(yearLabel);
        generalGroupBox.Controls.Add(VINlabel);
        generalGroupBox.Controls.Add(modelLabel);
        generalGroupBox.Controls.Add(brandLabel);
        generalGroupBox.Location = new Point(12, 12);
        generalGroupBox.Name = "generalGroupBox";
        generalGroupBox.Size = new Size(340, 236);
        generalGroupBox.TabIndex = 1;
        generalGroupBox.TabStop = false;
        generalGroupBox.Text = "Загальні відомості";
        // 
        // modelValueLabel
        // 
        modelValueLabel.AutoSize = true;
        modelValueLabel.Location = new Point(78, 53);
        modelValueLabel.Name = "modelValueLabel";
        modelValueLabel.Size = new Size(50, 20);
        modelValueLabel.TabIndex = 16;
        modelValueLabel.Text = "label6";
        // 
        // priceValueLabel
        // 
        priceValueLabel.AutoSize = true;
        priceValueLabel.Location = new Point(56, 147);
        priceValueLabel.Name = "priceValueLabel";
        priceValueLabel.Size = new Size(50, 20);
        priceValueLabel.TabIndex = 15;
        priceValueLabel.Text = "label5";
        // 
        // colorValueLabel
        // 
        colorValueLabel.AutoSize = true;
        colorValueLabel.Location = new Point(63, 178);
        colorValueLabel.Name = "colorValueLabel";
        colorValueLabel.Size = new Size(50, 20);
        colorValueLabel.TabIndex = 14;
        colorValueLabel.Text = "label4";
        // 
        // VINValueLabel
        // 
        VINValueLabel.AutoSize = true;
        VINValueLabel.Location = new Point(45, 114);
        VINValueLabel.Name = "VINValueLabel";
        VINValueLabel.Size = new Size(50, 20);
        VINValueLabel.TabIndex = 13;
        VINValueLabel.Text = "label3";
        // 
        // yearValueLabel
        // 
        yearValueLabel.AutoSize = true;
        yearValueLabel.Location = new Point(101, 83);
        yearValueLabel.Name = "yearValueLabel";
        yearValueLabel.Size = new Size(50, 20);
        yearValueLabel.TabIndex = 12;
        yearValueLabel.Text = "label2";
        // 
        // brandValueLabel
        // 
        brandValueLabel.AutoSize = true;
        brandValueLabel.Location = new Point(67, 23);
        brandValueLabel.Name = "brandValueLabel";
        brandValueLabel.Size = new Size(50, 20);
        brandValueLabel.TabIndex = 11;
        brandValueLabel.Text = "label1";
        // 
        // classValueLabel
        // 
        classValueLabel.AutoSize = true;
        classValueLabel.Location = new Point(56, 204);
        classValueLabel.Name = "classValueLabel";
        classValueLabel.Size = new Size(50, 20);
        classValueLabel.TabIndex = 13;
        classValueLabel.Text = "label8";
        // 
        // colorLabel
        // 
        colorLabel.AutoSize = true;
        colorLabel.Location = new Point(6, 178);
        colorLabel.Name = "colorLabel";
        colorLabel.Size = new Size(51, 20);
        colorLabel.TabIndex = 7;
        colorLabel.Text = "Колір:";
        // 
        // priceLabel
        // 
        priceLabel.AutoSize = true;
        priceLabel.Location = new Point(6, 147);
        priceLabel.Name = "priceLabel";
        priceLabel.Size = new Size(44, 20);
        priceLabel.TabIndex = 6;
        priceLabel.Text = "Ціна:";
        // 
        // classLabel
        // 
        classLabel.AutoSize = true;
        classLabel.Location = new Point(6, 204);
        classLabel.Name = "classLabel";
        classLabel.Size = new Size(44, 20);
        classLabel.TabIndex = 8;
        classLabel.Text = "Клас:";
        // 
        // yearLabel
        // 
        yearLabel.AutoSize = true;
        yearLabel.Location = new Point(6, 83);
        yearLabel.Name = "yearLabel";
        yearLabel.Size = new Size(89, 20);
        yearLabel.TabIndex = 5;
        yearLabel.Text = "Рік випуску:";
        // 
        // VINlabel
        // 
        VINlabel.AutoSize = true;
        VINlabel.Location = new Point(6, 114);
        VINlabel.Name = "VINlabel";
        VINlabel.Size = new Size(36, 20);
        VINlabel.TabIndex = 4;
        VINlabel.Text = "VIN:";
        // 
        // modelLabel
        // 
        modelLabel.AutoSize = true;
        modelLabel.Location = new Point(6, 53);
        modelLabel.Name = "modelLabel";
        modelLabel.Size = new Size(66, 20);
        modelLabel.TabIndex = 3;
        modelLabel.Text = "Модель:";
        // 
        // brandLabel
        // 
        brandLabel.AutoSize = true;
        brandLabel.Location = new Point(6, 23);
        brandLabel.Name = "brandLabel";
        brandLabel.Size = new Size(55, 20);
        brandLabel.TabIndex = 3;
        brandLabel.Text = "Бренд:";
        // 
        // technicalCharacteristicsGroupBox
        // 
        technicalCharacteristicsGroupBox.Controls.Add(bodyTypeVauleLabel);
        technicalCharacteristicsGroupBox.Controls.Add(driveTrainTypeValueLabel);
        technicalCharacteristicsGroupBox.Controls.Add(powerValueLabel);
        technicalCharacteristicsGroupBox.Controls.Add(topSpeedValueLabel);
        technicalCharacteristicsGroupBox.Controls.Add(transmissionTypeValueLabel);
        technicalCharacteristicsGroupBox.Controls.Add(engineTypeValueLabel);
        technicalCharacteristicsGroupBox.Controls.Add(fuelConsumptionValueLabel);
        technicalCharacteristicsGroupBox.Controls.Add(EngineTypeLabel);
        technicalCharacteristicsGroupBox.Controls.Add(divetrainTypeLabel);
        technicalCharacteristicsGroupBox.Controls.Add(bodyTypeLabel);
        technicalCharacteristicsGroupBox.Controls.Add(topSpeedLabel);
        technicalCharacteristicsGroupBox.Controls.Add(transmissionTypeLabel);
        technicalCharacteristicsGroupBox.Controls.Add(powerLabel);
        technicalCharacteristicsGroupBox.Controls.Add(fuelConsumptionLabel);
        technicalCharacteristicsGroupBox.Location = new Point(358, 12);
        technicalCharacteristicsGroupBox.Name = "technicalCharacteristicsGroupBox";
        technicalCharacteristicsGroupBox.Size = new Size(360, 236);
        technicalCharacteristicsGroupBox.TabIndex = 2;
        technicalCharacteristicsGroupBox.TabStop = false;
        technicalCharacteristicsGroupBox.Text = "Технічні характеристики";
        // 
        // bodyTypeVauleLabel
        // 
        bodyTypeVauleLabel.AutoSize = true;
        bodyTypeVauleLabel.Location = new Point(105, 23);
        bodyTypeVauleLabel.Name = "bodyTypeVauleLabel";
        bodyTypeVauleLabel.Size = new Size(58, 20);
        bodyTypeVauleLabel.TabIndex = 19;
        bodyTypeVauleLabel.Text = "label14";
        // 
        // driveTrainTypeValueLabel
        // 
        driveTrainTypeValueLabel.AutoSize = true;
        driveTrainTypeValueLabel.Location = new Point(118, 174);
        driveTrainTypeValueLabel.Name = "driveTrainTypeValueLabel";
        driveTrainTypeValueLabel.Size = new Size(58, 20);
        driveTrainTypeValueLabel.TabIndex = 18;
        driveTrainTypeValueLabel.Text = "label13";
        // 
        // powerValueLabel
        // 
        powerValueLabel.AutoSize = true;
        powerValueLabel.Location = new Point(105, 145);
        powerValueLabel.Name = "powerValueLabel";
        powerValueLabel.Size = new Size(58, 20);
        powerValueLabel.TabIndex = 17;
        powerValueLabel.Text = "label12";
        // 
        // topSpeedValueLabel
        // 
        topSpeedValueLabel.AutoSize = true;
        topSpeedValueLabel.Location = new Point(198, 54);
        topSpeedValueLabel.Name = "topSpeedValueLabel";
        topSpeedValueLabel.Size = new Size(58, 20);
        topSpeedValueLabel.TabIndex = 16;
        topSpeedValueLabel.Text = "label11";
        // 
        // transmissionTypeValueLabel
        // 
        transmissionTypeValueLabel.AutoSize = true;
        transmissionTypeValueLabel.Location = new Point(135, 83);
        transmissionTypeValueLabel.Name = "transmissionTypeValueLabel";
        transmissionTypeValueLabel.Size = new Size(58, 20);
        transmissionTypeValueLabel.TabIndex = 15;
        transmissionTypeValueLabel.Text = "label10";
        // 
        // engineTypeValueLabel
        // 
        engineTypeValueLabel.AutoSize = true;
        engineTypeValueLabel.Location = new Point(113, 204);
        engineTypeValueLabel.Name = "engineTypeValueLabel";
        engineTypeValueLabel.Size = new Size(50, 20);
        engineTypeValueLabel.TabIndex = 14;
        engineTypeValueLabel.Text = "label9";
        // 
        // fuelConsumptionValueLabel
        // 
        fuelConsumptionValueLabel.AutoSize = true;
        fuelConsumptionValueLabel.Location = new Point(138, 115);
        fuelConsumptionValueLabel.Name = "fuelConsumptionValueLabel";
        fuelConsumptionValueLabel.Size = new Size(50, 20);
        fuelConsumptionValueLabel.TabIndex = 12;
        fuelConsumptionValueLabel.Text = "label7";
        // 
        // EngineTypeLabel
        // 
        EngineTypeLabel.AutoSize = true;
        EngineTypeLabel.Location = new Point(11, 204);
        EngineTypeLabel.Name = "EngineTypeLabel";
        EngineTypeLabel.Size = new Size(97, 20);
        EngineTypeLabel.TabIndex = 9;
        EngineTypeLabel.Text = "Тип двигуна:";
        // 
        // divetrainTypeLabel
        // 
        divetrainTypeLabel.AutoSize = true;
        divetrainTypeLabel.Location = new Point(11, 174);
        divetrainTypeLabel.Name = "divetrainTypeLabel";
        divetrainTypeLabel.Size = new Size(101, 20);
        divetrainTypeLabel.TabIndex = 10;
        divetrainTypeLabel.Text = "Тип приводу:";
        // 
        // bodyTypeLabel
        // 
        bodyTypeLabel.AutoSize = true;
        bodyTypeLabel.Location = new Point(11, 23);
        bodyTypeLabel.Name = "bodyTypeLabel";
        bodyTypeLabel.Size = new Size(88, 20);
        bodyTypeLabel.TabIndex = 3;
        bodyTypeLabel.Text = "Тип кузова:";
        // 
        // topSpeedLabel
        // 
        topSpeedLabel.AutoSize = true;
        topSpeedLabel.Location = new Point(11, 54);
        topSpeedLabel.Name = "topSpeedLabel";
        topSpeedLabel.Size = new Size(181, 20);
        topSpeedLabel.TabIndex = 5;
        topSpeedLabel.Text = "Максимальна швидкість:";
        // 
        // transmissionTypeLabel
        // 
        transmissionTypeLabel.AutoSize = true;
        transmissionTypeLabel.Location = new Point(11, 83);
        transmissionTypeLabel.Name = "transmissionTypeLabel";
        transmissionTypeLabel.Size = new Size(118, 20);
        transmissionTypeLabel.TabIndex = 4;
        transmissionTypeLabel.Text = "Тип трансміссії:";
        // 
        // powerLabel
        // 
        powerLabel.AutoSize = true;
        powerLabel.Location = new Point(11, 145);
        powerLabel.Name = "powerLabel";
        powerLabel.Size = new Size(90, 20);
        powerLabel.TabIndex = 6;
        powerLabel.Text = "Потужність:";
        // 
        // fuelConsumptionLabel
        // 
        fuelConsumptionLabel.AutoSize = true;
        fuelConsumptionLabel.Location = new Point(11, 115);
        fuelConsumptionLabel.Name = "fuelConsumptionLabel";
        fuelConsumptionLabel.Size = new Size(121, 20);
        fuelConsumptionLabel.TabIndex = 7;
        fuelConsumptionLabel.Text = "Витрата палива:";
        // 
        // CarDetailsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(730, 322);
        Controls.Add(technicalCharacteristicsGroupBox);
        Controls.Add(generalGroupBox);
        Controls.Add(exportButton);
        Name = "CarDetailsForm";
        Text = "CarDetailsForm";
        generalGroupBox.ResumeLayout(false);
        generalGroupBox.PerformLayout();
        technicalCharacteristicsGroupBox.ResumeLayout(false);
        technicalCharacteristicsGroupBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button exportButton;
    private GroupBox generalGroupBox;
    private GroupBox technicalCharacteristicsGroupBox;
    private Label colorLabel;
    private Label priceLabel;
    private Label yearLabel;
    private Label VINlabel;
    private Label modelLabel;
    private Label brandLabel;
    private Label bodyTypeLabel;
    private Label classLabel;
    private Label EngineTypeLabel;
    private Label divetrainTypeLabel;
    private Label topSpeedLabel;
    private Label transmissionTypeLabel;
    private Label powerLabel;
    private Label fuelConsumptionLabel;
    private Label modelValueLabel;
    private Label priceValueLabel;
    private Label colorValueLabel;
    private Label VINValueLabel;
    private Label yearValueLabel;
    private Label brandValueLabel;
    private Label bodyTypeVauleLabel;
    private Label driveTrainTypeValueLabel;
    private Label powerValueLabel;
    private Label topSpeedValueLabel;
    private Label transmissionTypeValueLabel;
    private Label engineTypeValueLabel;
    private Label classValueLabel;
    private Label fuelConsumptionValueLabel;
}