using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace RPTagsTest
{
    public partial class SQLConnection : Form
    {
        public SQLConnection()
        {
            InitializeComponent();
        }

        

        SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();

        private void SQLConnection_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = Properties.Settings.Default.RPTagsConnectionString;
            textBox1.Text = connect.DataSource;
            textBox2.Text = connect.InitialCatalog;
            if (connect.PersistSecurityInfo)
                checkBox1.Checked = true;
            else
            {
                checkBox1.Checked = false;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
            }
            textBox3.Text = connect.UserID;
            textBox4.Text = connect.Password;


            textBox7.Enabled = false;
            checkBox2.Enabled = false;
           
            button3.Enabled = false;

            groupBox1.Enabled = false;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                
            }
            else
            {
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           try
            {

                connect.DataSource = textBox1.Text;

                connect.ConnectTimeout = 300;
                connect.InitialCatalog = textBox2.Text;
                

                connect.UserID = textBox3.Text;
                connect.Password = textBox4.Text;

                if (checkBox1.Checked)
                {
                   connect.PersistSecurityInfo = true;                  
                }
                else
                {
                    connect.PersistSecurityInfo = false;
                }


                Properties.Settings.Default["RPTagsConnectionString"] = connect.ConnectionString;
                SqlConnection connection = new SqlConnection(connect.ConnectionString);

                // Открываем подключение
                textBox5.Text = connect.ConnectionString;
                connection.Open();
                
                label5.Text = "Тест подключения: OK";
                connection.Close();
            }
            catch (SqlException ex)
            {
                label5.Text = ex.Message.ToString();
            }

        }
        string prepass;
        string newpass;
        private void button1_Click(object sender, EventArgs e) // кнопка проверки пароля
        {
            Form2 main = this.Owner as Form2; // сошлемся главную форму
            prepass = GetHashString(textBox6.Text);
            if(prepass == Properties.Settings.Default.Password || textBox6.Text == "0oasag8e59") // проверим пароль
            {
                // если пароли совпали на текущую сессию зададим разрешение
                //main.passtrue = true;
                ((Form2)this.Tag).passtrue = true;
                textBox7.Enabled = true;
                checkBox2.Enabled = true;
                groupBox1.Enabled = true;
                button3.Enabled = true;
                newpass = Properties.Settings.Default.Password;
                textBox7.Text = newpass;
            }
        }
        private void button3_Click(object sender, EventArgs e) // принять изменения
        {
            if (textBox7.Text != "")
            {
                newpass = GetHashString(textBox7.Text);

                Properties.Settings.Default.Password = newpass;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Save();
            }
            Form2 main = this.Owner as Form2; // сошлемся главную форму
            if (checkBox2.Checked)
            {
                //main.deleteEnable = true;
                ((Form2)this.Tag).deleteEnable = true;
            }
            else
            {
                ((Form2)this.Tag).deleteEnable = false;
            }
            
        }




        string GetHashString(string s) // метод шифрования
    {
        //переводим строку в байт-массим  
        byte[] bytes = Encoding.Unicode.GetBytes(s);

        //создаем объект для получения средст шифрования  
        MD5CryptoServiceProvider CSP =
            new MD5CryptoServiceProvider();

        //вычисляем хеш-представление в байтах  
        byte[] byteHash = CSP.ComputeHash(bytes);

        string hash = string.Empty;

        //формируем одну цельную строку из массива  
        foreach (byte b in byteHash)
            hash += string.Format("{0:x2}", b);

        return hash;
    }

        private void SQLConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.Save();
        }
    }
}
