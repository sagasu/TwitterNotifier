namespace Gui
{
    partial class TwitterForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtRefreshTime = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblRefreshTime = new System.Windows.Forms.Label();
            this.btnConfirmChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(47, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(121, 44);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // txtRefreshTime
            // 
            this.txtRefreshTime.Location = new System.Drawing.Point(121, 101);
            this.txtRefreshTime.Name = "txtRefreshTime";
            this.txtRefreshTime.Size = new System.Drawing.Size(100, 20);
            this.txtRefreshTime.TabIndex = 2;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(33, 50);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 13);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Url";
            // 
            // lblRefreshTime
            // 
            this.lblRefreshTime.AutoSize = true;
            this.lblRefreshTime.Location = new System.Drawing.Point(36, 101);
            this.lblRefreshTime.Name = "lblRefreshTime";
            this.lblRefreshTime.Size = new System.Drawing.Size(70, 13);
            this.lblRefreshTime.TabIndex = 4;
            this.lblRefreshTime.Text = "Refresh Time";
            // 
            // btnConfirmChange
            // 
            this.btnConfirmChange.Location = new System.Drawing.Point(171, 161);
            this.btnConfirmChange.Name = "btnConfirmChange";
            this.btnConfirmChange.Size = new System.Drawing.Size(75, 62);
            this.btnConfirmChange.TabIndex = 5;
            this.btnConfirmChange.Text = "Confirm Tweet Change";
            this.btnConfirmChange.UseVisualStyleBackColor = true;
            this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);
            // 
            // TwitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConfirmChange);
            this.Controls.Add(this.lblRefreshTime);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtRefreshTime);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnSave);
            this.Name = "TwitterForm";
            this.Text = "Twitter Notifier";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.components = new System.ComponentModel.Container();
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtRefreshTime;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblRefreshTime;
        private System.Windows.Forms.Button btnConfirmChange;
    }
}

