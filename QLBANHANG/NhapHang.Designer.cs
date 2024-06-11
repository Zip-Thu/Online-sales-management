namespace QLBANHANG
{
    partial class fNhapHang
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
            this.dgvNH = new System.Windows.Forms.DataGridView();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNH
            // 
            this.dgvNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNH.Location = new System.Drawing.Point(660, 427);
            this.dgvNH.Name = "dgvNH";
            this.dgvNH.RowHeadersWidth = 51;
            this.dgvNH.RowTemplate.Height = 24;
            this.dgvNH.Size = new System.Drawing.Size(521, 192);
            this.dgvNH.TabIndex = 22;
            this.dgvNH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNH_CellClick);
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(37, 427);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(585, 192);
            this.dgvNCC.TabIndex = 21;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(808, 309);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 44);
            this.btExit.TabIndex = 20;
            this.btExit.Text = "THOÁT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(660, 309);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(114, 44);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "XÓA";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(508, 309);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(114, 44);
            this.btEdit.TabIndex = 18;
            this.btEdit.Text = "SỬA";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(357, 309);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(114, 44);
            this.btAdd.TabIndex = 17;
            this.btAdd.Text = "THÊM";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "YÊU CẦU NHẬP HÀNG";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbNo);
            this.panel4.Controls.Add(this.cbYes);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(266, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 43);
            this.panel4.TabIndex = 15;
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
            this.cbNo.CheckedChanged += new System.EventHandler(this.cbNo_CheckedChanged);
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
            this.cbYes.CheckedChanged += new System.EventHandler(this.cbYes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đã giao";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbdate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(266, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 43);
            this.panel3.TabIndex = 14;
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
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày nhập (yyyy-MM-dd)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(266, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 43);
            this.panel2.TabIndex = 13;
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
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NCC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(266, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 43);
            this.panel1.TabIndex = 12;
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
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên NCC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chọn NCC";
            // 
            // fNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1193, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvNH);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÊU CẦU NHẬP HÀNG";
            this.Load += new System.EventHandler(this.fNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNH;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbdate;
    }
}