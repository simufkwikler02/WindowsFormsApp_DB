using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_DB
{
    public partial class Graph2 : Form
    {
        FormRead formread;
        int numberRoom;
        int maxItem;
        int minItem;

        public Graph2(FormRead formread)
        {
            InitializeComponent();
            this.formread = formread;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formread.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();

            if (!textBox1.Text.Any())
            {
                this.numberRoom = int.MaxValue;
            }
            else
            {
                int number;
                if (!Int32.TryParse(textBox1.Text, out number))
                {
                    MessageBox.Show("Неверный формат количества сотрудников!");
                    return;
                }

                this.numberRoom = number;
            }

            if (!textBox2.Text.Any())
            {
                this.maxItem = int.MaxValue;
            }
            else
            {
                int number;
                if (!Int32.TryParse(textBox2.Text, out number))
                {
                    MessageBox.Show("Неверный формат инвентаря!");
                    return;
                }

                this.maxItem = number;
            }

            if (!textBox3.Text.Any())
            {
                this.minItem = int.MinValue;
            }
            else
            {
                int number;
                if (!Int32.TryParse(textBox3.Text, out number))
                {
                    MessageBox.Show("Неверный формат инвентаря!");
                    return;
                }

                this.minItem = number;
            }

          

            DataTable dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT название_помещения, count(Столовый_инвентарь) FROM Помещение LEFT JOIN Столовый_инвентарь ON Помещение.id = Столовый_инвентарь.помещение_id GROUP BY Помещение.id HAVING count(Столовый_инвентарь) <= @maxItem and count(Столовый_инвентарь) >= @minItem ORDER BY count(Столовый_инвентарь) DESC LIMIT @numberRoom";
                    command.Connection = db.GetConnection();
                    command.Parameters.AddWithValue("@maxItem", maxItem);
                    command.Parameters.AddWithValue("@minItem", minItem);
                    command.Parameters.AddWithValue("@numberRoom", numberRoom);
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    db.CloseConnection();
                }
            }


            foreach (DataRow row in dt.Rows)
            {
                var cells = row.ItemArray;
                this.chart1.Series[0].Points.AddXY(cells[0], cells[1]);

                foreach (object cell in cells)
                {
                    Console.Write("\t{0}", cell);
                }

                Console.WriteLine();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }
    }
}
