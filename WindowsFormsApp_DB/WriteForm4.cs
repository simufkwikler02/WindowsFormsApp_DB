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
    public partial class WriteForm4 : Form
    {
        WriteForm writeForm;

        public WriteForm4(WriteForm writeForm)
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

        private void AddOrder_Click(object sender, EventArgs e)
        {
            if (ComboBoxOperator.SelectedItem is null || !textBoxSumPrice.Text.Any() || !textBoxTransaction.Text.Any())
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            int transaction;
            if (!int.TryParse(textBoxTransaction.Text, out transaction))
            {
                MessageBox.Show("Неверный формат номера транзакции!");
                return;
            }

            decimal sumPrice;
            if (!decimal.TryParse(textBoxSumPrice.Text.Replace('.', ','), out sumPrice))
            {
                MessageBox.Show("Неверный формат суммы заказа!");
                return;
            }

            var operator_name = ComboBoxOperator.SelectedItem.ToString();

            DataTable dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT номер_транзакции FROM Заказ WHERE номер_транзакции = @transaction LIMIT 1";
                    command.Connection = db.GetConnection();
                    command.Parameters.AddWithValue("@transaction", transaction);
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    db.CloseConnection();
                }
            }

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Заказ с таким номером уже существует!");
                return;
            }

            dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {           
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = $"INSERT INTO Заказ (сумма_заказа, номер_транзакции, оператор_id) VALUES (@sumPrice, @transaction, (SELECT id FROM Сотрудник WHERE фио = @operator_name LIMIT 1))";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@sumPrice", sumPrice);
                command.Parameters.AddWithValue("@transaction", transaction);
                command.Parameters.AddWithValue("@operator_name", operator_name);
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

        private void WriteForm4_Load(object sender, EventArgs e)
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
                ComboBoxOperator.Items.Add(row[0].ToString());
            }
        }
    }
}
