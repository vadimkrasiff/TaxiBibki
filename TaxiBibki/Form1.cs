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
                    string sql = "SELECT u.password, u.post, u.id, u.last_name, u.first_name, s.finish_date, s.start_date FROM users u LEFT JOIN shift s ON u.id = s.user_id AND s.finish_date >= NOW() AND s.start_date <= NOW() WHERE u.username = @login LIMIT 1;";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add("@login", MySqlDbType.VarChar, 30);
                    command.Parameters["@login"].Value = login.Text;
                    string password_u = "";
                    string post = "";
                    string id = "";
                    string fullname = "";
                    string startDate = "";
                    string finishDate = "";
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
                                startDate = reader["start_date"].ToString();
                                finishDate = reader["finish_date"].ToString();

                            }
                        }
                        if (string.Equals(password_u, hashedInputPassword))
                        {
                            
                            Store.userId = id;
                            Store.userPost = post;
                            Store.userName = fullname;
                            if ((startDate != "" && finishDate != "") || post == "администратор")
                            {
                                MessageBox.Show("Вы вошли");
                                if (post == "администратор")
                                {
                                    Admin newAdmin = new Admin();
                                    newAdmin.Show();
                                }
                                else if (post == "диспетчер")
                                {
                                    Operator newOperator = new Operator();
                                    newOperator.Show();
                                }
                                else if (post == "водитель")
                                {
                                    Driver newDriver = new Driver();
                                    newDriver.Show();
                                }
                                else
                                {
                                    MessageBox.Show("У вас нет доступа!", "Ошибка");
                                }

                                Hide();
                            } else
                            {
                                MessageBox.Show("Не ваша смена!\rУ вас нет доступа!", "Ошибка");
                            }
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
