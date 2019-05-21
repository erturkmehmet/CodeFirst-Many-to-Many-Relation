namespace CodeFirst_MtoMRelation
{
    partial class FormTeacher
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
            this.dgTeacherList = new System.Windows.Forms.DataGridView();
            this.btnAddT = new System.Windows.Forms.Button();
            this.txtSurnameT = new System.Windows.Forms.TextBox();
            this.txtNameT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeacherList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTeacherList
            // 
            this.dgTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeacherList.Location = new System.Drawing.Point(375, 59);
            this.dgTeacherList.Name = "dgTeacherList";
            this.dgTeacherList.Size = new System.Drawing.Size(334, 253);
            this.dgTeacherList.TabIndex = 11;
            // 
            // btnAddT
            // 
            this.btnAddT.Location = new System.Drawing.Point(160, 219);
            this.btnAddT.Name = "btnAddT";
            this.btnAddT.Size = new System.Drawing.Size(75, 23);
            this.btnAddT.TabIndex = 10;
            this.btnAddT.Text = "Add";
            this.btnAddT.UseVisualStyleBackColor = true;
            this.btnAddT.Click += new System.EventHandler(this.btnAddT_Click);
            // 
            // txtSurnameT
            // 
            this.txtSurnameT.Location = new System.Drawing.Point(181, 145);
            this.txtSurnameT.Name = "txtSurnameT";
            this.txtSurnameT.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameT.TabIndex = 9;
            // 
            // txtNameT
            // 
            this.txtNameT.Location = new System.Drawing.Point(181, 99);
            this.txtNameT.Name = "txtNameT";
            this.txtNameT.Size = new System.Drawing.Size(100, 20);
            this.txtNameT.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name :";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgTeacherList);
            this.Controls.Add(this.btnAddT);
            this.Controls.Add(this.txtSurnameT);
            this.Controls.Add(this.txtNameT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTeacherList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTeacherList;
        private System.Windows.Forms.Button btnAddT;
        private System.Windows.Forms.TextBox txtSurnameT;
        private System.Windows.Forms.TextBox txtNameT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}