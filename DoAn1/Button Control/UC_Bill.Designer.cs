namespace DoAn1.Button_Control
{
    partial class UC_Bill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTableList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtTableType = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtSearchTable = new System.Windows.Forms.TextBox();
            this.btnSearchTable = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintBill = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableList
            // 
            this.dgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableList.Location = new System.Drawing.Point(3, 81);
            this.dgvTableList.Name = "dgvTableList";
            this.dgvTableList.RowHeadersWidth = 51;
            this.dgvTableList.RowTemplate.Height = 24;
            this.dgvTableList.Size = new System.Drawing.Size(637, 859);
            this.dgvTableList.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(760, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(760, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại bàn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(760, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tổng tiền:";
            // 
            // txtTableID
            // 
            this.txtTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableID.Location = new System.Drawing.Point(882, 234);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.Size = new System.Drawing.Size(283, 27);
            this.txtTableID.TabIndex = 21;
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(882, 305);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(283, 27);
            this.txtTableName.TabIndex = 22;
            // 
            // txtTableType
            // 
            this.txtTableType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableType.Location = new System.Drawing.Point(882, 376);
            this.txtTableType.Name = "txtTableType";
            this.txtTableType.Size = new System.Drawing.Size(283, 27);
            this.txtTableType.TabIndex = 22;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(882, 444);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(283, 27);
            this.txtMoney.TabIndex = 22;
            // 
            // txtSearchTable
            // 
            this.txtSearchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTable.Location = new System.Drawing.Point(720, 98);
            this.txtSearchTable.Name = "txtSearchTable";
            this.txtSearchTable.Size = new System.Drawing.Size(395, 27);
            this.txtSearchTable.TabIndex = 21;
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.BorderRadius = 15;
            this.btnSearchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchTable.FillColor = System.Drawing.Color.LightGray;
            this.btnSearchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTable.ForeColor = System.Drawing.Color.Black;
            this.btnSearchTable.Location = new System.Drawing.Point(1121, 81);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(106, 66);
            this.btnSearchTable.TabIndex = 23;
            this.btnSearchTable.Text = "Tìm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(760, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giảm giá:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(882, 505);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(283, 27);
            this.txtDiscount.TabIndex = 22;
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 15;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.LightGray;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(1032, 651);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(106, 94);
            this.btnPay.TabIndex = 26;
            this.btnPay.Text = "Thanh toán";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BorderRadius = 15;
            this.btnPrintBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintBill.FillColor = System.Drawing.Color.LightGray;
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.Black;
            this.btnPrintBill.Location = new System.Drawing.Point(798, 651);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(106, 94);
            this.btnPrintBill.TabIndex = 27;
            this.btnPrintBill.Text = "In hóa đơn";
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnSearchTable);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtTableType);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.txtSearchTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTableID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTableList);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(1277, 943);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTableList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtTableType;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtSearchTable;
        private Guna.UI2.WinForms.Guna2Button btnSearchTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscount;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnPrintBill;
    }
}
