using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiBibki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string CalculateSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Вы не ввели логин/пароль!", "Ошибка");
            }
            else
            {
                MySqlConnection conn = MySQL.getConnection();
                try
                {
                    conn.Open();
                    string sql = "select password, post, id, last_name, first_name from users where username = @login limit 1;";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add("@login", MySqlDbType.VarChar, 30);
                    command.Parameters["@login"].Value = login.Text;
                    string password_u = "";
                    string post = "";
                    string id = "";
                    string fullname = "";
                    string hashedInputPassword = CalculateSHA256Hash(password.Text);

                    if (command.ExecuteScalar() != null)
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                password_u = reader.GetString("password");
                                post = reader.GetString("post");
                                id = reader.GetString("id");
                                fullname = reader.GetString("last_name") + " " + reader.GetString("first_name");
                            }
                        }
                        if (string.Equals(password_u, hashedInputPassword))
                        {
                            MessageBox.Show("Вы вошли");
                            Store.userId = id;
                            Store.userPost = post;
                            Store.userName = fullname;
                            if (post == "администратор")
                            {
                                Admin newAdmin = new Admin();
                                newAdmin.Show();
                            } else if (post == "диспетчер") {
                            } else if (post == "водитель") {
                            } else
                            {
                                MessageBox.Show("У вас нет доступа!", "Ошибка");
                            }

                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Не верный пароль!", "Ошибка");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не верный логин!", "Ошибка");
                    }
                    conn.Close(); // Закрываем соединение
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
    }
}
