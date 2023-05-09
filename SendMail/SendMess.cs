using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SendMail
{
    public partial class SendMess : Form
    {
        public SendMess()
        {
            InitializeComponent();
        }

        string[] words;
        int count;

        private void send_Click(object sender, EventArgs e)
        {
            if(words is null)
            {
                MessageBox.Show("Почты не найдены!", "Ошибка");
            }
            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    MailAddress fromAddress = new MailAddress(Program.login, tb_nick.Text);
                    MailAddress toAdress = new MailAddress(words[i], Program.login);
                    MailMessage message = new MailMessage(fromAddress, toAdress);
                    message.Body = tb_msg.Text;
                    message.Subject = tb_tema.Text;

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Host = "smtp." + tb_url.Text;
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromAddress.Address, Program.password);

                    smtpClient.Send(message);

                    count++;
                    lcount.Text = "СЧЁТЧИК: " + count;
                }
                MessageBox.Show("Отправлено!");
            }
        }

        private void ms_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ms_login_Click(object sender, EventArgs e)
        {
            LogIn frm_lgn = new LogIn();
            frm_lgn.ShowDialog();
        }

        private void butcls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listmails_Click(object sender, EventArgs e)
        {
            OpenFileDialog openmails = new OpenFileDialog();

            if (openmails.ShowDialog() == DialogResult.OK)
            {
                words = File.ReadAllLines(openmails.FileName, Encoding.Default);
            }
        }

        private void mn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу написал - SergFras\nДата создания - 14.05.2020\nМой вк - vk.com/item_sergfras", "SergFras");
        }

        private void SendMess_Load(object sender, EventArgs e)
        {
            //lurl.Text = "URL:\n(вашей почты)\nmail.ru\nи т.д.";
            MessageBox.Show("Инструкция:" +
                "\n" +
                "\nЖелательно заполнить все поля ввода, " +
                "\nДля стабильной работы программы" +
                "\n" +
                "\nОбязательно авторизируйтесь во вкладке 'Авторизация'" +
                "\nВыберите список почт во вкладке 'Почты'" +
                "\nТема - тема сообщения" +
                "\nСообщение - само сообщение" +
                "\nНик - имя отправителя" +
                "\nИндекс - smtp адрес почты(вашей): mail.ru / gmail.com и т.д." +
                "\n" +
                "\nЕсли программа не работает:" +
                "\n" +
                "\nЗапустите от имени администратора" +
                "\nПроверьте поля ввода" +
                "\n" +
                "\n" +
                "\nЕсли не помогло - vk.com/item_sergfras", 
                "Инструкция");
        }
    }
}
