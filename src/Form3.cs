using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Version1
{
    [Serializable()]
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person(textBox2.Text, textBox3.Text,textBox4.Text,textBox5.Text);
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new Files("Data.dat").FileStreamCreate())
            {
                formatter.Serialize(fs, person);
                fs.Close();
            }
            this.Hide();
            Form2 f = new Form2();
            f.Show();
            f.Welcome();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
    [Serializable()]
    class Person 
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Person(string name, string login, string password, string email)
        {
            Name = name;
            Login = login;
            Email = email;
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                Password = sb.ToString();
            }
            
          
        }
    }
}
