namespace SendMail
{
    partial class SendMess
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
            this.send = new System.Windows.Forms.Button();
            this.ms_Files = new System.Windows.Forms.MenuStrip();
            this.ms_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_info = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_close = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_login = new System.Windows.Forms.ToolStripMenuItem();
            this.listmails = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd_mail = new System.Windows.Forms.OpenFileDialog();
            this.butcls = new System.Windows.Forms.Button();
            this.tb_tema = new System.Windows.Forms.TextBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.ltema = new System.Windows.Forms.Label();
            this.lmsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nick = new System.Windows.Forms.TextBox();
            this.lurl = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.lcount = new System.Windows.Forms.Label();
            this.ms_Files.SuspendLayout();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Acknowledge TT BRK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(202, 446);
            this.send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send.MinimumSize = new System.Drawing.Size(110, 37);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(275, 37);
            this.send.TabIndex = 0;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // ms_Files
            // 
            this.ms_Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ms_Files.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_file,
            this.ms_login,
            this.listmails});
            this.ms_Files.Location = new System.Drawing.Point(0, 0);
            this.ms_Files.Name = "ms_Files";
            this.ms_Files.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.ms_Files.Size = new System.Drawing.Size(1008, 26);
            this.ms_Files.TabIndex = 1;
            this.ms_Files.Text = "ListFiles";
            // 
            // ms_file
            // 
            this.ms_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ms_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_info,
            this.ms_close});
            this.ms_file.Font = new System.Drawing.Font("Acknowledge TT BRK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_file.ForeColor = System.Drawing.Color.White;
            this.ms_file.Name = "ms_file";
            this.ms_file.Size = new System.Drawing.Size(62, 22);
            this.ms_file.Text = "Файл";
            // 
            // mn_info
            // 
            this.mn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.mn_info.ForeColor = System.Drawing.Color.White;
            this.mn_info.Name = "mn_info";
            this.mn_info.Size = new System.Drawing.Size(180, 22);
            this.mn_info.Text = "Инфо";
            this.mn_info.Click += new System.EventHandler(this.mn_info_Click);
            // 
            // ms_close
            // 
            this.ms_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ms_close.Font = new System.Drawing.Font("Acknowledge TT BRK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_close.ForeColor = System.Drawing.Color.White;
            this.ms_close.Name = "ms_close";
            this.ms_close.Size = new System.Drawing.Size(180, 22);
            this.ms_close.Text = "Закрыть";
            this.ms_close.Click += new System.EventHandler(this.ms_close_Click);
            // 
            // ms_login
            // 
            this.ms_login.Font = new System.Drawing.Font("Acknowledge TT BRK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_login.ForeColor = System.Drawing.Color.White;
            this.ms_login.Name = "ms_login";
            this.ms_login.Size = new System.Drawing.Size(120, 22);
            this.ms_login.Text = "Авторизация";
            this.ms_login.Click += new System.EventHandler(this.ms_login_Click);
            // 
            // listmails
            // 
            this.listmails.Font = new System.Drawing.Font("Acknowledge TT BRK", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listmails.ForeColor = System.Drawing.Color.White;
            this.listmails.Name = "listmails";
            this.listmails.Size = new System.Drawing.Size(71, 22);
            this.listmails.Text = "Почты";
            this.listmails.Click += new System.EventHandler(this.listmails_Click);
            // 
            // ofd_mail
            // 
            this.ofd_mail.FileName = "OpenTxt";
            // 
            // butcls
            // 
            this.butcls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butcls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butcls.Font = new System.Drawing.Font("Acknowledge TT BRK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcls.Location = new System.Drawing.Point(509, 446);
            this.butcls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butcls.MinimumSize = new System.Drawing.Size(110, 37);
            this.butcls.Name = "butcls";
            this.butcls.Size = new System.Drawing.Size(275, 37);
            this.butcls.TabIndex = 2;
            this.butcls.Text = "Выход";
            this.butcls.UseVisualStyleBackColor = true;
            this.butcls.Click += new System.EventHandler(this.butcls_Click);
            // 
            // tb_tema
            // 
            this.tb_tema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_tema.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tema.ForeColor = System.Drawing.Color.White;
            this.tb_tema.Location = new System.Drawing.Point(284, 81);
            this.tb_tema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tema.Multiline = true;
            this.tb_tema.Name = "tb_tema";
            this.tb_tema.Size = new System.Drawing.Size(712, 25);
            this.tb_tema.TabIndex = 3;
            // 
            // tb_msg
            // 
            this.tb_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_msg.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_msg.ForeColor = System.Drawing.Color.White;
            this.tb_msg.Location = new System.Drawing.Point(284, 125);
            this.tb_msg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(712, 134);
            this.tb_msg.TabIndex = 4;
            // 
            // ltema
            // 
            this.ltema.AutoSize = true;
            this.ltema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ltema.Font = new System.Drawing.Font("Acknowledge TT BRK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltema.ForeColor = System.Drawing.Color.White;
            this.ltema.Location = new System.Drawing.Point(26, 81);
            this.ltema.Name = "ltema";
            this.ltema.Size = new System.Drawing.Size(70, 22);
            this.ltema.TabIndex = 5;
            this.ltema.Text = "ТЕМА:";
            // 
            // lmsg
            // 
            this.lmsg.AutoSize = true;
            this.lmsg.Font = new System.Drawing.Font("Acknowledge TT BRK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmsg.ForeColor = System.Drawing.Color.White;
            this.lmsg.Location = new System.Drawing.Point(73, 122);
            this.lmsg.Name = "lmsg";
            this.lmsg.Size = new System.Drawing.Size(144, 22);
            this.lmsg.TabIndex = 6;
            this.lmsg.Text = "СООБЩЕНИЕ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Acknowledge TT BRK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "НИК:";
            // 
            // tb_nick
            // 
            this.tb_nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_nick.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nick.ForeColor = System.Drawing.Color.White;
            this.tb_nick.Location = new System.Drawing.Point(284, 284);
            this.tb_nick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nick.Multiline = true;
            this.tb_nick.Name = "tb_nick";
            this.tb_nick.Size = new System.Drawing.Size(712, 25);
            this.tb_nick.TabIndex = 7;
            // 
            // lurl
            // 
            this.lurl.AutoSize = true;
            this.lurl.Font = new System.Drawing.Font("Acknowledge TT BRK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lurl.ForeColor = System.Drawing.Color.White;
            this.lurl.Location = new System.Drawing.Point(73, 326);
            this.lurl.Name = "lurl";
            this.lurl.Size = new System.Drawing.Size(99, 22);
            this.lurl.TabIndex = 10;
            this.lurl.Text = "ИНДЕКС:";
            // 
            // tb_url
            // 
            this.tb_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tb_url.Font = new System.Drawing.Font("Acknowledge TT BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.ForeColor = System.Drawing.Color.White;
            this.tb_url.Location = new System.Drawing.Point(284, 330);
            this.tb_url.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(712, 25);
            this.tb_url.TabIndex = 9;
            // 
            // lcount
            // 
            this.lcount.AutoSize = true;
            this.lcount.Font = new System.Drawing.Font("Acknowledge TT BRK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcount.Location = new System.Drawing.Point(26, 388);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(123, 22);
            this.lcount.TabIndex = 11;
            this.lcount.Text = "СЧЁТЧИК: ";
            // 
            // SendMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1008, 527);
            this.Controls.Add(this.lcount);
            this.Controls.Add(this.lurl);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nick);
            this.Controls.Add(this.lmsg);
            this.Controls.Add(this.ltema);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.tb_tema);
            this.Controls.Add(this.butcls);
            this.Controls.Add(this.send);
            this.Controls.Add(this.ms_Files);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MainMenuStrip = this.ms_Files;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(1024, 566);
            this.MinimumSize = new System.Drawing.Size(1024, 566);
            this.Name = "SendMess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMail";
            this.Load += new System.EventHandler(this.SendMess_Load);
            this.ms_Files.ResumeLayout(false);
            this.ms_Files.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.MenuStrip ms_Files;
        private System.Windows.Forms.ToolStripMenuItem ms_file;
        private System.Windows.Forms.ToolStripMenuItem ms_close;
        private System.Windows.Forms.ToolStripMenuItem ms_login;
        private System.Windows.Forms.ToolStripMenuItem listmails;
        private System.Windows.Forms.OpenFileDialog ofd_mail;
        private System.Windows.Forms.Button butcls;
        private System.Windows.Forms.TextBox tb_tema;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Label ltema;
        private System.Windows.Forms.Label lmsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nick;
        private System.Windows.Forms.Label lurl;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.ToolStripMenuItem mn_info;
        private System.Windows.Forms.Label lcount;
    }
}