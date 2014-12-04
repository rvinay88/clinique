namespace clinique
{
    partial class CreatePatient
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
            this.grpCreatePatient = new System.Windows.Forms.GroupBox();
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCreatePatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreatePatient
            // 
            this.grpCreatePatient.Controls.Add(this.label3);
            this.grpCreatePatient.Controls.Add(this.label2);
            this.grpCreatePatient.Controls.Add(this.label1);
            this.grpCreatePatient.Controls.Add(this.txtIssue);
            this.grpCreatePatient.Controls.Add(this.txtPhoneNumber);
            this.grpCreatePatient.Controls.Add(this.txtPatientName);
            this.grpCreatePatient.Controls.Add(this.btnCancel);
            this.grpCreatePatient.Controls.Add(this.btnCreatePatient);
            this.grpCreatePatient.Location = new System.Drawing.Point(22, 12);
            this.grpCreatePatient.Name = "grpCreatePatient";
            this.grpCreatePatient.Size = new System.Drawing.Size(400, 272);
            this.grpCreatePatient.TabIndex = 0;
            this.grpCreatePatient.TabStop = false;
            this.grpCreatePatient.Text = "Create Patient";
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Location = new System.Drawing.Point(172, 132);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePatient.TabIndex = 0;
            this.btnCreatePatient.Text = "Create";
            this.btnCreatePatient.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(137, 33);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(169, 20);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(137, 61);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(169, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(137, 87);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(169, 20);
            this.txtIssue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Issue";
            // 
            // CreatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 308);
            this.Controls.Add(this.grpCreatePatient);
            this.Name = "CreatePatient";
            this.Text = "Create Patient";
            this.grpCreatePatient.ResumeLayout(false);
            this.grpCreatePatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreatePatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreatePatient;
    }
}