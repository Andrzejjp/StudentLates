namespace StudentLates
{
    partial class frmStudentLatesV1
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMinLate = new System.Windows.Forms.TextBox();
            this.dtpDayOfLate = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewLate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(53, 42);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(55, 13);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "StudentID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day of Late";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Late";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(129, 42);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(118, 20);
            this.txtStudentID.TabIndex = 4;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(129, 68);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(118, 20);
            this.txtPeriod.TabIndex = 5;
            // 
            // txtMinLate
            // 
            this.txtMinLate.Location = new System.Drawing.Point(129, 120);
            this.txtMinLate.Name = "txtMinLate";
            this.txtMinLate.Size = new System.Drawing.Size(118, 20);
            this.txtMinLate.TabIndex = 7;
            // 
            // dtpDayOfLate
            // 
            this.dtpDayOfLate.Location = new System.Drawing.Point(129, 93);
            this.dtpDayOfLate.Name = "dtpDayOfLate";
            this.dtpDayOfLate.Size = new System.Drawing.Size(118, 20);
            this.dtpDayOfLate.TabIndex = 8;
            // 
            // btnAddNewLate
            // 
            this.btnAddNewLate.Location = new System.Drawing.Point(129, 157);
            this.btnAddNewLate.Name = "btnAddNewLate";
            this.btnAddNewLate.Size = new System.Drawing.Size(71, 24);
            this.btnAddNewLate.TabIndex = 9;
            this.btnAddNewLate.Text = "AddNew";
            this.btnAddNewLate.UseVisualStyleBackColor = true;
            this.btnAddNewLate.Click += new System.EventHandler(this.btnAddNewLate_Click);
            // 
            // frmStudentLatesV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 190);
            this.Controls.Add(this.btnAddNewLate);
            this.Controls.Add(this.dtpDayOfLate);
            this.Controls.Add(this.txtMinLate);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Name = "frmStudentLatesV1";
            this.Text = "frmStudentLatesV1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtMinLate;
        private System.Windows.Forms.DateTimePicker dtpDayOfLate;
        private System.Windows.Forms.Button btnAddNewLate;
    }
}