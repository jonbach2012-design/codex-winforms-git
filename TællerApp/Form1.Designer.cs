namespace TællerApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Label lblTæller;
    private Button btnPlus;
    private Button btnMinus;
    private Button btnNulstil;
    private CheckBox chkAutoPlus;
    private ListBox lstLog;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTæller = new Label();
        btnPlus = new Button();
        btnMinus = new Button();
        btnNulstil = new Button();
        chkAutoPlus = new CheckBox();
        lstLog = new ListBox();
        SuspendLayout();
        // 
        // lblTæller
        // 
        lblTæller.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
        lblTæller.Location = new Point(250, 30);
        lblTæller.Name = "lblTæller";
        lblTæller.Size = new Size(300, 70);
        lblTæller.TabIndex = 0;
        lblTæller.Text = "0";
        lblTæller.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnPlus
        // 
        btnPlus.Location = new Point(170, 120);
        btnPlus.Name = "btnPlus";
        btnPlus.Size = new Size(130, 45);
        btnPlus.TabIndex = 1;
        btnPlus.Text = "+1";
        btnPlus.UseVisualStyleBackColor = true;
        btnPlus.Click += btnPlus_Click;
        // 
        // btnMinus
        // 
        btnMinus.Location = new Point(335, 120);
        btnMinus.Name = "btnMinus";
        btnMinus.Size = new Size(130, 45);
        btnMinus.TabIndex = 2;
        btnMinus.Text = "-1";
        btnMinus.UseVisualStyleBackColor = true;
        btnMinus.Click += btnMinus_Click;
        // 
        // btnNulstil
        // 
        btnNulstil.Location = new Point(500, 120);
        btnNulstil.Name = "btnNulstil";
        btnNulstil.Size = new Size(130, 45);
        btnNulstil.TabIndex = 3;
        btnNulstil.Text = "Nulstil";
        btnNulstil.UseVisualStyleBackColor = true;
        btnNulstil.Click += btnNulstil_Click;
        // 
        // chkAutoPlus
        // 
        chkAutoPlus.AutoSize = true;
        chkAutoPlus.Location = new Point(335, 170);
        chkAutoPlus.Name = "chkAutoPlus";
        chkAutoPlus.Size = new Size(92, 29);
        chkAutoPlus.TabIndex = 4;
        chkAutoPlus.Text = "Auto +1";
        chkAutoPlus.UseVisualStyleBackColor = true;
        chkAutoPlus.CheckedChanged += chkAutoPlus_CheckedChanged;
        // 
        // lstLog
        // 
        lstLog.FormattingEnabled = true;
        lstLog.ItemHeight = 25;
        lstLog.Location = new Point(170, 210);
        lstLog.Name = "lstLog";
        lstLog.Size = new Size(460, 154);
        lstLog.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lstLog);
        Controls.Add(chkAutoPlus);
        Controls.Add(btnNulstil);
        Controls.Add(btnMinus);
        Controls.Add(btnPlus);
        Controls.Add(lblTæller);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "TællerApp";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}