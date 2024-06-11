namespace QLBANHANG
{
    partial class fDonHang
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
            this.dgvDH = new System.Windows.Forms.DataGridView();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Chọn KH";
            // 
            // dgvDH
            // 
            this.dgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH.Location = new System.Drawing.Point(635, 347);
            this.dgvDH.Name = "dgvDH";
            this.dgvDH.RowHeadersWidth = 51;
            this.dgvDH.RowTemplate.Height = 24;
            this.dgvDH.Size = new System.Drawing.Size(553, 220);
            this.dgvDH.TabIndex = 34;
            this.dgvDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDH_CellClick);
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(12, 347);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(585, 220);
            this.dgvKH.TabIndex = 33;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(787, 285);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 44);
            this.btExit.TabIndex = 32;
            this.btExit.Text = "THOÁT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(639, 285);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(114, 44);
            this.btDelete.TabIndex = 31;
            this.btDelete.Text = "XÓA";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(487, 285);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(114, 44);
            this.btEdit.TabIndex = 30;
            this.btEdit.Text = "SỬA";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(336, 285);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(114, 44);
            this.btAdd.TabIndex = 29;
            this.btAdd.Text = "THÊM";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "ĐƠN HÀNG";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbdate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(260, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 43);
            this.panel3.TabIndex = 26;
            // 
            // tbdate
            // 
            this.tbdate.Location = new System.Drawing.Point(286, 14);
            this.tbdate.Name = "tbdate";
            this.tbdate.Size = new System.Drawing.Size(357, 22);
            this.tbdate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày nhận đơn (yyyy-MM-dd)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(260, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 43);
            this.panel2.TabIndex = 25;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(179, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(464, 22);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(260, 66);
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
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbNo);
            this.panel4.Controls.Add(this.cbYes);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(260, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 43);
            this.panel4.TabIndex = 35;
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.Location = new System.Drawing.Point(272, 11);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(67, 20);
            this.cbNo.TabIndex = 2;
            this.cbNo.Text = "Không";
            this.cbNo.UseVisualStyleBackColor = true;
            this.cbNo.CheckedChanged += new System.EventHandler(this.cbNo_CheckedChanged_1);
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Location = new System.Drawing.Point(176, 12);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(46, 20);
            this.cbYes.TabIndex = 1;
            this.cbYes.Text = "Có";
            this.cbYes.UseVisualStyleBackColor = true;
            this.cbYes.CheckedChanged += new System.EventHandler(this.cbYes_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đã giao";
            // 
            // fDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1200, 595);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDH);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DonHang";
            this.Load += new System.EventHandler(this.fDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDH;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.Label label4;
    }
}