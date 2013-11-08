namespace GetThePageRank.Client.Windows
{
    partial class PageRankSingle
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblResultPageRank = new System.Windows.Forms.Label();
            this.lblResultInfo = new System.Windows.Forms.Label();
            this.chkCopyResultsToClipboard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.changeEmail);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(49, 39);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(291, 20);
            this.txtURL.TabIndex = 3;
            this.txtURL.TextChanged += new System.EventHandler(this.changeURL);
            // 
            // lblResultPageRank
            // 
            this.lblResultPageRank.AutoSize = true;
            this.lblResultPageRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPageRank.Location = new System.Drawing.Point(357, 13);
            this.lblResultPageRank.Name = "lblResultPageRank";
            this.lblResultPageRank.Size = new System.Drawing.Size(42, 46);
            this.lblResultPageRank.TabIndex = 4;
            this.lblResultPageRank.Text = "8";
            // 
            // lblResultInfo
            // 
            this.lblResultInfo.AutoSize = true;
            this.lblResultInfo.Location = new System.Drawing.Point(405, 30);
            this.lblResultInfo.Name = "lblResultInfo";
            this.lblResultInfo.Size = new System.Drawing.Size(109, 13);
            this.lblResultInfo.TabIndex = 5;
            this.lblResultInfo.Text = "Eg. www.hotmail.com";
            // 
            // chkCopyResultsToClipboard
            // 
            this.chkCopyResultsToClipboard.AutoSize = true;
            this.chkCopyResultsToClipboard.Checked = true;
            this.chkCopyResultsToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyResultsToClipboard.Location = new System.Drawing.Point(49, 66);
            this.chkCopyResultsToClipboard.Name = "chkCopyResultsToClipboard";
            this.chkCopyResultsToClipboard.Size = new System.Drawing.Size(141, 17);
            this.chkCopyResultsToClipboard.TabIndex = 6;
            this.chkCopyResultsToClipboard.Text = "Resultaat naar klembord";
            this.chkCopyResultsToClipboard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 93);
            this.Controls.Add(this.chkCopyResultsToClipboard);
            this.Controls.Add(this.lblResultInfo);
            this.Controls.Add(this.lblResultPageRank);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PageRank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblResultPageRank;
        private System.Windows.Forms.Label lblResultInfo;
        private System.Windows.Forms.CheckBox chkCopyResultsToClipboard;
    }
}

