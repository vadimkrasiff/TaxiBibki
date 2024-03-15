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
using static TaxiBibki.Order;

namespace TaxiBibki
{
    public partial class Shift : Form
    {
        public Shift()
        {
            InitializeComponent();
        }

        private void backForm_Click(object sender, EventArgs e)
        {
            Store.currentShiftId = "";
            Admin newAdmin = new Admin();
            newAdmin.Show();
            Hide();
        }

        private void getUsers()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select id, last_name, first_name from users where post IS NOT NULL";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<ClientObject> clientList = new List<ClientObject>();
            while (reader.Read())
            {
                string idClient = reader["id"].ToString();
                string fullnameClient = reader["last_name"].ToString() + " " + reader["first_name"].ToString();
                clientList.Add(new ClientObject(idClient, fullnameClient));
            }
            reader.Close();

            conn.Close();
            userBox.DataSource = clientList;
            userBox.ValueMember = "Value";
            userBox.DisplayMember = "DisplayText";
        }

        private void getShift()
        {
            MySqlConnection conn = MySQL.getConnection();

            try
            {
                conn.Open();
                string sql = "SELECT s.id as id, s.user_id as user_id, s.start_date as start_date, s.finish_date as finish_date, c.first_name as first_name, c.last_name as last_name FROM `shift` as s, users as c WHERE s.user_id = c.id and s.id = @id";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
                command.Parameters["@id"].Value = Store.currentShiftId;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string fullnameUser = reader["last_name"].ToString() + " " + reader["first_name"].ToString();

                    userBox.Text = fullnameUser;
                    startDate.Value = (DateTime)reader["start_date"];
                    finishDate.Value = (DateTime)reader["finish_date"];
                }
                reader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            getUsers();

            if (Store.currentShiftId != "")
            {
                getShift();
            }
            else
            {
                submit.Text = "Создать";
                delete.Visible = false;
            }
        }
        public void saveShift()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `shift` SET `user_id` =@user_id, `start_date` =@start_date, `finish_date` =@finish_date WHERE `shift`.`id` = @id;";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentShiftId;

            command.Parameters.Add("@user_id", MySqlDbType.VarChar, 40);
            command.Parameters["@user_id"].Value = ((ClientObject)userBox.SelectedItem).Value;

            command.Parameters.Add("@start_date", MySqlDbType.DateTime);
            command.Parameters["@start_date"].Value = startDate.Value;

            command.Parameters.Add("@finish_date", MySqlDbType.DateTime);
            command.Parameters["@finish_date"].Value = finishDate.Value;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Смена обновлена", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            backForm_Click(new object(), new EventArgs());
        }

        public void addShift()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "INSERT INTO `shift` (`user_id`, `start_date`, `finish_date`) VALUES (@user_id, @start_date, @finish_date)";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@user_id", MySqlDbType.VarChar, 40);
            command.Parameters["@user_id"].Value = ((ClientObject)userBox.SelectedItem).Value;

            command.Parameters.Add("@start_date", MySqlDbType.DateTime);
            command.Parameters["@start_date"].Value = startDate.Value;

            command.Parameters.Add("@finish_date", MySqlDbType.DateTime);
            command.Parameters["@finish_date"].Value = finishDate.Value;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Смена обновлена", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            backForm_Click(new object(), new EventArgs());
        }

        private void deleteShift()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "DELETE FROM `shift` WHERE `shift`.`id` = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentShiftId;
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
                deleteShift();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (userBox.Text == "")
            {
                userError.Visible = true;
                error = true;
            }
            else
            {
                userError.Visible = false;
            }
            if (startDate.Text == "")
            {
                startShiftError.Visible = true;
                error = true;
            }
            else
            {
                startShiftError.Visible = false;
            }
            if (finishDate.Text == "")
            {
                finishShiftError.Visible = true;
                error = true;
            }
            else
            {
                finishShiftError.Visible = false;
            }
            if (!error)
            {
                if (Store.currentShiftId != "")
                {
                    saveShift();
                }
                else
                {
                    addShift();
                }
            }
            error = false;
        }
    }
}
