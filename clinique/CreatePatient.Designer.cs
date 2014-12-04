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
            this.components = new System.ComponentModel.Container();
            this.grpCreatePatient = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHealthIssue = new System.Windows.Forms.TextBox();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.CreatePatientErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCreatePatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePatientErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCreatePatient
            // 
            this.grpCreatePatient.Controls.Add(this.label3);
            this.grpCreatePatient.Controls.Add(this.label2);
            this.grpCreatePatient.Controls.Add(this.label1);
            this.grpCreatePatient.Controls.Add(this.txtHealthIssue);
            this.grpCreatePatient.Controls.Add(this.txtPatientNumber);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Issue";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient Name";
            // 
            // txtHealthIssue
            // 
            this.txtHealthIssue.Location = new System.Drawing.Point(137, 87);
            this.txtHealthIssue.Name = "txtHealthIssue";
            this.txtHealthIssue.Size = new System.Drawing.Size(169, 20);
            this.txtHealthIssue.TabIndex = 4;
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(137, 61);
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.Size = new System.Drawing.Size(169, 20);
            this.txtPatientNumber.TabIndex = 3;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(137, 33);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(169, 20);
            this.txtPatientName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Location = new System.Drawing.Point(172, 132);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePatient.TabIndex = 0;
            this.btnCreatePatient.Text = "Create";
            this.btnCreatePatient.UseVisualStyleBackColor = true;
            this.btnCreatePatient.Click += new System.EventHandler(this.btnCreatePatient_Click);
            // 
            // CreatePatientErrorProvider
            // 
            this.CreatePatientErrorProvider.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.CreatePatientErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreatePatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHealthIssue;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.ErrorProvider CreatePatientErrorProvider;
    }
}