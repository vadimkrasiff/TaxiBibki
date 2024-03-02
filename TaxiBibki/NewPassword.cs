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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaxiBibki
{
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }


        private string CalculateSHA256Hash(string input)
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

        private bool savePassword ()
        {
            MySqlConnection conn = MySQL.getConnection();
            try
            {
                conn.Open();
                string sql = "select password from users where id = @id limit 1;";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
                command.Parameters["@id"].Value = Store.currentClientId;
                string password_u = "";

                string hashedInputPassword = CalculateSHA256Hash(OldPassword.Text);

                bool result = false;
                if (command.ExecuteScalar() != null)
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            password_u = reader.GetString("password");
                        }
                    }
                    if (string.Equals(password_u, hashedInputPassword))
                    {
                        result = true;
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
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "savePassword");
                return false;

            }

        }

        public void updatePassword()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `users` SET `password` =@password WHERE `users`.`id` = @id;";

            MySqlCommand command = new MySqlCommand(sql, conn);


            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentClientId;

            command.Parameters.Add("@password", MySqlDbType.VarChar, 20);
            command.Parameters["@password"].Value = newPasword.Text;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Пароль обновлен", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (OldPassword.Text == "")
            {
                oldPasswordError.Visible = true;
                error = true;

            }
            else
            {
                oldPasswordError.Visible = false;
            }
            if (OldPassword.Text == "")
            {
                oldPasswordError.Visible = true;
                error = true;

            }
            else
            {
                oldPasswordError.Visible = false;
            }
            if (!error)
            {
                if (savePassword())
                {
                    updatePassword();
                }
            }
            error = false;
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
