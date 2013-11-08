namespace GetThePageRank.Client.Windows
{
    partial class Main
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
            this.btnOneByOne = new System.Windows.Forms.Button();
            this.txtBatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOneByOne
            // 
            this.btnOneByOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneByOne.Location = new System.Drawing.Point(13, 13);
            this.btnOneByOne.Name = "btnOneByOne";
            this.btnOneByOne.Size = new System.Drawing.Size(174, 178);
            this.btnOneByOne.TabIndex = 0;
            this.btnOneByOne.Text = "Single";
            this.btnOneByOne.UseVisualStyleBackColor = true;
            this.btnOneByOne.Click += new System.EventHandler(this.btnOneByOne_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.Location = new System.Drawing.Point(193, 12);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(174, 178);
            this.txtBatch.TabIndex = 1;
            this.txtBatch.Text = "Batch";
            this.txtBatch.UseVisualStyleBackColor = true;
            this.txtBatch.Click += new System.EventHandler(this.txtBatch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 203);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.btnOneByOne);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOneByOne;
        private System.Windows.Forms.Button txtBatch;
    }
}