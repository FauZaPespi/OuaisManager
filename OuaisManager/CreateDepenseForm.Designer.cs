namespace OuaisManager
{
    partial class CreateDepenseForm
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
            tbxName = new TextBox();
            label1 = new Label();
            btnCreate = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            cbxCat = new ComboBox();
            label4 = new Label();
            Calendar = new MonthCalendar();
            SuspendLayout();
            // 
            // tbxName
            // 
            tbxName.Location = new Point(12, 27);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(164, 23);
            tbxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 380);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(227, 46);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Amount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Date:";
            // 
            // cbxCat
            // 
            cbxCat.FormattingEnabled = true;
            cbxCat.Location = new Point(12, 310);
            cbxCat.Name = "cbxCat";
            cbxCat.Size = new Size(121, 23);
            cbxCat.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 292);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Category";
            // 
            // Calendar
            // 
            Calendar.Location = new Point(12, 121);
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 10;
            // 
            // CreateDepenseForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(248, 438);
            Controls.Add(Calendar);
            Controls.Add(label4);
            Controls.Add(cbxCat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(tbxName);
            MaximizeBox = false;
            MaximumSize = new Size(264, 477);
            MinimizeBox = false;
            MinimumSize = new Size(264, 477);
            Name = "CreateDepenseForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxName;
        private Label label1;
        private Button btnCreate;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox cbxCat;
        private Label label4;
        private MonthCalendar Calendar;
    }
}