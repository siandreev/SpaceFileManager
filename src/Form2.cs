using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Version1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Welcome();
            }
            catch { }
            string check = "";

            try
            {
                if (new Files("Data.dat").Exist())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (var fs = new Files("Data.dat").FileStreamCreate())
                    {
                        Person newPerson = (Person)formatter.Deserialize(fs);
                        check = newPerson.Name;
                        fs.Close();

                    }
                }
            }
            catch { } 
            if (check == "")
            {
                Form3 form = new Form3();
                this.Hide();
                form.Show();
            }
        }

        public void Welcome()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new Files("Data.dat").FileStreamCreate())
            {
                Person newPerson = (Person)formatter.Deserialize(fs);
                username.Text = newPerson.Name;
                fs.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new Files("Data.dat").FileStreamCreate())
            {
                Person newPerson = (Person)formatter.Deserialize(fs);
                string login = newPerson.Login;
                string password = newPerson.Password;
                string userMail = newPerson.Email;
                string userName = newPerson.Name;
                string SecretCode = "";
                fs.Close();



            MailAddress from = new MailAddress("SpaceFileManager@yandex.ru", "SpaceFileManager");
            MailAddress to = new MailAddress(userMail);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "PASSWORD RECOVERY";
            m.Body = "<h2>" + userName + "'s user data for entering the SpasFileManager: LOGIN = " + login + "  PASSWORD = " + password;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            smtp.Credentials = new NetworkCredential("SpaceFileManager", "suxhupmszwxjzofc");
            smtp.EnableSsl = true;
            try
            {
                MessageBox.Show("Check your e-mail and copy code to this window");
                smtp.Send(m);
                InputBox.InputBox inputBox = new InputBox.InputBox();
                SecretCode = inputBox.getString();
                if (SecretCode == password)
                    {
                        MessageBox.Show("Your account settings has been deleted");
                        new Files("Data.dat").Delete();
                        this.Close();
                    }
                else
                    {
                        MessageBox.Show("Incorrect code");
                    }

                }
            catch { MessageBox.Show("Operation failed. Please check your internet connection and try again later."); }
        }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new Files("Data.dat").FileStreamCreate())
            {
                Person newPerson = (Person)formatter.Deserialize(fs);
                string login = newPerson.Login;
                string password = newPerson.Password;
                string CurrentPassword;

                using (SHA1Managed sha1 = new SHA1Managed())
                {
                    var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(textBox2.Text));
                    var sb = new StringBuilder(hash.Length * 2);

                    foreach (byte b in hash)
                    {
                        sb.Append(b.ToString("X2"));
                    }
                    CurrentPassword = sb.ToString();
                }

                if (textBox1.Text == login && CurrentPassword == password)
                {

                    this.Hide();
                    Form1 mainform = new Form1();
                    mainform.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect login or password");
                }
            }
          
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
