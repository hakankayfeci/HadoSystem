namespace Hado.PL.Forms.Exam
{
    partial class _CreateExam
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReduction = new System.Windows.Forms.Button();
            this.lblCreateExam = new System.Windows.Forms.Label();
            this.cmbBoxLesson = new System.Windows.Forms.ComboBox();
            this.pnlLesson = new System.Windows.Forms.Panel();
            this.lblLesson = new System.Windows.Forms.Label();
            this.pnlTrueFalse = new System.Windows.Forms.Panel();
            this.txtBoxTrueFalse = new System.Windows.Forms.TextBox();
            this.lblTrueFalse = new System.Windows.Forms.Label();
            this.pnlClassic = new System.Windows.Forms.Panel();
            this.txtBoxClassic = new System.Windows.Forms.TextBox();
            this.lblClassic = new System.Windows.Forms.Label();
            this.pnlMultipleChoice = new System.Windows.Forms.Panel();
            this.txtBoxMultipleChoice = new System.Windows.Forms.TextBox();
            this.lblMultipleChoice = new System.Windows.Forms.Label();
            this.pnlGapFilling = new System.Windows.Forms.Panel();
            this.txtBoxGapFilling = new System.Windows.Forms.TextBox();
            this.lblGapFilling = new System.Windows.Forms.Label();
            this.cmbBoxGroupNumber = new System.Windows.Forms.ComboBox();
            this.pnlGroupNumber = new System.Windows.Forms.Panel();
            this.lblGroupNumber = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnClose);
            this.pnl1.Controls.Add(this.btnReduction);
            this.pnl1.Controls.Add(this.lblCreateExam);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(935, 54);
            this.pnl1.TabIndex = 2;
            this.pnl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnClose.Location = new System.Drawing.Point(889, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 42);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnReduction
            // 
            this.btnReduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReduction.BackColor = System.Drawing.SystemColors.Control;
            this.btnReduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReduction.FlatAppearance.BorderSize = 0;
            this.btnReduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnReduction.Location = new System.Drawing.Point(842, 0);
            this.btnReduction.Name = "btnReduction";
            this.btnReduction.Size = new System.Drawing.Size(41, 42);
            this.btnReduction.TabIndex = 33;
            this.btnReduction.Text = "_";
            this.btnReduction.UseVisualStyleBackColor = false;
            this.btnReduction.Click += new System.EventHandler(this.BtnReduction_Click);
            // 
            // lblCreateExam
            // 
            this.lblCreateExam.AutoSize = true;
            this.lblCreateExam.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreateExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblCreateExam.Location = new System.Drawing.Point(12, 12);
            this.lblCreateExam.Name = "lblCreateExam";
            this.lblCreateExam.Size = new System.Drawing.Size(166, 30);
            this.lblCreateExam.TabIndex = 1;
            this.lblCreateExam.Text = "Sınav Oluştur";
            this.lblCreateExam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblCreateExam_MouseDown);
            // 
            // cmbBoxLesson
            // 
            this.cmbBoxLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLesson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxLesson.FormattingEnabled = true;
            this.cmbBoxLesson.Items.AddRange(new object[] {
            "Seçiniz..."});
            this.cmbBoxLesson.Location = new System.Drawing.Point(17, 104);
            this.cmbBoxLesson.Name = "cmbBoxLesson";
            this.cmbBoxLesson.Size = new System.Drawing.Size(361, 29);
            this.cmbBoxLesson.TabIndex = 87;
            // 
            // pnlLesson
            // 
            this.pnlLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlLesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlLesson.Location = new System.Drawing.Point(18, 139);
            this.pnlLesson.Name = "pnlLesson";
            this.pnlLesson.Size = new System.Drawing.Size(361, 5);
            this.pnlLesson.TabIndex = 86;
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblLesson.Location = new System.Drawing.Point(13, 80);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(102, 21);
            this.lblLesson.TabIndex = 85;
            this.lblLesson.Text = "Ders Seçiniz:";
            // 
            // pnlTrueFalse
            // 
            this.pnlTrueFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlTrueFalse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlTrueFalse.Location = new System.Drawing.Point(19, 227);
            this.pnlTrueFalse.Name = "pnlTrueFalse";
            this.pnlTrueFalse.Size = new System.Drawing.Size(130, 5);
            this.pnlTrueFalse.TabIndex = 90;
            // 
            // txtBoxTrueFalse
            // 
            this.txtBoxTrueFalse.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxTrueFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTrueFalse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTrueFalse.Location = new System.Drawing.Point(19, 199);
            this.txtBoxTrueFalse.Multiline = true;
            this.txtBoxTrueFalse.Name = "txtBoxTrueFalse";
            this.txtBoxTrueFalse.Size = new System.Drawing.Size(131, 22);
            this.txtBoxTrueFalse.TabIndex = 88;
            // 
            // lblTrueFalse
            // 
            this.lblTrueFalse.AutoSize = true;
            this.lblTrueFalse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrueFalse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblTrueFalse.Location = new System.Drawing.Point(14, 175);
            this.lblTrueFalse.Name = "lblTrueFalse";
            this.lblTrueFalse.Size = new System.Drawing.Size(110, 21);
            this.lblTrueFalse.TabIndex = 89;
            this.lblTrueFalse.Text = "Doğru Yanlış:";
            // 
            // pnlClassic
            // 
            this.pnlClassic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlClassic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlClassic.Location = new System.Drawing.Point(192, 227);
            this.pnlClassic.Name = "pnlClassic";
            this.pnlClassic.Size = new System.Drawing.Size(130, 5);
            this.pnlClassic.TabIndex = 93;
            // 
            // txtBoxClassic
            // 
            this.txtBoxClassic.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxClassic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxClassic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxClassic.Location = new System.Drawing.Point(192, 199);
            this.txtBoxClassic.Multiline = true;
            this.txtBoxClassic.Name = "txtBoxClassic";
            this.txtBoxClassic.Size = new System.Drawing.Size(131, 22);
            this.txtBoxClassic.TabIndex = 91;
            // 
            // lblClassic
            // 
            this.lblClassic.AutoSize = true;
            this.lblClassic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClassic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblClassic.Location = new System.Drawing.Point(187, 175);
            this.lblClassic.Name = "lblClassic";
            this.lblClassic.Size = new System.Drawing.Size(54, 21);
            this.lblClassic.TabIndex = 92;
            this.lblClassic.Text = "Klasik:";
            // 
            // pnlMultipleChoice
            // 
            this.pnlMultipleChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlMultipleChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlMultipleChoice.Location = new System.Drawing.Point(368, 227);
            this.pnlMultipleChoice.Name = "pnlMultipleChoice";
            this.pnlMultipleChoice.Size = new System.Drawing.Size(130, 5);
            this.pnlMultipleChoice.TabIndex = 96;
            // 
            // txtBoxMultipleChoice
            // 
            this.txtBoxMultipleChoice.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxMultipleChoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMultipleChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMultipleChoice.Location = new System.Drawing.Point(368, 199);
            this.txtBoxMultipleChoice.Multiline = true;
            this.txtBoxMultipleChoice.Name = "txtBoxMultipleChoice";
            this.txtBoxMultipleChoice.Size = new System.Drawing.Size(131, 22);
            this.txtBoxMultipleChoice.TabIndex = 94;
            // 
            // lblMultipleChoice
            // 
            this.lblMultipleChoice.AutoSize = true;
            this.lblMultipleChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMultipleChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblMultipleChoice.Location = new System.Drawing.Point(363, 175);
            this.lblMultipleChoice.Name = "lblMultipleChoice";
            this.lblMultipleChoice.Size = new System.Drawing.Size(136, 21);
            this.lblMultipleChoice.TabIndex = 95;
            this.lblMultipleChoice.Text = "Çoktan Seçmeli:";
            // 
            // pnlGapFilling
            // 
            this.pnlGapFilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlGapFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlGapFilling.Location = new System.Drawing.Point(552, 227);
            this.pnlGapFilling.Name = "pnlGapFilling";
            this.pnlGapFilling.Size = new System.Drawing.Size(130, 5);
            this.pnlGapFilling.TabIndex = 99;
            // 
            // txtBoxGapFilling
            // 
            this.txtBoxGapFilling.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxGapFilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxGapFilling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxGapFilling.Location = new System.Drawing.Point(552, 199);
            this.txtBoxGapFilling.Multiline = true;
            this.txtBoxGapFilling.Name = "txtBoxGapFilling";
            this.txtBoxGapFilling.Size = new System.Drawing.Size(131, 22);
            this.txtBoxGapFilling.TabIndex = 97;
            // 
            // lblGapFilling
            // 
            this.lblGapFilling.AutoSize = true;
            this.lblGapFilling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGapFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblGapFilling.Location = new System.Drawing.Point(547, 175);
            this.lblGapFilling.Name = "lblGapFilling";
            this.lblGapFilling.Size = new System.Drawing.Size(141, 21);
            this.lblGapFilling.TabIndex = 98;
            this.lblGapFilling.Text = "Boşluk Doldurma:";
            // 
            // cmbBoxGroupNumber
            // 
            this.cmbBoxGroupNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGroupNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxGroupNumber.FormattingEnabled = true;
            this.cmbBoxGroupNumber.Items.AddRange(new object[] {
            "Seçiniz...",
            "1",
            "2",
            "3",
            "4"});
            this.cmbBoxGroupNumber.Location = new System.Drawing.Point(19, 305);
            this.cmbBoxGroupNumber.Name = "cmbBoxGroupNumber";
            this.cmbBoxGroupNumber.Size = new System.Drawing.Size(221, 29);
            this.cmbBoxGroupNumber.TabIndex = 106;
            // 
            // pnlGroupNumber
            // 
            this.pnlGroupNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlGroupNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlGroupNumber.Location = new System.Drawing.Point(20, 340);
            this.pnlGroupNumber.Name = "pnlGroupNumber";
            this.pnlGroupNumber.Size = new System.Drawing.Size(221, 5);
            this.pnlGroupNumber.TabIndex = 105;
            // 
            // lblGroupNumber
            // 
            this.lblGroupNumber.AutoSize = true;
            this.lblGroupNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGroupNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblGroupNumber.Location = new System.Drawing.Point(15, 281);
            this.lblGroupNumber.Name = "lblGroupNumber";
            this.lblGroupNumber.Size = new System.Drawing.Size(102, 21);
            this.lblGroupNumber.TabIndex = 104;
            this.lblGroupNumber.Text = "Grup Adeti:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(19, 395);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(668, 52);
            this.btnCreate.TabIndex = 107;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // _CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 510);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbBoxGroupNumber);
            this.Controls.Add(this.pnlGroupNumber);
            this.Controls.Add(this.lblGroupNumber);
            this.Controls.Add(this.pnlGapFilling);
            this.Controls.Add(this.txtBoxGapFilling);
            this.Controls.Add(this.lblGapFilling);
            this.Controls.Add(this.pnlMultipleChoice);
            this.Controls.Add(this.txtBoxMultipleChoice);
            this.Controls.Add(this.lblMultipleChoice);
            this.Controls.Add(this.pnlClassic);
            this.Controls.Add(this.txtBoxClassic);
            this.Controls.Add(this.lblClassic);
            this.Controls.Add(this.pnlTrueFalse);
            this.Controls.Add(this.txtBoxTrueFalse);
            this.Controls.Add(this.lblTrueFalse);
            this.Controls.Add(this.cmbBoxLesson);
            this.Controls.Add(this.pnlLesson);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_CreateExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_CreateExam";
            this.Load += new System.EventHandler(this._CreateExam_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReduction;
        private System.Windows.Forms.Label lblCreateExam;
        private System.Windows.Forms.ComboBox cmbBoxLesson;
        private System.Windows.Forms.Panel pnlLesson;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Panel pnlTrueFalse;
        private System.Windows.Forms.TextBox txtBoxTrueFalse;
        private System.Windows.Forms.Label lblTrueFalse;
        private System.Windows.Forms.Panel pnlClassic;
        private System.Windows.Forms.TextBox txtBoxClassic;
        private System.Windows.Forms.Label lblClassic;
        private System.Windows.Forms.Panel pnlMultipleChoice;
        private System.Windows.Forms.TextBox txtBoxMultipleChoice;
        private System.Windows.Forms.Label lblMultipleChoice;
        private System.Windows.Forms.Panel pnlGapFilling;
        private System.Windows.Forms.TextBox txtBoxGapFilling;
        private System.Windows.Forms.Label lblGapFilling;
        private System.Windows.Forms.ComboBox cmbBoxGroupNumber;
        private System.Windows.Forms.Panel pnlGroupNumber;
        private System.Windows.Forms.Label lblGroupNumber;
        private System.Windows.Forms.Button btnCreate;
    }
}