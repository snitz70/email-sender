using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Email_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(textBoxEmail.Text);
            message.Subject = textBoxSubject.Text;
            message.Body = textBoxBody.Text;
            foreach (string s in textBoxName.Text.Split(';'))
            {
                message.To.Add(s);
            }
        }
    }
}
