namespace QLBANHANG
{
    partial class fNewAccount
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
            this.label3 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.pnPass = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnNameLogin = new System.Windows.Forms.Panel();
            this.tbNameLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbQuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnPass.SuspendLayout();
            this.pnNameLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(226, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "TẠO TÀI KHOẢN MỚI";
            // 
            // btExit
            // 
            this.btExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btExit.Location = new System.Drawing.Point(494, 565);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(149, 60);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btLogin.Location = new System.Drawing.Point(158, 565);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(330, 60);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Xác Nhận";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pnPass
            // 
            this.pnPass.Controls.Add(this.tbPass);
            this.pnPass.Controls.Add(this.label2);
            this.pnPass.Location = new System.Drawing.Point(158, 221);
            this.pnPass.Name = "pnPass";
            this.pnPass.Size = new System.Drawing.Size(485, 102);
            this.pnPass.TabIndex = 7;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbPass.Location = new System.Drawing.Point(158, 36);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(305, 22);
            this.tbPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // pnNameLogin
            // 
            this.pnNameLogin.Controls.Add(this.tbNameLogin);
            this.pnNameLogin.Controls.Add(this.label1);
            this.pnNameLogin.Location = new System.Drawing.Point(158, 113);
            this.pnNameLogin.Name = "pnNameLogin";
            this.pnNameLogin.Size = new System.Drawing.Size(485, 102);
            this.pnNameLogin.TabIndex = 6;
            // 
            // tbNameLogin
            // 
            this.tbNameLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbNameLogin.Location = new System.Drawing.Point(158, 36);
            this.tbNameLogin.Name = "tbNameLogin";
            this.tbNameLogin.Size = new System.Drawing.Size(305, 22);
            this.tbNameLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(158, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 102);
            this.panel1.TabIndex = 7;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbID.Location = new System.Drawing.Point(158, 36);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(305, 22);
            this.tbID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(15, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã TK";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbQuyen);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(158, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 102);
            this.panel2.TabIndex = 8;
            // 
            // tbQuyen
            // 
            this.tbQuyen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbQuyen.Location = new System.Drawing.Point(158, 36);
            this.tbQuyen.Name = "tbQuyen";
            this.tbQuyen.Size = new System.Drawing.Size(305, 22);
            this.tbQuyen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã quyền";
            // 
            // fNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.pnPass);
            this.Controls.Add(this.pnNameLogin);
            this.Name = "fNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO TÀI KHOẢN MỚI";
            this.pnPass.ResumeLayout(false);
            this.pnPass.PerformLayout();
            this.pnNameLogin.ResumeLayout(false);
            this.pnNameLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel pnPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnNameLogin;
        private System.Windows.Forms.TextBox tbNameLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbQuyen;
        private System.Windows.Forms.Label label5;
    }
}