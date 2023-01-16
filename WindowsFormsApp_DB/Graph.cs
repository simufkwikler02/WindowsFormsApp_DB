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
    public partial class Graph : Form
    {
        FormRead formread;
        int numberEmployee;
        int maxSalary;
        int minSalary;

        public Graph(FormRead formread)
        {
            InitializeComponent();
            this.formread = formread;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();


            if (!textBox1.Text.Any())
            {
                this.numberEmployee = int.MaxValue;
            }
            else
            {
                int number;
                if (!Int32.TryParse(textBox1.Text, out number))
                {
                    MessageBox.Show("Неверный формат количества сотрудников!");
                    return;
                }

                this.numberEmployee = number;
            }

            if (!textBox2.Text.Any())
            {
                this.maxSalary = int.MaxValue;
            }
            else
            {
                int number;
                if (!Int32.TryParse(textBox2.Text, out number))
                {
                    MessageBox.Show("Неверный формат зарплаты!");
                    return;
                }

                this.maxSalary = number;
            }

            if (!textBox3.Text.Any())
            {
                this.minSalary = int.MinValue;
            }
            else
            {
                int number;
                if (!Int32.TryParse(textBox3.Text, out number))
                {
                    MessageBox.Show("Неверный формат зарплаты!");
                    return;
                }

                this.minSalary = number;
            }

            DataTable dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT фио, зарплата FROM Сотрудник LEFT JOIN Должность ON Сотрудник.должность_id = Должность.id WHERE зарплата <= @maxSalary and зарплата >= @minSalary ORDER BY зарплата DESC LIMIT @numberEmployee";
                    command.Connection = db.GetConnection();
                    command.Parameters.AddWithValue("@maxSalary", maxSalary);
                    command.Parameters.AddWithValue("@minSalary", minSalary);
                    command.Parameters.AddWithValue("@numberEmployee", numberEmployee);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formread.Show();
            this.Close();
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
