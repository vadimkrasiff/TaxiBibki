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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void getClients()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select id, last_name, first_name, phone, post, username from users where post IS NULL";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["id"].ToString(),
                    reader.GetString("last_name") + " " + reader.GetString("first_name"),
                    reader["phone"].ToString(),
                    reader["username"].ToString()
                    );
            }
            reader.Close();

            conn.Close();
        }

        private void getOperator()
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select id, last_name, first_name, phone, post, username from users where post='диспетчер'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView2.Rows.Add(
                    reader["id"].ToString(),
                    reader.GetString("last_name") + " " + reader.GetString("first_name"),
                    reader["phone"].ToString(),
                    reader["username"].ToString()
                    );
            }
            reader.Close();

            conn.Close();
        }

        private void getDriver()
        {
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select id, last_name, first_name, phone, post, username from users where post='водитель'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView3.Rows.Add(
                    reader["id"].ToString(),
                    reader.GetString("last_name") + " " + reader.GetString("first_name"),
                    reader["phone"].ToString(),
                    reader["username"].ToString()
                    );
            }
            reader.Close();

            conn.Close();
        }

        private void getOrders()
        {
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "SELECT o.id as id, o.sum as sum, o.date_create as date_create, o.status as status, c.first_name as first_name, c.last_name as last_name  FROM `orders` as o, users as c WHERE o.client_id = c.id;";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView4.Rows.Add(
                    reader["id"].ToString(),
                    reader.GetString("last_name") + " " + reader.GetString("first_name"),
                    reader["date_create"].ToString(),
                    reader["status"].ToString(),
                    reader["sum"].ToString()
                    );
            }
            reader.Close();

            conn.Close();
        }

        private void getShifts()
        {
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "SELECT s.id as id, s.start_date as start_date, s.finish_date as finish_date, c.first_name as first_name, c.post as post, c.last_name as last_name  FROM `shift` as s, users as c WHERE s.user_id = c.id;";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView5.Rows.Add(
                    reader["id"].ToString(),
                    reader.GetString("last_name") + " " + reader.GetString("first_name"),
                    reader["post"].ToString(),
                    reader["start_date"].ToString(),
                    reader["finish_date"].ToString()
                    );
            }
            reader.Close();

            conn.Close();
        }

        private void getCars()
        {
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "select number, mark, color from cars";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView6.Rows.Add(
                    reader["number"].ToString(),
                    reader.GetString("mark"),
                    reader["color"].ToString()
                    );
            }
            reader.Close();

            conn.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            userNameInpit.Text = Store.userName;
            getClients();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                getClients();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                getOperator();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                getDriver();
            }
            if (tabControl1.SelectedIndex == 3)
            {
                getOrders();
            }
            if (tabControl1.SelectedIndex == 4)
            {
                getShifts();
            }
            if (tabControl1.SelectedIndex == 5)
            {
                getCars();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Store.currentClientId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                ClientCard clientCard = new ClientCard();
                clientCard.Show();
                Hide();
            }
        }

        private void createButtonUser_Click(object sender, EventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.Show();
            Hide();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Store.currentClientId = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            OperatorCard operatorCard = new OperatorCard();
            operatorCard.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperatorCard operatorCard = new OperatorCard();
            operatorCard.Show();
            Hide();
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Store.currentClientId = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            DriverCard driverCard = new DriverCard();
            driverCard.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DriverCard driverCard = new DriverCard();
            driverCard.Show();
            Hide();
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Store.currentOrderId = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            Order order = new Order();
            order.Show();
            Hide();

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Store.currentShiftId = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();
            Shift shift= new Shift();
            shift.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shift shift = new Shift();
            shift.Show();
            Hide();
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Store.currentCarId = dataGridView6.Rows[e.RowIndex].Cells[0].Value.ToString();
            CarCard car = new CarCard();
            car.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarCard car = new CarCard();
            car.Show();
            Hide();
        }
    }
}
