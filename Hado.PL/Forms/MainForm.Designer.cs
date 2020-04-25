namespace Hado.PL.Forms
{
    partial class MainForm
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
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.btnClosed = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.toolTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTeacherAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTeacherUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTeacherDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLessonAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLessonUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLessonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuestionAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuestionUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuestionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExamCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExamSaved = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKontrol.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKontrol
            // 
            this.pnlKontrol.AutoSize = true;
            this.pnlKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlKontrol.Controls.Add(this.btnRestore);
            this.pnlKontrol.Controls.Add(this.btnClosed);
            this.pnlKontrol.Controls.Add(this.btnMinimize);
            this.pnlKontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKontrol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlKontrol.Location = new System.Drawing.Point(192, 0);
            this.pnlKontrol.Margin = new System.Windows.Forms.Padding(0);
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(632, 36);
            this.pnlKontrol.TabIndex = 29;
            this.pnlKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlKontrol_MouseDown);
            // 
            // btnClosed
            // 
            this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosed.AutoSize = true;
            this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosed.FlatAppearance.BorderSize = 0;
            this.btnClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClosed.ForeColor = System.Drawing.Color.White;
            this.btnClosed.Location = new System.Drawing.Point(597, 3);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(31, 30);
            this.btnClosed.TabIndex = 34;
            this.btnClosed.Text = "X";
            this.btnClosed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClosed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.BtnClosed_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(525, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 31;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTeacher,
            this.toolLesson,
            this.toolQuestion,
            this.toolExam,
            this.toolLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(192, 453);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pictureBoxLogo.Image = global::Hado.PL.Properties.Resources.hadoLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(43, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 34;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.AutoSize = true;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Image = global::Hado.PL.Properties.Resources.front3;
            this.btnRestore.Location = new System.Drawing.Point(561, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(30, 30);
            this.btnRestore.TabIndex = 35;
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.Button1_Click);
            // 
            // toolTeacher
            // 
            this.toolTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolTeacher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTeacherAdd,
            this.toolTeacherUpdate,
            this.toolTeacherDelete});
            this.toolTeacher.ForeColor = System.Drawing.SystemColors.Control;
            this.toolTeacher.Image = global::Hado.PL.Properties.Resources.teacher_profesor;
            this.toolTeacher.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolTeacher.Name = "toolTeacher";
            this.toolTeacher.Size = new System.Drawing.Size(191, 25);
            this.toolTeacher.Text = "Öğretmen";
            // 
            // toolTeacherAdd
            // 
            this.toolTeacherAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolTeacherAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.toolTeacherAdd.Image = global::Hado.PL.Properties.Resources.add;
            this.toolTeacherAdd.Name = "toolTeacherAdd";
            this.toolTeacherAdd.Size = new System.Drawing.Size(236, 26);
            this.toolTeacherAdd.Text = "Öğretmen Ekle";
            this.toolTeacherAdd.Click += new System.EventHandler(this.OgretmenIslemleriMenu_Click);
            // 
            // toolTeacherUpdate
            // 
            this.toolTeacherUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolTeacherUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.toolTeacherUpdate.Image = global::Hado.PL.Properties.Resources.update;
            this.toolTeacherUpdate.Name = "toolTeacherUpdate";
            this.toolTeacherUpdate.Size = new System.Drawing.Size(236, 26);
            this.toolTeacherUpdate.Text = "Öğretmen Güncelle";
            this.toolTeacherUpdate.Click += new System.EventHandler(this.ÖğretmenGüncelleToolStripMenuItem_Click);
            // 
            // toolTeacherDelete
            // 
            this.toolTeacherDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(78)))));
            this.toolTeacherDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.toolTeacherDelete.Image = global::Hado.PL.Properties.Resources.delete;
            this.toolTeacherDelete.Name = "toolTeacherDelete";
            this.toolTeacherDelete.Size = new System.Drawing.Size(236, 26);
            this.toolTeacherDelete.Text = "Öğretmen Sil";
            this.toolTeacherDelete.Click += new System.EventHandler(this.ÖğretmenSilToolStripMenuItem_Click);
            // 
            // toolLesson
            // 
            this.toolLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolLesson.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLessonAdd,
            this.toolLessonUpdate,
            this.toolLessonDelete});
            this.toolLesson.ForeColor = System.Drawing.SystemColors.Control;
            this.toolLesson.Image = global::Hado.PL.Properties.Resources.lesson;
            this.toolLesson.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolLesson.Name = "toolLesson";
            this.toolLesson.Size = new System.Drawing.Size(191, 25);
            this.toolLesson.Text = "Ders";
            // 
            // toolLessonAdd
            // 
            this.toolLessonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolLessonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.toolLessonAdd.Image = global::Hado.PL.Properties.Resources.add;
            this.toolLessonAdd.Name = "toolLessonAdd";
            this.toolLessonAdd.Size = new System.Drawing.Size(187, 26);
            this.toolLessonAdd.Text = "Ders Ekle";
            this.toolLessonAdd.Click += new System.EventHandler(this.dersIslemleriMenu_Click);
            // 
            // toolLessonUpdate
            // 
            this.toolLessonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolLessonUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.toolLessonUpdate.Image = global::Hado.PL.Properties.Resources.update;
            this.toolLessonUpdate.Name = "toolLessonUpdate";
            this.toolLessonUpdate.Size = new System.Drawing.Size(187, 26);
            this.toolLessonUpdate.Text = "Ders Güncelle";
            this.toolLessonUpdate.Click += new System.EventHandler(this.DersGüncelleToolStripMenuItem1_Click);
            // 
            // toolLessonDelete
            // 
            this.toolLessonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolLessonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.toolLessonDelete.Image = global::Hado.PL.Properties.Resources.delete;
            this.toolLessonDelete.Name = "toolLessonDelete";
            this.toolLessonDelete.Size = new System.Drawing.Size(187, 26);
            this.toolLessonDelete.Text = "Ders Sil";
            this.toolLessonDelete.Click += new System.EventHandler(this.DersSilToolStripMenuItem1_Click);
            // 
            // toolQuestion
            // 
            this.toolQuestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolQuestionAdd,
            this.toolQuestionUpdate,
            this.toolQuestionDelete});
            this.toolQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.toolQuestion.Image = global::Hado.PL.Properties.Resources.idea;
            this.toolQuestion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolQuestion.Name = "toolQuestion";
            this.toolQuestion.Size = new System.Drawing.Size(191, 25);
            this.toolQuestion.Text = "Soru Havuzu";
            // 
            // toolQuestionAdd
            // 
            this.toolQuestionAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolQuestionAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.toolQuestionAdd.Image = global::Hado.PL.Properties.Resources.add;
            this.toolQuestionAdd.Name = "toolQuestionAdd";
            this.toolQuestionAdd.Size = new System.Drawing.Size(187, 26);
            this.toolQuestionAdd.Text = "Soru Ekle";
            this.toolQuestionAdd.Click += new System.EventHandler(this.SoruEkleToolStripMenuItem_Click);
            // 
            // toolQuestionUpdate
            // 
            this.toolQuestionUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolQuestionUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.toolQuestionUpdate.Image = global::Hado.PL.Properties.Resources.update;
            this.toolQuestionUpdate.Name = "toolQuestionUpdate";
            this.toolQuestionUpdate.Size = new System.Drawing.Size(187, 26);
            this.toolQuestionUpdate.Text = "Soru Güncelle";
            this.toolQuestionUpdate.Click += new System.EventHandler(this.soruSilToolStripMenuItem_Click);
            // 
            // toolQuestionDelete
            // 
            this.toolQuestionDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolQuestionDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.toolQuestionDelete.Image = global::Hado.PL.Properties.Resources.delete;
            this.toolQuestionDelete.Name = "toolQuestionDelete";
            this.toolQuestionDelete.Size = new System.Drawing.Size(187, 26);
            this.toolQuestionDelete.Text = "Soru Sil";
            this.toolQuestionDelete.Click += new System.EventHandler(this.SoruSilToolStripMenuItem_Click_1);
            // 
            // toolExam
            // 
            this.toolExam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExamCreate,
            this.toolExamSaved});
            this.toolExam.ForeColor = System.Drawing.SystemColors.Control;
            this.toolExam.Image = global::Hado.PL.Properties.Resources.question;
            this.toolExam.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolExam.Name = "toolExam";
            this.toolExam.Size = new System.Drawing.Size(191, 25);
            this.toolExam.Text = "Sınav";
            // 
            // toolExamCreate
            // 
            this.toolExamCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolExamCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.toolExamCreate.Image = global::Hado.PL.Properties.Resources.add;
            this.toolExamCreate.Name = "toolExamCreate";
            this.toolExamCreate.Size = new System.Drawing.Size(189, 26);
            this.toolExamCreate.Text = "Sınav Oluştur";
            this.toolExamCreate.Click += new System.EventHandler(this.SınavOluşturToolStripMenuItem_Click);
            // 
            // toolExamSaved
            // 
            this.toolExamSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.toolExamSaved.ForeColor = System.Drawing.SystemColors.Control;
            this.toolExamSaved.Image = global::Hado.PL.Properties.Resources.saved;
            this.toolExamSaved.Name = "toolExamSaved";
            this.toolExamSaved.Size = new System.Drawing.Size(189, 26);
            this.toolExamSaved.Text = "Kayıtlı Sınavlar";
            this.toolExamSaved.Click += new System.EventHandler(this.KayıtlıSınavlarToolStripMenuItem_Click);
            // 
            // toolLogout
            // 
            this.toolLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.toolLogout.Image = global::Hado.PL.Properties.Resources.logout;
            this.toolLogout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolLogout.Name = "toolLogout";
            this.toolLogout.Size = new System.Drawing.Size(191, 25);
            this.toolLogout.Text = "Oturumu Kapat";
            this.toolLogout.Click += new System.EventHandler(this.ToolLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(824, 453);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pnlKontrol);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolLessonAdd;
        private System.Windows.Forms.ToolStripMenuItem toolLesson;
        private System.Windows.Forms.ToolStripMenuItem toolTeacherAdd;
        private System.Windows.Forms.ToolStripMenuItem toolTeacher;
        private System.Windows.Forms.Panel pnlKontrol;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolLessonUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolLessonDelete;
        private System.Windows.Forms.ToolStripMenuItem toolQuestion;
        private System.Windows.Forms.ToolStripMenuItem toolQuestionAdd;
        private System.Windows.Forms.ToolStripMenuItem toolQuestionUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolQuestionDelete;
        private System.Windows.Forms.ToolStripMenuItem toolExam;
        private System.Windows.Forms.ToolStripMenuItem toolExamCreate;
        private System.Windows.Forms.ToolStripMenuItem toolExamSaved;
        private System.Windows.Forms.ToolStripMenuItem toolTeacherUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolTeacherDelete;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ToolStripMenuItem toolLogout;
    }
}



