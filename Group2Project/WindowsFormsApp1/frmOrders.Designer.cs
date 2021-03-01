namespace WindowsFormsApp1
{
    partial class frmOrders
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
            this.tbxSearchOrder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxOrderID = new System.Windows.Forms.TextBox();
            this.tbxOrderDate = new System.Windows.Forms.TextBox();
            this.tbxOrderArrivalDate = new System.Windows.Forms.TextBox();
            this.tbxOrderQuantity = new System.Windows.Forms.TextBox();
            this.tbxOrderEmpID = new System.Windows.Forms.TextBox();
            this.tbxOrderItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Order ID";
            // 
            // tbxSearchOrder
            // 
            this.tbxSearchOrder.Location = new System.Drawing.Point(12, 47);
            this.tbxSearchOrder.Name = "tbxSearchOrder";
            this.tbxSearchOrder.Size = new System.Drawing.Size(100, 20);
            this.tbxSearchOrder.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OrderID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "OrderDate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ArrivalDate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "EmployeeID:";
            // 
            // tbxOrderID
            // 
            this.tbxOrderID.Location = new System.Drawing.Point(227, 47);
            this.tbxOrderID.Name = "tbxOrderID";
            this.tbxOrderID.ReadOnly = true;
            this.tbxOrderID.Size = new System.Drawing.Size(100, 20);
            this.tbxOrderID.TabIndex = 13;
            // 
            // tbxOrderDate
            // 
            this.tbxOrderDate.Location = new System.Drawing.Point(226, 80);
            this.tbxOrderDate.Name = "tbxOrderDate";
            this.tbxOrderDate.ReadOnly = true;
            this.tbxOrderDate.Size = new System.Drawing.Size(100, 20);
            this.tbxOrderDate.TabIndex = 14;
            // 
            // tbxOrderArrivalDate
            // 
            this.tbxOrderArrivalDate.Location = new System.Drawing.Point(225, 110);
            this.tbxOrderArrivalDate.Name = "tbxOrderArrivalDate";
            this.tbxOrderArrivalDate.ReadOnly = true;
            this.tbxOrderArrivalDate.Size = new System.Drawing.Size(100, 20);
            this.tbxOrderArrivalDate.TabIndex = 15;
            // 
            // tbxOrderQuantity
            // 
            this.tbxOrderQuantity.Location = new System.Drawing.Point(227, 190);
            this.tbxOrderQuantity.Name = "tbxOrderQuantity";
            this.tbxOrderQuantity.ReadOnly = true;
            this.tbxOrderQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxOrderQuantity.TabIndex = 16;
            // 
            // tbxOrderEmpID
            // 
            this.tbxOrderEmpID.Location = new System.Drawing.Point(229, 236);
            this.tbxOrderEmpID.Name = "tbxOrderEmpID";
            this.tbxOrderEmpID.ReadOnly = true;
            this.tbxOrderEmpID.Size = new System.Drawing.Size(100, 20);
            this.tbxOrderEmpID.TabIndex = 17;
            // 
            // tbxOrderItemName
            // 
            this.tbxOrderItemName.Location = new System.Drawing.Point(225, 150);
            this.tbxOrderItemName.Name = "tbxOrderItemName";
            this.tbxOrderItemName.ReadOnly = true;
            this.tbxOrderItemName.Size = new System.Drawing.Size(100, 20);
            this.tbxOrderItemName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Name:";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 302);
            this.Controls.Add(this.tbxOrderItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxOrderEmpID);
            this.Controls.Add(this.tbxOrderQuantity);
            this.Controls.Add(this.tbxOrderArrivalDate);
            this.Controls.Add(this.tbxOrderDate);
            this.Controls.Add(this.tbxOrderID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxSearchOrder);
            this.Controls.Add(this.label1);
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxOrderID;
        private System.Windows.Forms.TextBox tbxOrderDate;
        private System.Windows.Forms.TextBox tbxOrderArrivalDate;
        private System.Windows.Forms.TextBox tbxOrderQuantity;
        private System.Windows.Forms.TextBox tbxOrderEmpID;
        private System.Windows.Forms.TextBox tbxOrderItemName;
        private System.Windows.Forms.Label label2;
    }
}