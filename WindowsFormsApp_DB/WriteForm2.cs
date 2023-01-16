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
    public partial class WriteForm2 : Form
    {
        WriteForm writeForm;

        public WriteForm2(WriteForm writeForm)
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

        private void AddDish_Click_1(object sender, EventArgs e)
        {
            if (ComboBoxAuthor.SelectedItem is null || !textBoxCompound.Text.Any() || !textBoxName.Text.Any() || !textBoxPrice.Text.Any() || !textBoxWeight.Text.Any())
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var name = textBoxName.Text;
            if (name.Length > 100)
            {
                MessageBox.Show("Неверный формат названия блюда!");
                return;
            }

            decimal price;
            if (!decimal.TryParse(textBoxPrice.Text.Replace('.',','), out price))
            {
                MessageBox.Show("Неверный формат цены блюда!");
                return;
            }

            decimal weight;
            if (!decimal.TryParse(textBoxWeight.Text.Replace('.', ','), out weight))
            {
                MessageBox.Show("Неверный формат веса блюда!");
                return;
            }

            var compound = textBoxCompound.Text;
            if (compound.Length > 300)
            {
                MessageBox.Show("Неверный формат состава блюда!");
                return;
            }

            var author_name = ComboBoxAuthor.SelectedItem.ToString();

            using (NpgsqlCommand command = new NpgsqlCommand())
            {       
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = "INSERT INTO Блюдо (название_блюда, цена_блюда, вес_блюда, состав_блюда, автор_id) VALUES (@name,@price,@weight,@compound,(SELECT id FROM Сотрудник WHERE фио = @author_name LIMIT 1))";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@weight", weight);
                command.Parameters.AddWithValue("@compound", compound);
                command.Parameters.AddWithValue("@author_name", author_name);

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

        private void WriteForm2_Load(object sender, EventArgs e)
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
                ComboBoxAuthor.Items.Add(row[0].ToString());
            }
        }
    }
}
