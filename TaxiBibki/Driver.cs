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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            userNameInpit.Text = Store.userName;
            getOrders();
        }

        private void getOrders()
        {
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "SELECT o.id as id, o.sum as sum, o.date_create as date_create, o.status as status, c.first_name as first_name, c.last_name as last_name FROM `orders` as o LEFT JOIN users as c ON o.client_id = c.id WHERE (o.user_id = @user_id AND o.status = 'в работе') OR (o.user_id IS NULL AND o.status = 'оформлено' AND NOT EXISTS ( SELECT 1 FROM `orders` WHERE user_id = @user_id AND status = 'в работе' )) OR (o.user_id IS NOT NULL AND o.status = 'в работе' AND NOT EXISTS ( SELECT 1 FROM `orders` WHERE user_id IS NULL AND status = 'оформлено' ));";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@user_id", MySqlDbType.VarChar, 30);
            command.Parameters["@user_id"].Value = Store.userId;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Store.currentOrderId = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            Order order = new Order();
            order.Show();
            Hide();
        }
    }
}
