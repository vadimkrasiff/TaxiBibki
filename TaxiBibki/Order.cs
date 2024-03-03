using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaxiBibki
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        PointLatLng startPoint;
        PointLatLng endPoint;
        PointLatLng currentPoint;
        GMapControl map = new GMapControl();

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

        private void Order_Load(object sender, EventArgs e)
        {
            
            map.Dock = DockStyle.Fill;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(55.7558, 37.6173); // Москва
            map.Zoom = 12;

            this.Controls.Add(map);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Получение координат из textBox1 и textBox2
            startPoint = new PointLatLng(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            endPoint = new PointLatLng(double.Parse(textBox2.Text), double.Parse(textBox1.Text));

            // Определение маршрута
            GMapRoute route = GMapRouteProvider.Directions(map, startPoint, endPoint, false, false, 15);

            // Добавление маршрута на карту
            GMapOverlay overlay = new GMapOverlay(map);
            overlay.Routes.Add(route);
            map.Overlays.Add(overlay);
        }
    }
}
