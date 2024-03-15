﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiBibki
{
    public partial class OperatorCard : Form
    {
        private string imagePath = "";

        public OperatorCard()
        {
            InitializeComponent();
        }

        private void OperatorCard_Load(object sender, EventArgs e)
        {
            if (Store.currentClientId != "")
            {
                button1.Text = "Сохранить";
                button3.Visible = true;
                password.Visible = false;
                label5.Visible = false;
                passwordError.Visible = false;
                updatePassword.Visible = true;
                getOperator();
            }
            else
            {
                label5.Visible = true;
                updatePassword.Visible = false;
                passwordError.Visible = false;
                password.Visible = true;
                button1.Text = "Создать";
                button3.Visible = false;
            }
        }

        private void getOperator()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select first_name, last_name, username, avatar, phone from users where id = @id limit 1";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentClientId;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["first_name"].ToString();
                textBox2.Text = reader["last_name"].ToString();
                textBox3.Text = reader["username"].ToString();
                maskedTextBox1.Text = reader["phone"].ToString();
                imagePath = reader["avatar"].ToString();


            }
            reader.Close();

            conn.Close();
            if (imagePath != "" && imagePath != null)
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        public void addOperator()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "INSERT INTO `users` (`last_name`, `first_name`, `username`, password, `phone`, post, avatar) VALUES (@last_name, @first_name, @username, @password, @phone, 'диспетчер', @avatar);";

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@last_name", MySqlDbType.VarChar, 40);
            command.Parameters["@last_name"].Value = textBox1.Text;

            command.Parameters.Add("@first_name", MySqlDbType.VarChar, 40);
            command.Parameters["@first_name"].Value = textBox2.Text;

            command.Parameters.Add("@phone", MySqlDbType.VarChar, 20);
            command.Parameters["@phone"].Value = maskedTextBox1.Text;

            command.Parameters.Add("@username", MySqlDbType.VarChar, 50);
            command.Parameters["@username"].Value = textBox3.Text;

            command.Parameters.Add("@password", MySqlDbType.VarChar, 50);
            command.Parameters["@password"].Value = password.Text;

            command.Parameters.Add("@avatar", MySqlDbType.Text);
            command.Parameters["@avatar"].Value = imagePath;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Данные добавлены!", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button4_Click(new object(), new EventArgs());
        }

        public void saveOperator()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `users` SET `last_name` =@last_name,  `first_name` =@first_name, avatar=@avatar,  `username` = @username,  `phone` = @phone WHERE `users`.`id` = @id;";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentClientId;

            command.Parameters.Add("@last_name", MySqlDbType.VarChar, 40);
            command.Parameters["@last_name"].Value = textBox1.Text;

            command.Parameters.Add("@first_name", MySqlDbType.VarChar, 30);
            command.Parameters["@first_name"].Value = textBox2.Text;

            command.Parameters.Add("@phone", MySqlDbType.VarChar, 20);
            command.Parameters["@phone"].Value = maskedTextBox1.Text;

            command.Parameters.Add("@username", MySqlDbType.VarChar, 20);
            command.Parameters["@username"].Value = textBox3.Text;

            command.Parameters.Add("@avatar", MySqlDbType.Text);
            command.Parameters["@avatar"].Value = imagePath;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Данные обновлены", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button4_Click(new object(), new EventArgs());
        }

        private void deleteOperator()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "DELETE FROM `users` WHERE `users`.`id` = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentClientId;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Close();
            button4_Click(new object(), new EventArgs());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Store.currentClientId = "";
            Admin newAdmin = new Admin();
            newAdmin.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (textBox2.Text == "")
            {
                surnameError.Visible = true;
                error = true;
            }
            else
            {
                surnameError.Visible = false;
            }
            if (textBox1.Text == "")
            {
                NameError.Visible = true;
                error = true;

            }
            else
            {
                NameError.Visible = false;
            }
            if (textBox3.Text == "")
            {
                usernameError.Visible = true;
                error = true;

            }
            else
            {
                usernameError.Visible = false;
            }
            if (maskedTextBox1.Text.Length != 11)
            {
                phoneError.Visible = true;
                error = true;
            }
            else
            {
                phoneError.Visible = false;
            }
            if (Store.currentClientId == "") {
                if (password.Text == "")
                {
                    passwordError.Visible = true;
                    error = true;
                }
                else
                {
                    passwordError.Visible = false;
                }
            }
            if (!error)
            {
                if (Store.currentClientId != "")
                {
                    saveOperator();

                }
                else
                {
                    addOperator();

                }
            }
            error = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deleteOperator();
            }
        }

        private void updatePassword_Click(object sender, EventArgs e)
        {
            NewPassword newPassword = new NewPassword();
            newPassword.Show();
        }

        private void photoError_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Фильтр для отображения только изображений
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный путь к файлу
                imagePath = openFileDialog.FileName;

                // Отображаем изображение на PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
