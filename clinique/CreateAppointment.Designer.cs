namespace clinique
{
    partial class CreateAppointment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtAppointmentTime = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.CreateAppointmentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateAppointmentErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAppointmentDate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRoomNumber);
            this.groupBox1.Controls.Add(this.txtAppointmentTime);
            this.groupBox1.Controls.Add(this.txtDoctorName);
            this.groupBox1.Controls.Add(this.txtPatientNumber);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpCreateAppointment";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(135, 152);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(177, 20);
            this.dtpAppointmentDate.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Room Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Appointment Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Appointment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Name";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(135, 216);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(177, 20);
            this.txtRoomNumber.TabIndex = 5;
            // 
            // txtAppointmentTime
            // 
            this.txtAppointmentTime.Location = new System.Drawing.Point(135, 183);
            this.txtAppointmentTime.Name = "txtAppointmentTime";
            this.txtAppointmentTime.Size = new System.Drawing.Size(177, 20);
            this.txtAppointmentTime.TabIndex = 4;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(135, 113);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(177, 20);
            this.txtDoctorName.TabIndex = 2;
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(135, 77);
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.Size = new System.Drawing.Size(177, 20);
            this.txtPatientNumber.TabIndex = 1;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(135, 37);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(177, 20);
            this.txtPatientName.TabIndex = 0;
            // 
            // CreateAppointmentErrorProvider
            // 
            this.CreateAppointmentErrorProvider.ContainerControl = this;
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateAppointment";
            this.Text = "Create Appointment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateAppointmentErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtAppointmentTime;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.ErrorProvider CreateAppointmentErrorProvider;
    }
}