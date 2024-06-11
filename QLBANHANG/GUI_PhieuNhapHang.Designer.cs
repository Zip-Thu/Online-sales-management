namespace QLBANHANG
{
    partial class fPhieuNhapHang
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.dgv_NH = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSP_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbNH_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPNH = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NH)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNH)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Chọn yêu cầu nhập hàng";
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(673, 469);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(601, 165);
            this.dgvSP.TabIndex = 34;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            // 
            // dgv_NH
            // 
            this.dgv_NH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NH.Location = new System.Drawing.Point(50, 469);
            this.dgv_NH.Name = "dgv_NH";
            this.dgv_NH.RowHeadersWidth = 51;
            this.dgv_NH.RowTemplate.Height = 24;
            this.dgv_NH.Size = new System.Drawing.Size(585, 165);
            this.dgv_NH.TabIndex = 33;
            this.dgv_NH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NH_CellClick);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(813, 381);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 44);
            this.btExit.TabIndex = 32;
            this.btExit.Text = "THOÁT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(665, 381);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(114, 44);
            this.btDelete.TabIndex = 31;
            this.btDelete.Text = "XÓA";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(513, 381);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(114, 44);
            this.btEdit.TabIndex = 30;
            this.btEdit.Text = "SỬA";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(362, 381);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(114, 44);
            this.btAdd.TabIndex = 29;
            this.btAdd.Text = "THÊM";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "PHIẾU NHẬP HÀNG";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbSum);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(284, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 43);
            this.panel4.TabIndex = 27;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(176, 12);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(35, 16);
            this.lbSum.TabIndex = 5;
            this.lbSum.Text = "0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbQuantity);
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(284, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 43);
            this.panel3.TabIndex = 26;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(515, 12);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(128, 22);
            this.tbQuantity.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(179, 12);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(139, 22);
            this.tbPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá tiền";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSP_ID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(284, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 43);
            this.panel2.TabIndex = 25;
            // 
            // tbSP_ID
            // 
            this.tbSP_ID.Location = new System.Drawing.Point(179, 12);
            this.tbSP_ID.Name = "tbSP_ID";
            this.tbSP_ID.Size = new System.Drawing.Size(464, 22);
            this.tbSP_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(284, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 43);
            this.panel1.TabIndex = 24;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(179, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(464, 22);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbNH_ID);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(284, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(681, 43);
            this.panel5.TabIndex = 25;
            // 
            // tbNH_ID
            // 
            this.tbNH_ID.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNH_ID.Location = new System.Drawing.Point(179, 12);
            this.tbNH_ID.Name = "tbNH_ID";
            this.tbNH_ID.Size = new System.Drawing.Size(464, 22);
            this.tbNH_ID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Nhập Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Chọn sản phẩm cần nhập ";
            // 
            // dgvPNH
            // 
            this.dgvPNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPNH.Location = new System.Drawing.Point(50, 676);
            this.dgvPNH.Name = "dgvPNH";
            this.dgvPNH.RowHeadersWidth = 51;
            this.dgvPNH.RowTemplate.Height = 24;
            this.dgvPNH.Size = new System.Drawing.Size(1144, 249);
            this.dgvPNH.TabIndex = 36;
            this.dgvPNH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPNH_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbNote);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(284, 332);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(681, 43);
            this.panel6.TabIndex = 26;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(179, 12);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(464, 22);
            this.tbNote.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ghi chú";
            // 
            // fPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1324, 937);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvPNH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.dgv_NH);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fPhieuNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIẾU NHẬP HÀNG";
            this.Load += new System.EventHandler(this.fPhieuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NH)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNH)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.DataGridView dgv_NH;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSP_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbNH_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvPNH;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label11;
    }
}