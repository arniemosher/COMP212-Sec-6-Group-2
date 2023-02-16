namespace Lab2
{
    partial class NotificationSubscriptionManagercs
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
            this.manageSub = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageSub
            // 
            this.manageSub.Location = new System.Drawing.Point(62, 175);
            this.manageSub.Name = "manageSub";
            this.manageSub.Size = new System.Drawing.Size(185, 59);
            this.manageSub.TabIndex = 0;
            this.manageSub.Text = "Manage Subscription";
            this.manageSub.UseVisualStyleBackColor = true;
            this.manageSub.Click += new System.EventHandler(this.manageSub_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(305, 175);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(168, 59);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish Notification";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NotificationSubscriptionManagercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.manageSub);
            this.Name = "NotificationSubscriptionManagercs";
            this.Text = "NotificationSubscriptionManagercs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageSub;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnExit;
    }
}