namespace ParkingLotDump
{
    partial class PrintReceipt
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
            this.lblSlotNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlateNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.ReceiptQR = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SLOT";
            // 
            // lblSlotNum
            // 
            this.lblSlotNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblSlotNum.Location = new System.Drawing.Point(88, 110);
            this.lblSlotNum.Name = "lblSlotNum";
            this.lblSlotNum.Size = new System.Drawing.Size(99, 57);
            this.lblSlotNum.TabIndex = 1;
            this.lblSlotNum.Text = "A-1";
            this.lblSlotNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parking Lot Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(9, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plate Number: ";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPlateNum.Location = new System.Drawing.Point(150, 183);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(113, 20);
            this.lblPlateNum.TabIndex = 4;
            this.lblPlateNum.Text = "-";
            this.lblPlateNum.Click += new System.EventHandler(this.lblPlateNum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(61, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time In: ";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTime.Location = new System.Drawing.Point(150, 212);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 20);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "-";
            // 
            // ReceiptQR
            // 
            this.ReceiptQR.Location = new System.Drawing.Point(78, 256);
            this.ReceiptQR.Name = "ReceiptQR";
            this.ReceiptQR.Size = new System.Drawing.Size(118, 107);
            this.ReceiptQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReceiptQR.TabIndex = 7;
            this.ReceiptQR.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(62, 378);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(147, 20);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(8, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date:";
            // 
            // PrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 405);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ReceiptQR);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPlateNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSlotNum);
            this.Controls.Add(this.label1);
            this.Name = "PrintReceipt";
            this.Text = "PrintReceipt";
            this.Load += new System.EventHandler(this.PrintReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSlotNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlateNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox ReceiptQR;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label9;
    }
}