using System.ComponentModel;

namespace CarDealership.Forms;

partial class MainForm
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
        carsDataGridView = new System.Windows.Forms.DataGridView();
        accountsDataGridView = new System.Windows.Forms.DataGridView();
        ordersDataGridView = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)carsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)accountsDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
        SuspendLayout();
        // 
        // carsDataGridView
        // 
        carsDataGridView.ColumnHeadersHeight = 29;
        carsDataGridView.Location = new System.Drawing.Point(12, 12);
        carsDataGridView.Name = "carsDataGridView";
        carsDataGridView.RowHeadersWidth = 51;
        carsDataGridView.Size = new System.Drawing.Size(776, 150);
        carsDataGridView.TabIndex = 0;
        // 
        // accountsDataGridView
        // 
        accountsDataGridView.ColumnHeadersHeight = 29;
        accountsDataGridView.Location = new System.Drawing.Point(12, 181);
        accountsDataGridView.Name = "accountsDataGridView";
        accountsDataGridView.RowHeadersWidth = 51;
        accountsDataGridView.Size = new System.Drawing.Size(776, 150);
        accountsDataGridView.TabIndex = 1;
        // 
        // ordersDataGridView
        // 
        ordersDataGridView.ColumnHeadersHeight = 29;
        ordersDataGridView.Location = new System.Drawing.Point(12, 351);
        ordersDataGridView.Name = "ordersDataGridView";
        ordersDataGridView.RowHeadersWidth = 51;
        ordersDataGridView.Size = new System.Drawing.Size(776, 150);
        ordersDataGridView.TabIndex = 2;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 523);
        Controls.Add(ordersDataGridView);
        Controls.Add(accountsDataGridView);
        Controls.Add(carsDataGridView);
        Text = "MainForm";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)carsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)accountsDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView carsDataGridView;
    private System.Windows.Forms.DataGridView accountsDataGridView;
    private System.Windows.Forms.DataGridView ordersDataGridView;

    #endregion
}