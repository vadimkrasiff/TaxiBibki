using Microsoft.Ajax.Utilities;
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
    public partial class CarCard : Form
    {
        private string imagePath = "";

        public CarCard()
        {
            InitializeComponent();
        }

        private void getCar()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select number, mark, photo, color from cars where number = @number limit 1";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@number", MySqlDbType.VarChar, 30);
            command.Parameters["@number"].Value = Store.currentCarId;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                numberBox.Text = reader["number"].ToString();
                markBox.Text = reader["mark"].ToString();
                colorBox.Text = reader["color"].ToString();
                imagePath = reader["photo"].ToString();


            }
            reader.Close();

            conn.Close();
            if (imagePath != "" && imagePath != null)
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CarCard_Load(object sender, EventArgs e)
        {
            if (Store.currentCarId != "")
            {
                submit.Text = "Сохранить";
                delete.Visible = true;
                getCar();
                numberBox.ReadOnly = true;
            }
            else
            {
                submit.Text = "Создать";
                delete.Visible = false;
            }
        }

        public void addCar()
        {
            MySqlConnection conn = MySQL.getConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO `cars` (`number`, `mark`, `color`, `photo`) VALUES (@number, @mark, @color, @photo);";

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@number", MySqlDbType.VarChar, 100);
                command.Parameters["@number"].Value = numberBox.Text;

                command.Parameters.Add("@mark", MySqlDbType.VarChar, 100);
                command.Parameters["@mark"].Value = markBox.Text;

                command.Parameters.Add("@color", MySqlDbType.VarChar, 100);
                command.Parameters["@color"].Value = colorBox.Text;

                command.Parameters.Add("@photo", MySqlDbType.Text);
                command.Parameters["@photo"].Value = imagePath;


                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Машина добавлена!", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backForm_Click(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        public void saveCar()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            try
            {
                string sql = "UPDATE `cars` SET `mark` =@mark,  `color` =@color,  `photo` = @photo WHERE `cars`.`number` = @number;";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
                command.Parameters.Add("@number", MySqlDbType.VarChar, 100);
                command.Parameters["@number"].Value = numberBox.Text;

                command.Parameters.Add("@mark", MySqlDbType.VarChar, 100);
                command.Parameters["@mark"].Value = markBox.Text;

                command.Parameters.Add("@color", MySqlDbType.VarChar, 100);
                command.Parameters["@color"].Value = colorBox.Text;

                command.Parameters.Add("@photo", MySqlDbType.Text);
                command.Parameters["@photo"].Value = imagePath;


                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Данные обновлены", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backForm_Click(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private void submit_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (numberBox.Text == "")
            {
                numberError.Visible = true;
                error = true;
            }
            else
            {
                numberError.Visible = false;
            }
            if (markBox.Text == "")
            {
                markError.Visible = true;
                error = true;
            }
            else
            {
                markError.Visible = false;
            }
            if (colorBox.Text == "")
            {
                colorError.Visible = true;
                error = true;

            }
            else
            {
                colorError.Visible = false;
            }
            if (imagePath == "")
            {
                photoError.Visible = true;
                error = true;
            }
            else
            {
                photoError.Visible = false;
            }
            if (!error)
            {
                if (Store.currentCarId != "")
                {
                    saveCar();

                }
                else
                {
                    addCar();
                }
            }
            error = false;
        }

        private void backForm_Click(object sender, EventArgs e)
        {
            Store.currentCarId = "";
            imagePath  = null;
            Admin newAdmin = new Admin();
            newAdmin.Show();
            Hide();
        }
        private void deleteClients()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "DELETE FROM `cars` WHERE `cars`.`number` = @number";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@number", MySqlDbType.VarChar, 30);
            command.Parameters["@number"].Value = Store.currentCarId;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Close();
            backForm_Click(new object(), new EventArgs());

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                deleteClients();
            }
        }

        private void uploadPhoto_Click(object sender, EventArgs e)
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
