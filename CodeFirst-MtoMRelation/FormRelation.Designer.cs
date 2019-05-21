namespace CodeFirst_MtoMRelation
{
    partial class FormRelation
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.btnRelate = new System.Windows.Forms.Button();
            this.dgRelateList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelateList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(139, 45);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(121, 21);
            this.cmbTeacher.TabIndex = 1;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // lbStudent
            // 
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.Location = new System.Drawing.Point(140, 103);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(120, 186);
            this.lbStudent.TabIndex = 3;
            // 
            // btnRelate
            // 
            this.btnRelate.Location = new System.Drawing.Point(301, 103);
            this.btnRelate.Name = "btnRelate";
            this.btnRelate.Size = new System.Drawing.Size(75, 36);
            this.btnRelate.TabIndex = 4;
            this.btnRelate.Text = "Relate";
            this.btnRelate.UseVisualStyleBackColor = true;
            this.btnRelate.Click += new System.EventHandler(this.btnRelate_Click);
            // 
            // dgRelateList
            // 
            this.dgRelateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRelateList.Location = new System.Drawing.Point(432, 33);
            this.dgRelateList.Name = "dgRelateList";
            this.dgRelateList.Size = new System.Drawing.Size(339, 256);
            this.dgRelateList.TabIndex = 5;
            // 
            // FormRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgRelateList);
            this.Controls.Add(this.btnRelate);
            this.Controls.Add(this.lbStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.label1);
            this.Name = "FormRelation";
            this.Text = "FormRelation";
            this.Load += new System.EventHandler(this.FormRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRelateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbStudent;
        private System.Windows.Forms.Button btnRelate;
        private System.Windows.Forms.DataGridView dgRelateList;
    }
}