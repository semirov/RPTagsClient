using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
