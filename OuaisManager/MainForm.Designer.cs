namespace OuaisManager;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        lsbDepense = new ListBox();
        grbAction = new GroupBox();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        lblTitle = new Label();
        lblDetailsName = new Label();
        lblDetailsAmount = new Label();
        lblDetailsCategory = new Label();
        grbDepense = new GroupBox();
        lblInfoCategory = new Label();
        lblInfoAmount = new Label();
        lblInfoName = new Label();
        grbAction.SuspendLayout();
        grbDepense.SuspendLayout();
        SuspendLayout();
        // 
        // lsbDepense
        // 
        lsbDepense.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lsbDepense.FormattingEnabled = true;
        lsbDepense.Location = new Point(12, 57);
        lsbDepense.Name = "lsbDepense";
        lsbDepense.Size = new Size(244, 379);
        lsbDepense.TabIndex = 0;
        // 
        // grbAction
        // 
        grbAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        grbAction.Controls.Add(button3);
        grbAction.Controls.Add(button2);
        grbAction.Controls.Add(button1);
        grbAction.Location = new Point(311, 337);
        grbAction.Name = "grbAction";
        grbAction.Size = new Size(239, 99);
        grbAction.TabIndex = 1;
        grbAction.TabStop = false;
        grbAction.Text = "Actions";
        // 
        // button3
        // 
        button3.Location = new Point(160, 22);
        button3.Name = "button3";
        button3.Size = new Size(75, 72);
        button3.TabIndex = 2;
        button3.Text = "Add";
        button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(82, 22);
        button2.Name = "button2";
        button2.Size = new Size(75, 72);
        button2.TabIndex = 1;
        button2.Text = "Remove";
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(4, 22);
        button1.Name = "button1";
        button1.Size = new Size(75, 72);
        button1.TabIndex = 0;
        button1.Text = "Edit";
        button1.UseVisualStyleBackColor = true;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.Location = new Point(12, 9);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(411, 24);
        lblTitle.TabIndex = 2;
        lblTitle.Text = "OuaisManager - Gestionnaire de dépenses";
        // 
        // lblDetailsName
        // 
        lblDetailsName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblDetailsName.AutoSize = true;
        lblDetailsName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDetailsName.Location = new Point(6, 19);
        lblDetailsName.Name = "lblDetailsName";
        lblDetailsName.Size = new Size(43, 15);
        lblDetailsName.TabIndex = 3;
        lblDetailsName.Text = "Name:";
        lblDetailsName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblDetailsAmount
        // 
        lblDetailsAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblDetailsAmount.AutoSize = true;
        lblDetailsAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblDetailsAmount.Location = new Point(6, 51);
        lblDetailsAmount.Name = "lblDetailsAmount";
        lblDetailsAmount.Size = new Size(40, 15);
        lblDetailsAmount.TabIndex = 4;
        lblDetailsAmount.Text = "Total: ";
        lblDetailsAmount.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblDetailsCategory
        // 
        lblDetailsCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblDetailsCategory.AutoSize = true;
        lblDetailsCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDetailsCategory.Location = new Point(6, 84);
        lblDetailsCategory.Name = "lblDetailsCategory";
        lblDetailsCategory.Size = new Size(67, 15);
        lblDetailsCategory.TabIndex = 5;
        lblDetailsCategory.Text = "Catégorie: ";
        lblDetailsCategory.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // grbDepense
        // 
        grbDepense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        grbDepense.Controls.Add(lblInfoCategory);
        grbDepense.Controls.Add(lblInfoAmount);
        grbDepense.Controls.Add(lblInfoName);
        grbDepense.Controls.Add(lblDetailsName);
        grbDepense.Controls.Add(lblDetailsCategory);
        grbDepense.Controls.Add(lblDetailsAmount);
        grbDepense.Location = new Point(315, 57);
        grbDepense.Name = "grbDepense";
        grbDepense.Size = new Size(235, 111);
        grbDepense.TabIndex = 6;
        grbDepense.TabStop = false;
        grbDepense.Text = "INFO - Dépense";
        // 
        // lblInfoCategory
        // 
        lblInfoCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblInfoCategory.AutoSize = true;
        lblInfoCategory.Location = new Point(72, 84);
        lblInfoCategory.Name = "lblInfoCategory";
        lblInfoCategory.Size = new Size(29, 15);
        lblInfoCategory.TabIndex = 8;
        lblInfoCategory.Text = "N/A";
        lblInfoCategory.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblInfoAmount
        // 
        lblInfoAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblInfoAmount.AutoSize = true;
        lblInfoAmount.Location = new Point(72, 51);
        lblInfoAmount.Name = "lblInfoAmount";
        lblInfoAmount.Size = new Size(34, 15);
        lblInfoAmount.TabIndex = 7;
        lblInfoAmount.Text = "0.00$";
        lblInfoAmount.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblInfoName
        // 
        lblInfoName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lblInfoName.AutoSize = true;
        lblInfoName.Location = new Point(72, 19);
        lblInfoName.Name = "lblInfoName";
        lblInfoName.Size = new Size(29, 15);
        lblInfoName.TabIndex = 6;
        lblInfoName.Text = "N/A";
        lblInfoName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(571, 450);
        Controls.Add(grbDepense);
        Controls.Add(lblTitle);
        Controls.Add(grbAction);
        Controls.Add(lsbDepense);
        DoubleBuffered = true;
        Name = "MainForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dépenses - OuaisManager";
        Load += MainForm_Load;
        grbAction.ResumeLayout(false);
        grbDepense.ResumeLayout(false);
        grbDepense.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox lsbDepense;
    private GroupBox grbAction;
    private Button button1;
    private Button button3;
    private Button button2;
    private Label lblTitle;
    private Label lblDetailsName;
    private Label lblDetailsAmount;
    private Label lblDetailsCategory;
    private GroupBox grbDepense;
    private Label lblInfoName;
    private Label lblInfoAmount;
    private Label lblInfoCategory;
}