using System.ComponentModel;

namespace CarDealership.Forms;

partial class LoginForm
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
        loginButton = new Button();
        emailTextBox = new TextBox();
        passwordTextBox = new TextBox();
        registerButton = new Button();
        emailLabel = new Label();
        passwordLabel = new Label();
        SuspendLayout();
        // 
        // loginButton
        // 
        loginButton.Location = new Point(71, 109);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(146, 37);
        loginButton.TabIndex = 0;
        loginButton.Text = "Увійти";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // emailTextBox
        // 
        emailTextBox.Location = new Point(83, 12);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(192, 27);
        emailTextBox.TabIndex = 1;
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new Point(83, 66);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(192, 27);
        passwordTextBox.TabIndex = 2;
        // 
        // registerButton
        // 
        registerButton.Location = new Point(71, 152);
        registerButton.Name = "registerButton";
        registerButton.Size = new Size(146, 36);
        registerButton.TabIndex = 3;
        registerButton.Text = "Зареєструватися";
        registerButton.UseVisualStyleBackColor = true;
        registerButton.Click += registerButton_Click;
        // 
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.Location = new Point(12, 15);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(58, 20);
        emailLabel.TabIndex = 4;
        emailLabel.Text = "Пошта:";
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(12, 69);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(65, 20);
        passwordLabel.TabIndex = 5;
        passwordLabel.Text = "Пароль:";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(288, 201);
        Controls.Add(passwordLabel);
        Controls.Add(emailLabel);
        Controls.Add(registerButton);
        Controls.Add(passwordTextBox);
        Controls.Add(emailTextBox);
        Controls.Add(loginButton);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Логін";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox emailTextBox;
    private System.Windows.Forms.TextBox passwordTextBox;

    private System.Windows.Forms.Button loginButton;

    #endregion

    private Button registerButton;
    private Label emailLabel;
    private Label passwordLabel;
}