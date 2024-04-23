namespace Test
{
    partial class Form5
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
            this.tbFerrMin = new System.Windows.Forms.TextBox();
            this.lbFerr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbFerrMax = new System.Windows.Forms.TextBox();
            this.tbSeIronMax = new System.Windows.Forms.TextBox();
            this.tbHGBMax = new System.Windows.Forms.TextBox();
            this.tbHGBMin = new System.Windows.Forms.TextBox();
            this.tbSeIronMin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFerrMin
            // 
            this.tbFerrMin.Location = new System.Drawing.Point(47, 45);
            this.tbFerrMin.Name = "tbFerrMin";
            this.tbFerrMin.Size = new System.Drawing.Size(100, 20);
            this.tbFerrMin.TabIndex = 0;
            this.tbFerrMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFerrMin_KeyPress);
            // 
            // lbFerr
            // 
            this.lbFerr.AutoSize = true;
            this.lbFerr.Location = new System.Drawing.Point(121, 11);
            this.lbFerr.Name = "lbFerr";
            this.lbFerr.Size = new System.Drawing.Size(95, 13);
            this.lbFerr.TabIndex = 6;
            this.lbFerr.Text = "Ферритин, мкг/л";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сывороточное железо, мкмоль/л";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Гемоглобин, г/л";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "мин.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "макс.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "мин.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "макс.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "макс.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "мин.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSeIronMin);
            this.panel1.Controls.Add(this.tbHGBMin);
            this.panel1.Controls.Add(this.tbHGBMax);
            this.panel1.Controls.Add(this.tbSeIronMax);
            this.panel1.Controls.Add(this.tbFerrMax);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbFerr);
            this.panel1.Controls.Add(this.tbFerrMin);
            this.panel1.Location = new System.Drawing.Point(34, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 297);
            this.panel1.TabIndex = 15;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(143, 364);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbFerrMax
            // 
            this.tbFerrMax.Location = new System.Drawing.Point(220, 45);
            this.tbFerrMax.Name = "tbFerrMax";
            this.tbFerrMax.Size = new System.Drawing.Size(100, 20);
            this.tbFerrMax.TabIndex = 15;
            this.tbFerrMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFerrMax_KeyPress);
            // 
            // tbSeIronMax
            // 
            this.tbSeIronMax.Location = new System.Drawing.Point(220, 146);
            this.tbSeIronMax.Name = "tbSeIronMax";
            this.tbSeIronMax.Size = new System.Drawing.Size(100, 20);
            this.tbSeIronMax.TabIndex = 16;
            this.tbSeIronMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeIronMax_KeyPress);
            // 
            // tbHGBMax
            // 
            this.tbHGBMax.Location = new System.Drawing.Point(220, 236);
            this.tbHGBMax.Name = "tbHGBMax";
            this.tbHGBMax.Size = new System.Drawing.Size(100, 20);
            this.tbHGBMax.TabIndex = 17;
            this.tbHGBMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHGBMax_KeyPress);
            // 
            // tbHGBMin
            // 
            this.tbHGBMin.Location = new System.Drawing.Point(47, 236);
            this.tbHGBMin.Name = "tbHGBMin";
            this.tbHGBMin.Size = new System.Drawing.Size(100, 20);
            this.tbHGBMin.TabIndex = 18;
            this.tbHGBMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHGBMin_KeyPress);
            // 
            // tbSeIronMin
            // 
            this.tbSeIronMin.Location = new System.Drawing.Point(47, 146);
            this.tbSeIronMin.Name = "tbSeIronMin";
            this.tbSeIronMin.Size = new System.Drawing.Size(100, 20);
            this.tbSeIronMin.TabIndex = 19;
            this.tbSeIronMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeIronMin_KeyPress);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 399);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbFerrMin;
        private System.Windows.Forms.Label lbFerr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbSeIronMin;
        private System.Windows.Forms.TextBox tbHGBMin;
        private System.Windows.Forms.TextBox tbHGBMax;
        private System.Windows.Forms.TextBox tbSeIronMax;
        private System.Windows.Forms.TextBox tbFerrMax;
    }
}