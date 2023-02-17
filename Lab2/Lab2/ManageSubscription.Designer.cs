namespace Lab2
{
    partial class ManageSubscription
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
            this.chkSendEmail = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkTextNotification = new System.Windows.Forms.CheckBox();
            this.txtTextNotification = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkSendEmail
            // 
            this.chkSendEmail.AutoSize = true;
            this.chkSendEmail.Location = new System.Drawing.Point(83, 59);
            this.chkSendEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSendEmail.Name = "chkSendEmail";
            this.chkSendEmail.Size = new System.Drawing.Size(147, 17);
            this.chkSendEmail.TabIndex = 0;
            this.chkSendEmail.Text = "Notification sent by E-mail";
            this.chkSendEmail.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(242, 59);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // chkTextNotification
            // 
            this.chkTextNotification.AutoSize = true;
            this.chkTextNotification.Location = new System.Drawing.Point(83, 109);
            this.chkTextNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTextNotification.Name = "chkTextNotification";
            this.chkTextNotification.Size = new System.Drawing.Size(117, 17);
            this.chkTextNotification.TabIndex = 2;
            this.chkTextNotification.Text = "Notification by Text";
            this.chkTextNotification.UseVisualStyleBackColor = true;
            // 
            // txtTextNotification
            // 
            this.txtTextNotification.Location = new System.Drawing.Point(242, 106);
            this.txtTextNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTextNotification.Name = "txtTextNotification";
            this.txtTextNotification.Size = new System.Drawing.Size(150, 20);
            this.txtTextNotification.TabIndex = 3;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(74, 199);
            this.btnSubscribe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(108, 36);
            this.btnSubscribe.TabIndex = 4;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(197, 199);
            this.btnUnsubscribe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(98, 36);
            this.btnUnsubscribe.TabIndex = 5;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(318, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel/Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.lblInvalidEmail.Location = new System.Drawing.Point(240, 80);
            this.lblInvalidEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(66, 13);
            this.lblInvalidEmail.TabIndex = 7;
            this.lblInvalidEmail.Text = "Invalid Email";
            // 
            // ManageSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtTextNotification);
            this.Controls.Add(this.chkTextNotification);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkSendEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageSubscription";
            this.Text = "ManageSubscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSendEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkTextNotification;
        private System.Windows.Forms.TextBox txtTextNotification;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInvalidEmail;
    }
}