using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Avalonia;

namespace TaxiBibki
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        public class ClientObject
        {
            public string Value { get; set; }
            public string DisplayText { get; set; }

            public ClientObject(string value, string displayText)
            {
                Value = value;
                DisplayText = displayText;
            }

            // Переопределение метода ToString для вывода текста в ComboBox
            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void getOrder()
        {
            MySqlConnection conn = MySQL.getConnection();

            try
            {
                conn.Open();
                string sql = "SELECT o.id as id, o.sum as sum, o.description as description, o.finish_point as finish_point, o.start_point as start_point, o.status as status, c.first_name as client_first_name, c.last_name as client_last_name, d.first_name as driver_first_name, d.last_name as driver_last_name, d.id as driver_id FROM `orders` as o LEFT JOIN users as c ON o.client_id = c.id LEFT JOIN users as d ON o.user_id = d.id WHERE o.id = @id LIMIT 1;";

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
                command.Parameters["@id"].Value = Store.currentOrderId;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {   
                    if(reader["status"].ToString() == "отказ" || reader["status"].ToString() == "готово") {
                        statusBox.Enabled = false;
                        delete.Visible = false;

                    }
                    if (reader["status"].ToString() != "заявка" && reader["status"].ToString() != "оформлено")
                    {
                        firstPoint.Enabled = false;
                        finishPoint.Enabled = false;
                        sumBox.Enabled = false;
                        statusBox.Enabled = false;
                    }
                    if (Store.userPost == "водитель")
                    {
                        if (reader["driver_id"].ToString() != Store.userId && reader["driver_id"].ToString() != "")
                        {
                            delete.Visible = false;
                        }
                        if (reader["driver_id"].ToString() == "")
                        {
                            button1.Visible = true;
                            delete.Visible = false;

                        }
                        if (reader["driver_id"].ToString() == Store.userId)
                        {
                            button2.Visible= true;
                        }

                    }

                    string fullnameClient = reader["client_last_name"].ToString() + " " + reader["client_first_name"].ToString();

                    clientBox.Text = fullnameClient;
                    driverBox.Text = reader["driver_last_name"].ToString() + reader["driver_first_name"].ToString();

                    statusBox.Text = reader["status"].ToString();
                    sumBox.Text = reader["sum"].ToString();
                    descriptionBox.Text = reader["description"].ToString();
                    finishPoint.Text = reader["finish_point"].ToString();
                    firstPoint.Text = reader["start_point"].ToString();

                }
                reader.Close();

                conn.Close();
               }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        

        private void getClients()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select id, last_name, first_name from users where post IS NULL";
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
            clientBox.DataSource = clientList;
            clientBox.ValueMember = "Value";
            clientBox.DisplayMember = "DisplayText";
        }

        public void saveOrder()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `orders` SET `client_id` =@client_id, `description` =@description, `sum` =@sum, `status` =@status,  `start_point` = @start_point, `finish_point` = @finish_point WHERE `orders`.`id` = @id;";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentOrderId;

            command.Parameters.Add("@client_id", MySqlDbType.VarChar, 40);
            command.Parameters["@client_id"].Value = ((ClientObject)clientBox.SelectedItem).Value;

            command.Parameters.Add("@status", MySqlDbType.VarChar, 30);
            command.Parameters["@status"].Value = statusBox.Text;

            command.Parameters.Add("@sum", MySqlDbType.Float, 20);
            command.Parameters["@sum"].Value = sumBox.Value;

            command.Parameters.Add("@start_point", MySqlDbType.VarChar, 100);
            command.Parameters["@start_point"].Value = firstPoint.Text;
            
            command.Parameters.Add("@finish_point", MySqlDbType.VarChar, 100);
            command.Parameters["@finish_point"].Value = finishPoint.Text;

            command.Parameters.Add("@description", MySqlDbType.Text);
            command.Parameters["@description"].Value = descriptionBox.Text;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ обновлен", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            backForm_Click(new object(), new EventArgs());
        }


        public void addOrder()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "INSERT INTO `orders` (`client_id`, `description`, `sum`, `status`,  `start_point`, `finish_point`) VALUES (@client_id, @description, @sum, @status, @start_point, @finish_point)";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentOrderId;

            command.Parameters.Add("@client_id", MySqlDbType.VarChar, 40);
            command.Parameters["@client_id"].Value = ((ClientObject)clientBox.SelectedItem).Value;

            command.Parameters.Add("@status", MySqlDbType.VarChar, 30);
            command.Parameters["@status"].Value = statusBox.Text;

            command.Parameters.Add("@sum", MySqlDbType.Float);
            command.Parameters["@sum"].Value = sumBox.Value;

            command.Parameters.Add("@start_point", MySqlDbType.VarChar, 100);
            command.Parameters["@start_point"].Value = firstPoint.Text;

            command.Parameters.Add("@finish_point", MySqlDbType.VarChar, 100);
            command.Parameters["@finish_point"].Value = finishPoint.Text;

            command.Parameters.Add("@description", MySqlDbType.Text);
            command.Parameters["@description"].Value = descriptionBox.Text;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ оформлен", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            backForm_Click(new object(), new EventArgs());
        }

        private void Order_Load(object sender, EventArgs e)
        {
            if (Store.currentOrderId != "")
            {
                clientBox.Enabled = false;
                
            } else
            {
                delete.Visible = false;
                submit.Text = "Создать";
            }
            getClients();
            getOrder();
            if (Store.userPost == "водитель") {

                submit.Visible = false;
                descriptionBox.Enabled = false;
                statusBox.Enabled = false;
                sumBox.Enabled = false;
                firstPoint.Enabled = false;
                finishPoint.Enabled = false;
            }
        }

        public void deleteOrder()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `orders` SET `status` ='отказ'  WHERE `orders`.`id` = @id;";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentOrderId;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ Отменен", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            backForm_Click(new object(), new EventArgs());
        }

        public void setWork()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `orders` SET `user_id` =@user_id, status='в работе'  WHERE `orders`.`id` = @id;";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentOrderId;

            command.Parameters.Add("@user_id", MySqlDbType.VarChar, 30);
            command.Parameters["@user_id"].Value = Store.userId;
            
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ взят в работу", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            backForm_Click(new object(), new EventArgs());
        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (clientBox.Text == "")
            {
                clientError.Visible = true;
                error = true;
            }
            else
            {
                clientError.Visible = false;
            }
            if (statusBox.Text == "")
            {
                statusError.Visible = true;
                error = true;
            }
            else
            {
                statusError.Visible = false;
            }
            if (sumBox.Value < 0)
            {
                sumError.Visible = true;
                error = true;
            }
            else
            {
                sumError.Visible = false;
            }
            if (firstPoint.Text == "")
            {
                firstError.Visible = true;
                error = true;

            }
            else
            {
                firstError.Visible = false;
            }
            if (finishPoint.Text == "")
            {
                finishError.Visible = true;
                error = true;

            }
            else
            {
                finishError.Visible = false;
            }
            if (!error)
            {
                if (Store.currentOrderId != "")
                {
                    saveOrder();

                }
                else {
                    addOrder();
                }
            }
            error = false;
        }

        private void backForm_Click(object sender, EventArgs e)
        {
            Store.currentOrderId = "";
            if (Store.userPost == "администратор")
            {
                Admin newAdmin = new Admin();
                newAdmin.Show();
            } else if (Store.userPost == "диспетчер")
            {
                Operator @operator = new Operator();
                @operator.Show();
            }
            else if (Store.userPost == "водитель")
            {
                Driver driver = new Driver();
                driver.Show();
            }
            Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setWork();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readyOrder();
        }

        public void readyOrder()
        {
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();
            string sql = "UPDATE `orders` SET `status` ='готово'  WHERE `orders`.`id` = @id;";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 30);
            command.Parameters["@id"].Value = Store.currentOrderId;

            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Заказ Завершен", " Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            backForm_Click(new object(), new EventArgs());
        }
    }
   
}
