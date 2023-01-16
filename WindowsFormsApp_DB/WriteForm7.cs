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
    public partial class WriteForm7 : Form
    {
        WriteForm writeForm;
        Point lastPoint;

        public WriteForm7(WriteForm writeForm)
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

        private void AddToOrder_Click(object sender, EventArgs e)
        {
            if (ComboBoxDish.SelectedItem is null || !textBoxNumber.Text.Any() || ComboBoxOrder.SelectedItem is null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            int number;
            if (!int.TryParse(textBoxNumber.Text, out number))
            {
                MessageBox.Show("Неверный формат количества блюд!");
                return;
            }

            int order;
            if (!int.TryParse(ComboBoxOrder.SelectedItem.ToString(), out order))
            {
                MessageBox.Show("Неверный формат номера транзакции!");
                return;
            }

            var dish_name = ComboBoxDish.SelectedItem.ToString();

            using (NpgsqlCommand command = new NpgsqlCommand())
            {              
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = "INSERT INTO Состав_заказа (заказ_id, блюдо_id, количество_порций) VALUES ((SELECT id FROM Заказ WHERE номер_транзакции = @order LIMIT 1), (SELECT id FROM Блюдо WHERE название_блюда = @dish_name LIMIT 1), @number)";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@order", order);
                command.Parameters.AddWithValue("@dish_name", dish_name);
                command.Parameters.AddWithValue("@number", number);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Блюдо добавлено к заказу!");
                }
                catch
                {
                    MessageBox.Show("Ошибка запроса");
                }

                db.CloseConnection();             
            }
        }

        private void WriteForm7_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT номер_транзакции FROM Заказ";
                    command.Connection = db.GetConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    db.CloseConnection();
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                ComboBoxOrder.Items.Add(row[0]);
            }

            dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT название_блюда FROM Блюдо";
                    command.Connection = db.GetConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    db.CloseConnection();
                }
            }
            
            foreach (DataRow row in dt.Rows)
            {
                ComboBoxDish.Items.Add(row[0].ToString());
            }
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
    }
}
