using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            tb_pwd.PasswordChar = '*';
        }


        private void okey_Click(object sender, EventArgs e)
        {
            Program.login = tb_lgn.Text;
            Program.password = tb_pwd.Text;

            File.WriteAllText("C:\\Windows\\pwds.txt", Program.password);
            File.WriteAllText("C:\\Windows\\lgns.txt", Program.login);

            this.Close();
        }

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Windows\\lgns.txt"))
            {
                tb_lgn.Text = File.ReadAllText("C:\\Windows\\lgns.txt");
                tb_pwd.Text = File.ReadAllText("C:\\Windows\\pwds.txt");
                Program.login = File.ReadAllText("C:\\Windows\\lgns.txt");
                Program.password = File.ReadAllText("C:\\Windows\\pwds.txt");
            }
        }
    }
}
