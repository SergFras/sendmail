namespace SendMail
{
    partial class LogIn
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
            this.tb_lgn = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.llgn = new System.Windows.Forms.Label();
            this.lpwd = new System.Windows.Forms.Label();
            this.okey = new System.Windows.Forms.Button();
            this.butclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_lgn
            // 
            this.tb_lgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_lgn.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lgn.ForeColor = System.Drawing.Color.White;
            this.tb_lgn.Location = new System.Drawing.Point(120, 20);
            this.tb_lgn.Multiline = true;
            this.tb_lgn.Name = "tb_lgn";
            this.tb_lgn.Size = new System.Drawing.Size(137, 25);
            this.tb_lgn.TabIndex = 0;
            // 
            // tb_pwd
            // 
            this.tb_pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_pwd.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pwd.ForeColor = System.Drawing.Color.White;
            this.tb_pwd.Location = new System.Drawing.Point(120, 66);
            this.tb_pwd.Multiline = true;
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(137, 25);
            this.tb_pwd.TabIndex = 1;
            // 
            // llgn
            // 
            this.llgn.AutoSize = true;
            this.llgn.Font = new System.Drawing.Font("Acknowledge TT BRK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llgn.ForeColor = System.Drawing.Color.White;
            this.llgn.Location = new System.Drawing.Point(12, 23);
            this.llgn.Name = "llgn";
            this.llgn.Size = new System.Drawing.Size(61, 18);
            this.llgn.TabIndex = 2;
            this.llgn.Text = "Логин:";
            // 
            // lpwd
            // 
            this.lpwd.AutoSize = true;
            this.lpwd.Font = new System.Drawing.Font("Acknowledge TT BRK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpwd.ForeColor = System.Drawing.Color.White;
            this.lpwd.Location = new System.Drawing.Point(12, 69);
            this.lpwd.Name = "lpwd";
            this.lpwd.Size = new System.Drawing.Size(73, 18);
            this.lpwd.TabIndex = 3;
            this.lpwd.Text = "Пароль:";
            // 
            // okey
            // 
            this.okey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okey.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okey.Location = new System.Drawing.Point(51, 127);
            this.okey.Name = "okey";
            this.okey.Size = new System.Drawing.Size(100, 30);
            this.okey.TabIndex = 4;
            this.okey.Text = "Принять";
            this.okey.UseVisualStyleBackColor = true;
            this.okey.Click += new System.EventHandler(this.okey_Click);
            // 
            // butclose
            // 
            this.butclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butclose.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclose.Location = new System.Drawing.Point(157, 127);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(100, 30);
            this.butclose.TabIndex = 5;
            this.butclose.Text = "Отмена";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(269, 171);
            this.Controls.Add(this.butclose);
            this.Controls.Add(this.okey);
            this.Controls.Add(this.lpwd);
            this.Controls.Add(this.llgn);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_lgn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(285, 210);
            this.MinimumSize = new System.Drawing.Size(285, 210);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label llgn;
        private System.Windows.Forms.Label lpwd;
        private System.Windows.Forms.TextBox tb_lgn;
        private System.Windows.Forms.Button okey;
        private System.Windows.Forms.Button butclose;
    }
}