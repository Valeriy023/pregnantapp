namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAddPatient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDeletePatient = new System.Windows.Forms.Button();
            this.BtnEditPatient = new System.Windows.Forms.Button();
            this.lbCurrentPatient = new System.Windows.Forms.Label();
            this.tbCurrentPatient = new System.Windows.Forms.TextBox();
            this.BtnAddExam = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnDeleteAnalyzes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddPatient
            // 
            this.BtnAddPatient.Location = new System.Drawing.Point(24, 41);
            this.BtnAddPatient.Name = "BtnAddPatient";
            this.BtnAddPatient.Size = new System.Drawing.Size(150, 25);
            this.BtnAddPatient.TabIndex = 0;
            this.BtnAddPatient.Text = "Добавить пациента";
            this.BtnAddPatient.UseVisualStyleBackColor = true;
            this.BtnAddPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(24, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 100);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // BtnDeletePatient
            // 
            this.BtnDeletePatient.Location = new System.Drawing.Point(189, 41);
            this.BtnDeletePatient.Name = "BtnDeletePatient";
            this.BtnDeletePatient.Size = new System.Drawing.Size(150, 25);
            this.BtnDeletePatient.TabIndex = 2;
            this.BtnDeletePatient.Text = "Удалить пациента";
            this.BtnDeletePatient.UseVisualStyleBackColor = true;
            this.BtnDeletePatient.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEditPatient
            // 
            this.BtnEditPatient.Location = new System.Drawing.Point(354, 41);
            this.BtnEditPatient.Name = "BtnEditPatient";
            this.BtnEditPatient.Size = new System.Drawing.Size(150, 25);
            this.BtnEditPatient.TabIndex = 3;
            this.BtnEditPatient.Text = "Редактировать данные ";
            this.BtnEditPatient.UseVisualStyleBackColor = true;
            this.BtnEditPatient.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbCurrentPatient
            // 
            this.lbCurrentPatient.AutoSize = true;
            this.lbCurrentPatient.Location = new System.Drawing.Point(789, 49);
            this.lbCurrentPatient.Name = "lbCurrentPatient";
            this.lbCurrentPatient.Size = new System.Drawing.Size(99, 13);
            this.lbCurrentPatient.TabIndex = 4;
            this.lbCurrentPatient.Text = "Текущий пациент:";
            // 
            // tbCurrentPatient
            // 
            this.tbCurrentPatient.Location = new System.Drawing.Point(894, 46);
            this.tbCurrentPatient.Name = "tbCurrentPatient";
            this.tbCurrentPatient.Size = new System.Drawing.Size(248, 20);
            this.tbCurrentPatient.TabIndex = 5;
            // 
            // BtnAddExam
            // 
            this.BtnAddExam.Location = new System.Drawing.Point(520, 41);
            this.BtnAddExam.Name = "BtnAddExam";
            this.BtnAddExam.Size = new System.Drawing.Size(150, 25);
            this.BtnAddExam.TabIndex = 6;
            this.BtnAddExam.Text = "Добавить обследование";
            this.BtnAddExam.UseVisualStyleBackColor = true;
            this.BtnAddExam.Click += new System.EventHandler(this.BtnAddExam_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(12, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(539, 175);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.Location = new System.Drawing.Point(599, 244);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(543, 175);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_RowHeaderMouseClick);
            // 
            // btnDeleteAnalyzes
            // 
            this.btnDeleteAnalyzes.Location = new System.Drawing.Point(24, 213);
            this.btnDeleteAnalyzes.Name = "btnDeleteAnalyzes";
            this.btnDeleteAnalyzes.Size = new System.Drawing.Size(209, 25);
            this.btnDeleteAnalyzes.TabIndex = 9;
            this.btnDeleteAnalyzes.Text = "Удалить данные обследования";
            this.btnDeleteAnalyzes.UseVisualStyleBackColor = true;
            this.btnDeleteAnalyzes.Click += new System.EventHandler(this.tbnDeleteAnalyzes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnDeleteAnalyzes);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnAddExam);
            this.Controls.Add(this.tbCurrentPatient);
            this.Controls.Add(this.lbCurrentPatient);
            this.Controls.Add(this.BtnEditPatient);
            this.Controls.Add(this.BtnDeletePatient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAddPatient);
            this.Name = "Form1";
            this.Text = "МИС для записи беременных";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDeletePatient;
        private System.Windows.Forms.Button BtnEditPatient;
        private System.Windows.Forms.Label lbCurrentPatient;
        private System.Windows.Forms.TextBox tbCurrentPatient;
        private System.Windows.Forms.Button BtnAddExam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnDeleteAnalyzes;
    }
}

