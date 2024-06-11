namespace QLBANHANG
{
    partial class fLogin
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
            this.pnNameLogin = new System.Windows.Forms.Panel();
            this.tbNameLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPass = new System.Windows.Forms.Panel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnNameLogin.SuspendLayout();
            this.pnPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNameLogin
            // 
            this.pnNameLogin.Controls.Add(this.tbNameLogin);
            this.pnNameLogin.Controls.Add(this.label1);
            this.pnNameLogin.Location = new System.Drawing.Point(22, 115);
            this.pnNameLogin.Name = "pnNameLogin";
            this.pnNameLogin.Size = new System.Drawing.Size(485, 102);
            this.pnNameLogin.TabIndex = 0;
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
            // pnPass
            // 
            this.pnPass.Controls.Add(this.tbPass);
            this.pnPass.Controls.Add(this.label2);
            this.pnPass.Location = new System.Drawing.Point(22, 223);
            this.pnPass.Name = "pnPass";
            this.pnPass.Size = new System.Drawing.Size(485, 102);
            this.pnPass.TabIndex = 2;
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
            // btLogin
            // 
            this.btLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btLogin.Location = new System.Drawing.Point(22, 351);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(330, 60);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btExit.Location = new System.Drawing.Point(358, 351);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(149, 60);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(143, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(530, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.pnPass);
            this.Controls.Add(this.pnNameLogin);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.pnNameLogin.ResumeLayout(false);
            this.pnNameLogin.PerformLayout();
            this.pnPass.ResumeLayout(false);
            this.pnPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnNameLogin;
        private System.Windows.Forms.TextBox tbNameLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label3;
    }
}