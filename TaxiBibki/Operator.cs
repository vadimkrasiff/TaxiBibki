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
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
        }

        

        private void Operator_Load(object sender, EventArgs e)
        {
            userNameInpit.Text = Store.userName;
            getOrders("заявка");
        }

        private void getOrders(string status)
        {
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.Rows.Clear();
            MySqlConnection conn = MySQL.getConnection();
            conn.Open();

            string sql = "SELECT o.id as id, o.sum as sum, o.date_create as date_create, o.status as status, c.first_name as first_name, c.last_name as last_name  FROM `orders` as o, users as c WHERE o.client_id = c.id and o.status=@status;";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@status", MySqlDbType.VarChar, 30);
            command.Parameters["@status"].Value = status;
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

        private void button2_Click(object sender, EventArgs e)
        {
            getOrders("заявка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getOrders("оформлено");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getOrders("в работе");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getOrders("готово");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getOrders("отказ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
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
