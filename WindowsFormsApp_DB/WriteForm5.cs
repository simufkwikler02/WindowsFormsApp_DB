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
    public partial class WriteForm5 : Form
    {
        WriteForm writeForm;

        public WriteForm5(WriteForm writeForm)
        {
            InitializeComponent();
            this.writeForm = writeForm;
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            writeForm.Show();
            this.Close();
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            if (!textBoxDateCleaning.Text.Any() || !textBoxName.Text.Any())
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var name = textBoxName.Text;
            if (name.Length > 200)
            {
                MessageBox.Show("Неверный формат названия помещения!");
                return;
            }

            DateTime date;
            if (!DateTime.TryParse(textBoxDateCleaning.Text, out date))
            {
                MessageBox.Show("Неверный формат даты уборки!");
                return;
            }

            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = "INSERT INTO Помещение (название_помещения, дата_последней_уборки) VALUES (@name, @date)";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@date", date);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!");
                }
                catch
                {
                    MessageBox.Show("Ошибка запроса");
                }

                db.CloseConnection();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
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
    }
}
