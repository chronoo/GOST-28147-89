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
    public partial class Form1 : Form
    {
        Hash coder=new Hash();
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {            
            string pass = password.Text;
            string log = login.Text;
            string status="";
            int validCode=valid(log, pass);
            switch (validCode)
            {
                case 1: status = "Неверный пароль"; break;
                case 2: status = "Пользователя не существует"; break;
                default: 
                    Comparator Form3 = new Comparator();
                    Form3.Show();
                    //status = "Вход выполнен"; 
                    break;
            }
            statusTex.Text = status;
           /* if () MessageBox.Show("Вход успешно завершён");
            else MessageBox.Show("Вход не выполнен");*/
        }
        private void btReg_Click(object sender, EventArgs e)
        {
            Register Form3 = new Register();
            Form3.Show();
        }
        public int valid(string log, string pass) {
            List<Register.Account> list=new List<Register.Account>();
            if (!File.Exists(@"D:\prog\gost 0.2\users.txt")) return 2;
            using (FileStream fs = new FileStream(@"D:\prog\gost 0.2\users.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(list.GetType());
                list=x.Deserialize(fs) as List<Register.Account>;
            }
            foreach(Register.Account User in list)
            {
                if (User.Login == log)
                {
                    string query = coder.GOST(log + pass + User.Email + User.FirstName + User.LastName + User.Phone + User.Address);
                    if(query==User.Hash)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            return 2;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			if (password.PasswordChar == '*')
				password.PasswordChar = '\0';
			else password.PasswordChar = '*';
		}

		private void password_TextChanged(object sender, EventArgs e)
		{
			password.PasswordChar = '*';
		}

		private void password_Click(object sender, EventArgs e)
		{
			password.PasswordChar = '*';
		}
    }
}
