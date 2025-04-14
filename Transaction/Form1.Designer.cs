namespace AppTransaction;

partial class Form1
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
        buttonFail = new Button();
        buttonEF = new Button();
        buttonScope = new Button();
        buttonRepository = new Button();
        buttonReport = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // buttonFail
        // 
        buttonFail.Location = new Point(30, 12);
        buttonFail.Name = "buttonFail";
        buttonFail.Size = new Size(260, 23);
        buttonFail.TabIndex = 0;
        buttonFail.Text = "Transaction FAIL";
        buttonFail.UseVisualStyleBackColor = true;
        buttonFail.Click += buttonFail_Click;
        // 
        // buttonEF
        // 
        buttonEF.Location = new Point(30, 41);
        buttonEF.Name = "buttonEF";
        buttonEF.Size = new Size(260, 23);
        buttonEF.TabIndex = 1;
        buttonEF.Text = "Transaction EF";
        buttonEF.UseVisualStyleBackColor = true;
        buttonEF.Click += buttonEF_Click;
        // 
        // buttonScope
        // 
        buttonScope.Location = new Point(30, 70);
        buttonScope.Name = "buttonScope";
        buttonScope.Size = new Size(260, 23);
        buttonScope.TabIndex = 2;
        buttonScope.Text = "Transaction Scope";
        buttonScope.UseVisualStyleBackColor = true;
        buttonScope.Click += buttonScope_Click;
        // 
        // buttonRepository
        // 
        buttonRepository.Location = new Point(30, 99);
        buttonRepository.Name = "buttonRepository";
        buttonRepository.Size = new Size(260, 23);
        buttonRepository.TabIndex = 3;
        buttonRepository.Text = "Transaction Repository";
        buttonRepository.UseVisualStyleBackColor = true;
        buttonRepository.Click += buttonRepository_Click;
        // 
        // buttonReport
        // 
        buttonReport.Location = new Point(659, 12);
        buttonReport.Name = "buttonReport";
        buttonReport.Size = new Size(129, 37);
        buttonReport.TabIndex = 4;
        buttonReport.Text = "Report";
        buttonReport.UseVisualStyleBackColor = true;
        buttonReport.Click += buttonReport_Click;
        // 
        // button1
        // 
        button1.Location = new Point(372, 99);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 5;
        button1.Text = "Test Sqlite";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(buttonReport);
        Controls.Add(buttonRepository);
        Controls.Add(buttonScope);
        Controls.Add(buttonEF);
        Controls.Add(buttonFail);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button buttonFail;
    private Button buttonEF;
    private Button buttonScope;
    private Button buttonRepository;
    private Button buttonReport;
    private Button button1;
}