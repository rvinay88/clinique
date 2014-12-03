namespace clinique
{
    partial class CreateRoom
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
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.grpCreateRoom = new System.Windows.Forms.GroupBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCreateRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(82, 19);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 20);
            this.txtRoomID.TabIndex = 0;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(82, 45);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 20);
            this.txtRoomName.TabIndex = 1;
            // 
            // grpCreateRoom
            // 
            this.grpCreateRoom.Controls.Add(this.btnCancel);
            this.grpCreateRoom.Controls.Add(this.btnCreateRoom);
            this.grpCreateRoom.Controls.Add(this.lblRoomName);
            this.grpCreateRoom.Controls.Add(this.lblRoomID);
            this.grpCreateRoom.Controls.Add(this.txtRoomID);
            this.grpCreateRoom.Controls.Add(this.txtRoomName);
            this.grpCreateRoom.Location = new System.Drawing.Point(21, 23);
            this.grpCreateRoom.Name = "grpCreateRoom";
            this.grpCreateRoom.Size = new System.Drawing.Size(199, 139);
            this.grpCreateRoom.TabIndex = 2;
            this.grpCreateRoom.TabStop = false;
            this.grpCreateRoom.Text = "Create Room";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(7, 25);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(49, 13);
            this.lblRoomID.TabIndex = 2;
            this.lblRoomID.Text = "Room ID";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(7, 48);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(66, 13);
            this.lblRoomName.TabIndex = 3;
            this.lblRoomName.Text = "Room Name";
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(107, 101);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRoom.TabIndex = 4;
            this.btnCreateRoom.Text = "Create";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(10, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 192);
            this.Controls.Add(this.grpCreateRoom);
            this.Name = "CreateRoom";
            this.Text = "Create Room";
            this.grpCreateRoom.ResumeLayout(false);
            this.grpCreateRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.GroupBox grpCreateRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomID;
    }
}