namespace WindowsFormsApp1
{
    partial class frmMenu
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
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnOrdersCust = new System.Windows.Forms.Button();
            this.btnIncomOrders = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.Location = new System.Drawing.Point(112, 60);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(199, 36);
            this.btnLookup.TabIndex = 0;
            this.btnLookup.Text = "Look up an Item";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnOrdersCust
            // 
            this.btnOrdersCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdersCust.Location = new System.Drawing.Point(112, 133);
            this.btnOrdersCust.Name = "btnOrdersCust";
            this.btnOrdersCust.Size = new System.Drawing.Size(199, 36);
            this.btnOrdersCust.TabIndex = 1;
            this.btnOrdersCust.Text = "View Your Orders";
            this.btnOrdersCust.UseVisualStyleBackColor = true;
            this.btnOrdersCust.Click += new System.EventHandler(this.btnOrdersCust_Click);
            // 
            // btnIncomOrders
            // 
            this.btnIncomOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomOrders.Location = new System.Drawing.Point(112, 205);
            this.btnIncomOrders.Name = "btnIncomOrders";
            this.btnIncomOrders.Size = new System.Drawing.Size(199, 36);
            this.btnIncomOrders.TabIndex = 2;
            this.btnIncomOrders.Text = "Incoming Product";
            this.btnIncomOrders.UseVisualStyleBackColor = true;
            this.btnIncomOrders.Click += new System.EventHandler(this.btnIncomOrders_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(112, 281);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(199, 36);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "Scheduling";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(310, 471);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 37);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(423, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnIncomOrders);
            this.Controls.Add(this.btnOrdersCust);
            this.Controls.Add(this.btnLookup);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnOrdersCust;
        private System.Windows.Forms.Button btnIncomOrders;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnLogOut;
    }
}