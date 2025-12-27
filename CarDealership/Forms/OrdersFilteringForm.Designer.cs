namespace CarDealership.Forms
{
    partial class OrdersFilteringForm
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
            priceGroupBox = new GroupBox();
            priceFromLabel = new Label();
            priceToLabel = new Label();
            priceFromTextBox = new TextBox();
            priceToTextBox = new TextBox();
            statusGroupBox = new GroupBox();
            statusCheckedListBox = new CheckedListBox();
            okButton = new Button();
            priceGroupBox.SuspendLayout();
            statusGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // priceGroupBox
            // 
            priceGroupBox.Controls.Add(priceFromLabel);
            priceGroupBox.Controls.Add(priceToLabel);
            priceGroupBox.Controls.Add(priceFromTextBox);
            priceGroupBox.Controls.Add(priceToTextBox);
            priceGroupBox.Location = new Point(223, 12);
            priceGroupBox.Name = "priceGroupBox";
            priceGroupBox.Size = new Size(209, 110);
            priceGroupBox.TabIndex = 8;
            priceGroupBox.TabStop = false;
            priceGroupBox.Text = "Ціна";
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
            // statusGroupBox
            // 
            statusGroupBox.Controls.Add(statusCheckedListBox);
            statusGroupBox.Location = new Point(10, 12);
            statusGroupBox.Name = "statusGroupBox";
            statusGroupBox.Size = new Size(207, 110);
            statusGroupBox.TabIndex = 9;
            statusGroupBox.TabStop = false;
            statusGroupBox.Text = "Статус";
            // 
            // statusCheckedListBox
            // 
            statusCheckedListBox.FormattingEnabled = true;
            statusCheckedListBox.Items.AddRange(new object[] { "Очікує підтверження", "Підтверджений", "Відхилений" });
            statusCheckedListBox.Location = new Point(15, 25);
            statusCheckedListBox.Name = "statusCheckedListBox";
            statusCheckedListBox.Size = new Size(177, 70);
            statusCheckedListBox.TabIndex = 10;
            // 
            // okButton
            // 
            okButton.Location = new Point(175, 131);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 10;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // OrdersFilteringForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 169);
            Controls.Add(okButton);
            Controls.Add(statusGroupBox);
            Controls.Add(priceGroupBox);
            Name = "OrdersFilteringForm";
            Text = "Фільтрація замовлень";
            priceGroupBox.ResumeLayout(false);
            priceGroupBox.PerformLayout();
            statusGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox priceGroupBox;
        private Label priceFromLabel;
        private Label priceToLabel;
        private TextBox priceFromTextBox;
        private TextBox priceToTextBox;
        private GroupBox statusGroupBox;
        private CheckedListBox statusCheckedListBox;
        private Button okButton;
    }
}