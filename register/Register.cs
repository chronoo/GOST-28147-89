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

namespace register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public class Account
        {
            public string Login { get; set;}
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Hash { get; set; } 
        }
        Hash coder = new Hash();
        private void button1_Click(object sender, EventArgs e)
        {
            if(login.Text=="" && password.Text=="")
                statusText.Text = "Введите логин и пароль";
            else if (login.Text == "")
                statusText.Text = "Введите логин";
            else if (password.Text == "")
                statusText.Text = "Введите пароль";
			else if(password.Text!=password2.Text)
				statusText.Text = "Введите одинаковые пароли";
			if (login.Text == "" || password.Text == "" || password.Text != password2.Text) 
                return;

            foreach(Account user in list)
            {
                if(user.Login==login.Text)
                {
                    statusText.Text = "Пользовтель уже существует";
                    return;
                }
            }
            Account NewAccount = new Account();
            NewAccount.Login = login.Text;
            string Password = password.Text;
            NewAccount.Email = email.Text;
            NewAccount.FirstName = firstName.Text;
            NewAccount.LastName = lastName.Text;
            NewAccount.Phone = phone.Text;
            NewAccount.Address = address.Text;
            string AccountInfo=NewAccount.Login+Password+NewAccount.Email+ NewAccount.FirstName+NewAccount.LastName+NewAccount.Phone+NewAccount.Address;
            NewAccount.Hash=coder.GOST(AccountInfo);
            list.Add(NewAccount);
            using (FileStream fs = new FileStream(@"D:\prog\gost 0.2\users.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(list.GetType());
                x.Serialize(fs, list);
            }
            Close();
        }
        List<Account> list = new List<Account>();
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(@"D:\prog\gost 0.2\users.txt")) return;
            using (FileStream fs = new FileStream(@"D:\prog\gost 0.2\users.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(list.GetType());
                list=x.Deserialize(fs) as List<Account>;
                int a;
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
			if (password.PasswordChar == '*')
				password.PasswordChar = '\0';
			else password.PasswordChar = '*';
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (password2.PasswordChar == '*')
				password2.PasswordChar = '\0';
			else password2.PasswordChar = '*';
		}

		private void password_Click(object sender, EventArgs e)
		{
			password.PasswordChar = '*';
		}

		private void password2_Click(object sender, EventArgs e)
		{
			password2.PasswordChar = '*';
		}
    }
}
