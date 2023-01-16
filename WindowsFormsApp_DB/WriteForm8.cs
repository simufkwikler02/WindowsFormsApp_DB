using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_DB
{
    public partial class WriteForm8 : Form
    {
        WriteForm writeForm;
        Point lastPoint;

        public WriteForm8(WriteForm writeForm)
        {
            InitializeComponent();
            this.writeForm = writeForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            writeForm.Show();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void namebd_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void namebd_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        private void AddRespond_Click(object sender, EventArgs e)
        {
            if (ComboBoxRoom.SelectedItem is null || !textBoxRespond.Text.Any() || ComboBoxEmployee.SelectedItem is null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var room_name = ComboBoxRoom.SelectedItem.ToString();
            var employee_name = ComboBoxEmployee.SelectedItem.ToString();
            var respond = textBoxRespond.Text;

            using (NpgsqlCommand command = new NpgsqlCommand())
            {         
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = $"INSERT INTO Рабочая_смена (сотрудник_id, помещение_id, обязанности) VALUES ((SELECT id FROM Сотрудник WHERE фио = @employee_name LIMIT 1), (SELECT id FROM Помещение WHERE название_помещения = @room_name LIMIT 1), @respond)";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@employee_name", employee_name);
                command.Parameters.AddWithValue("@room_name", room_name);
                command.Parameters.AddWithValue("@respond", respond);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Обязанность добавлена сотруднику!");
                }
                catch
                {
                    MessageBox.Show("Ошибка запроса");
                }

                db.CloseConnection();               
            }
        }

        private void WriteForm8_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT фио FROM Сотрудник";
                    command.Connection = db.GetConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    db.CloseConnection();
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                ComboBoxEmployee.Items.Add(row[0]);
            }

            dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT название_помещения FROM Помещение";
                    command.Connection = db.GetConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    db.CloseConnection();
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                ComboBoxRoom.Items.Add(row[0].ToString());
            }
        }
    }
}
