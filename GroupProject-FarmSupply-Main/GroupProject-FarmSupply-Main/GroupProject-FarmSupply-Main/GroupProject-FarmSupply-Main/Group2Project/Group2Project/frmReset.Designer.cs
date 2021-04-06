
namespace Group2Project
{
    partial class frmReset
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbxNew = new System.Windows.Forms.TextBox();
            this.tbxCurrent = new System.Windows.Forms.TextBox();
            this.tbxReEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(107, 111);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbxNew
            // 
            this.tbxNew.Location = new System.Drawing.Point(12, 48);
            this.tbxNew.Name = "tbxNew";
            this.tbxNew.Size = new System.Drawing.Size(170, 20);
            this.tbxNew.TabIndex = 7;
            this.tbxNew.Text = "New Password";
            // 
            // tbxCurrent
            // 
            this.tbxCurrent.Location = new System.Drawing.Point(12, 12);
            this.tbxCurrent.Name = "tbxCurrent";
            this.tbxCurrent.Size = new System.Drawing.Size(170, 20);
            this.tbxCurrent.TabIndex = 6;
            this.tbxCurrent.Text = "Current Password";
            // 
            // tbxReEnter
            // 
            this.tbxReEnter.Location = new System.Drawing.Point(12, 85);
            this.tbxReEnter.Name = "tbxReEnter";
            this.tbxReEnter.Size = new System.Drawing.Size(170, 20);
            this.tbxReEnter.TabIndex = 10;
            this.tbxReEnter.Text = "ReEnter New Password";
            // 
            // frmReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 168);
            this.Controls.Add(this.tbxReEnter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxNew);
            this.Controls.Add(this.tbxCurrent);
            this.Name = "frmReset";
            this.Text = "frmReset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxNew;
        private System.Windows.Forms.TextBox tbxCurrent;
        private System.Windows.Forms.TextBox tbxReEnter;
    }
}