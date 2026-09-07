namespace ITEC140_PRACTICE_04;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblWorkerPrompt = new Label();
        txtWorkerName = new TextBox();
        grpShift = new GroupBox();
        radNight = new RadioButton();
        radEvening = new RadioButton();
        radDay = new RadioButton();
        chkPpeComplete = new CheckBox();
        btnCreateSummary = new Button();
        lblsummary = new Label();
        grpShift.SuspendLayout();
        SuspendLayout();
        // 
        // lblWorkerPrompt
        // 
        lblWorkerPrompt.AutoSize = true;
        lblWorkerPrompt.Location = new Point(12, 33);
        lblWorkerPrompt.Name = "lblWorkerPrompt";
        lblWorkerPrompt.Size = new Size(83, 15);
        lblWorkerPrompt.TabIndex = 0;
        lblWorkerPrompt.Text = "Worker Name:";
        // 
        // txtWorkerName
        // 
        txtWorkerName.Location = new Point(101, 25);
        txtWorkerName.Name = "txtWorkerName";
        txtWorkerName.Size = new Size(209, 23);
        txtWorkerName.TabIndex = 1;
        txtWorkerName.TextChanged += textBox1_TextChanged;
        // 
        // grpShift
        // 
        grpShift.Controls.Add(radNight);
        grpShift.Controls.Add(radEvening);
        grpShift.Controls.Add(radDay);
        grpShift.Location = new Point(40, 68);
        grpShift.Name = "grpShift";
        grpShift.Size = new Size(138, 111);
        grpShift.TabIndex = 2;
        grpShift.TabStop = false;
        grpShift.Text = "Shift";
        // 
        // radNight
        // 
        radNight.AutoSize = true;
        radNight.Location = new Point(28, 75);
        radNight.Name = "radNight";
        radNight.Size = new Size(55, 19);
        radNight.TabIndex = 5;
        radNight.TabStop = true;
        radNight.Text = "Night";
        radNight.UseVisualStyleBackColor = true;
        // 
        // radEvening
        // 
        radEvening.AutoSize = true;
        radEvening.Location = new Point(28, 47);
        radEvening.Name = "radEvening";
        radEvening.Size = new Size(67, 19);
        radEvening.TabIndex = 4;
        radEvening.TabStop = true;
        radEvening.Text = "Evening";
        radEvening.UseVisualStyleBackColor = true;
        radEvening.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // radDay
        // 
        radDay.AutoSize = true;
        radDay.Location = new Point(28, 22);
        radDay.Name = "radDay";
        radDay.Size = new Size(45, 19);
        radDay.TabIndex = 3;
        radDay.TabStop = true;
        radDay.Text = "Day";
        radDay.UseVisualStyleBackColor = true;
        radDay.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // chkPpeComplete
        // 
        chkPpeComplete.AutoSize = true;
        chkPpeComplete.Location = new Point(96, 195);
        chkPpeComplete.Name = "chkPpeComplete";
        chkPpeComplete.Size = new Size(157, 19);
        chkPpeComplete.TabIndex = 3;
        chkPpeComplete.Text = "PPE inspection complete";
        chkPpeComplete.UseVisualStyleBackColor = true;
        // 
        // btnCreateSummary
        // 
        btnCreateSummary.Location = new Point(40, 231);
        btnCreateSummary.Name = "btnCreateSummary";
        btnCreateSummary.Size = new Size(75, 41);
        btnCreateSummary.TabIndex = 4;
        btnCreateSummary.Text = "Create Summary";
        btnCreateSummary.UseVisualStyleBackColor = true;
        btnCreateSummary.Click += btnCreateSummary_Click;
        // 
        // lblsummary
        // 
        lblsummary.AutoSize = true;
        lblsummary.Location = new Point(192, 239);
        lblsummary.Name = "lblsummary";
        lblsummary.Size = new Size(0, 15);
        lblsummary.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(348, 351);
        Controls.Add(lblsummary);
        Controls.Add(btnCreateSummary);
        Controls.Add(chkPpeComplete);
        Controls.Add(grpShift);
        Controls.Add(txtWorkerName);
        Controls.Add(lblWorkerPrompt);
        Name = "Form1";
        Text = "PPE Inspection form";
        Load += Form1_Load;
        grpShift.ResumeLayout(false);
        grpShift.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblWorkerPrompt;
    private TextBox txtWorkerName;
    private GroupBox grpShift;
    private RadioButton radDay;
    private RadioButton radEvening;
    private RadioButton radNight;
    private CheckBox chkPpeComplete;
    private Button btnCreateSummary;
    private Label lblsummary;
}
