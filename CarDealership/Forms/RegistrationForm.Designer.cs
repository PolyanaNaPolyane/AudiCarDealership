using System.ComponentModel;

namespace CarDealership.Forms;

partial class RegistrationForm
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
        contactDetailsGroupBox = new GroupBox();
        phoneNumberTextBox = new TextBox();
        addressTextBox = new TextBox();
        cityTextBox = new TextBox();
        countryTextBox = new TextBox();
        phoneNumberLabel = new Label();
        addressLabel = new Label();
        cityLabel = new Label();
        countryLabel = new Label();
        generalGroupBox = new GroupBox();
        passwordTextBox = new TextBox();
        emailTextBox = new TextBox();
        lastNameTextBox = new TextBox();
        firstNameTextBox = new TextBox();
        passwordLabel = new Label();
        emailLabel = new Label();
        lastNameLabel = new Label();
        firstNameLabel = new Label();
        registerButton = new Button();
        loginButton = new Button();
        contactDetailsGroupBox.SuspendLayout();
        generalGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // contactDetailsGroupBox
        // 
        contactDetailsGroupBox.Controls.Add(phoneNumberTextBox);
        contactDetailsGroupBox.Controls.Add(addressTextBox);
        contactDetailsGroupBox.Controls.Add(cityTextBox);
        contactDetailsGroupBox.Controls.Add(countryTextBox);
        contactDetailsGroupBox.Controls.Add(phoneNumberLabel);
        contactDetailsGroupBox.Controls.Add(addressLabel);
        contactDetailsGroupBox.Controls.Add(cityLabel);
        contactDetailsGroupBox.Controls.Add(countryLabel);
        contactDetailsGroupBox.Location = new Point(15, 214);
        contactDetailsGroupBox.Name = "contactDetailsGroupBox";
        contactDetailsGroupBox.Size = new Size(250, 154);
        contactDetailsGroupBox.TabIndex = 0;
        contactDetailsGroupBox.TabStop = false;
        contactDetailsGroupBox.Text = "Контактні дані";
        // 
        // phoneNumberTextBox
        // 
        phoneNumberTextBox.Location = new Point(89, 113);
        phoneNumberTextBox.Name = "phoneNumberTextBox";
        phoneNumberTextBox.Size = new Size(125, 27);
        phoneNumberTextBox.TabIndex = 8;
        // 
        // addressTextBox
        // 
        addressTextBox.Location = new Point(74, 83);
        addressTextBox.Name = "addressTextBox";
        addressTextBox.Size = new Size(125, 27);
        addressTextBox.TabIndex = 7;
        // 
        // cityTextBox
        // 
        cityTextBox.Location = new Point(63, 53);
        cityTextBox.Name = "cityTextBox";
        cityTextBox.Size = new Size(125, 27);
        cityTextBox.TabIndex = 6;
        // 
        // countryTextBox
        // 
        countryTextBox.Location = new Point(71, 16);
        countryTextBox.Name = "countryTextBox";
        countryTextBox.Size = new Size(125, 27);
        countryTextBox.TabIndex = 5;
        // 
        // phoneNumberLabel
        // 
        phoneNumberLabel.AutoSize = true;
        phoneNumberLabel.Location = new Point(11, 113);
        phoneNumberLabel.Name = "phoneNumberLabel";
        phoneNumberLabel.Size = new Size(60, 20);
        phoneNumberLabel.TabIndex = 4;
        phoneNumberLabel.Text = "Номер:";
        // 
        // addressLabel
        // 
        addressLabel.AutoSize = true;
        addressLabel.Location = new Point(6, 83);
        addressLabel.Name = "addressLabel";
        addressLabel.Size = new Size(62, 20);
        addressLabel.TabIndex = 3;
        addressLabel.Text = "Адреса:";
        // 
        // cityLabel
        // 
        cityLabel.AutoSize = true;
        cityLabel.Location = new Point(6, 56);
        cityLabel.Name = "cityLabel";
        cityLabel.Size = new Size(51, 20);
        cityLabel.TabIndex = 2;
        cityLabel.Text = "Місто:";
        // 
        // countryLabel
        // 
        countryLabel.AutoSize = true;
        countryLabel.Location = new Point(6, 23);
        countryLabel.Name = "countryLabel";
        countryLabel.Size = new Size(59, 20);
        countryLabel.TabIndex = 1;
        countryLabel.Text = "Країна:";
        // 
        // generalGroupBox
        // 
        generalGroupBox.Controls.Add(passwordTextBox);
        generalGroupBox.Controls.Add(emailTextBox);
        generalGroupBox.Controls.Add(lastNameTextBox);
        generalGroupBox.Controls.Add(firstNameTextBox);
        generalGroupBox.Controls.Add(passwordLabel);
        generalGroupBox.Controls.Add(emailLabel);
        generalGroupBox.Controls.Add(lastNameLabel);
        generalGroupBox.Controls.Add(firstNameLabel);
        generalGroupBox.Location = new Point(12, 31);
        generalGroupBox.Name = "generalGroupBox";
        generalGroupBox.Size = new Size(253, 177);
        generalGroupBox.TabIndex = 1;
        generalGroupBox.TabStop = false;
        generalGroupBox.Text = "Загальні відомості";
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new Point(66, 106);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(125, 27);
        passwordTextBox.TabIndex = 7;
        // 
        // emailTextBox
        // 
        emailTextBox.Location = new Point(63, 76);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(125, 27);
        emailTextBox.TabIndex = 6;
        // 
        // lastNameTextBox
        // 
        lastNameTextBox.Location = new Point(89, 47);
        lastNameTextBox.Name = "lastNameTextBox";
        lastNameTextBox.Size = new Size(125, 27);
        lastNameTextBox.TabIndex = 5;
        // 
        // firstNameTextBox
        // 
        firstNameTextBox.Location = new Point(47, 20);
        firstNameTextBox.Name = "firstNameTextBox";
        firstNameTextBox.Size = new Size(125, 27);
        firstNameTextBox.TabIndex = 4;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(0, 106);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(65, 20);
        passwordLabel.TabIndex = 3;
        passwordLabel.Text = "Пароль:";
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Location = new Point(3, 79);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(58, 20);
        emailLabel.TabIndex = 2;
        emailLabel.Text = "Пошта:";
        // 
        // lastNameLabel
        // 
        lastNameLabel.AutoSize = true;
        lastNameLabel.Location = new Point(3, 50);
        lastNameLabel.Name = "lastNameLabel";
        lastNameLabel.Size = new Size(80, 20);
        lastNameLabel.TabIndex = 1;
        lastNameLabel.Text = "Прізвище:";
        // 
        // firstNameLabel
        // 
        firstNameLabel.AutoSize = true;
        firstNameLabel.Location = new Point(3, 23);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new Size(38, 20);
        firstNameLabel.TabIndex = 0;
        firstNameLabel.Text = "Ім'я:";
        // 
        // registerButton
        // 
        registerButton.Location = new Point(71, 385);
        registerButton.Name = "registerButton";
        registerButton.Size = new Size(140, 38);
        registerButton.TabIndex = 2;
        registerButton.Text = "Зареєструватися";
        registerButton.UseVisualStyleBackColor = true;
        registerButton.Click += registerButton_Click;
        // 
        // loginButton
        // 
        loginButton.Location = new Point(71, 429);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(140, 35);
        loginButton.TabIndex = 3;
        loginButton.Text = "Увійти";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // RegistrationForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(279, 476);
        Controls.Add(loginButton);
        Controls.Add(registerButton);
        Controls.Add(generalGroupBox);
        Controls.Add(contactDetailsGroupBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "RegistrationForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Регістрація";
        contactDetailsGroupBox.ResumeLayout(false);
        contactDetailsGroupBox.PerformLayout();
        generalGroupBox.ResumeLayout(false);
        generalGroupBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox contactDetailsGroupBox;
    private GroupBox generalGroupBox;
    private Label phoneNumberLabel;
    private Label addressLabel;
    private Label cityLabel;
    private Label countryLabel;
    private Label passwordLabel;
    private Label emailLabel;
    private Label lastNameLabel;
    private Label firstNameLabel;
    private TextBox phoneNumberTextBox;
    private TextBox addressTextBox;
    private TextBox cityTextBox;
    private TextBox countryTextBox;
    private TextBox passwordTextBox;
    private TextBox emailTextBox;
    private TextBox lastNameTextBox;
    private TextBox firstNameTextBox;
    private Button registerButton;
    private Button loginButton;
}