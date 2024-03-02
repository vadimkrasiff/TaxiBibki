using MySql.Data.MySqlClient;
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
    public partial class DriverCard : Form
    {
        public DriverCard()
        {
            InitializeComponent();
        }

        private void DriverCard_Load(object sender, EventArgs e)
        {
            getCars();
            if (Store.currentClientId != "")
            {
                button1.Text = "Сохранить";
                button3.Visible = true;
                password.Visible = false;
                label5.Visible = false;
                passwordError.Visible = false;
                updatePassword.Visible = true;
                getDriver();
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

        private void getDriver()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select first_name, last_name, username, car_number, phone from users where id = @id limit 1";
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
                comboBox1.Text = reader["car_number"].ToString();

            }
            reader.Close();

            conn.Close();
        }

        private void getCars()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "SELECT DISTINCT cars.number FROM cars LEFT JOIN users ON cars.number = users.car_number WHERE users.car_number IS NULL UNION SELECT cars.number FROM cars INNER JOIN users ON cars.number = users.car_number WHERE users.id = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentClientId;

            MySqlDataReader reader = command.ExecuteReader();
            List<string> cars = new List<string>();
            while (reader.Read())
            {
                cars.Add(reader["number"].ToString());
            }
            reader.Close();

            conn.Close();
            comboBox1.DataSource = cars;

        }

        public void addDriver()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "INSERT INTO `users` (`last_name`, `first_name`, `username`, password, `phone`, car_number, post) VALUES (@last_name, @first_name, @username, @password, @phone, @car_number, 'водитель');";

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

            command.Parameters.Add("@car_number", MySqlDbType.VarChar, 50);
            command.Parameters["@car_number"].Value = comboBox1.Text;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Данные добавлены!", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button4_Click(new object(), new EventArgs());
        }

        public void saveDriver()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `users` SET `last_name` =@last_name,  `first_name` =@first_name,  `username` = @username, car_number=@car_number,  `phone` = @phone WHERE `users`.`id` = @id;";

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

            command.Parameters.Add("@car_number", MySqlDbType.VarChar, 50);
            command.Parameters["@car_number"].Value = comboBox1.Text;

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
            if (comboBox1.Text == "")
            {
                carError.Visible = true;
                error = true;
            }
            else
            {
                carError.Visible = false;
            }
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
            if (Store.currentClientId == "")
            {
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
                    saveDriver();

                }
                else
                {
                    addDriver();

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
    }
}
