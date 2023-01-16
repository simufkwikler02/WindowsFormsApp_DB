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
    public partial class WriteForm6 : Form
    {
        WriteForm writeForm;

        public WriteForm6(WriteForm writeForm)
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

        private void AddRoom_Click(object sender, EventArgs e)
        {
            if (!textBoxDate.Text.Any() || !textBoxName.Text.Any() || ComboBoxRoom.SelectedItem is null || !textBoxRules.Text.Any())
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var name = textBoxName.Text;
            if (name.Length > 200)
            {
                MessageBox.Show("Неверный формат названия столового инвенторя!");
                return;
            }

            DateTime date;
            if (!DateTime.TryParse(textBoxDate.Text, out date))
            {
                MessageBox.Show("Неверный формат даты ввода в эксплуатацию!");
                return;
            }

            var rules = textBoxRules.Text;
            var room_name = ComboBoxRoom.SelectedItem.ToString();

            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = $"INSERT INTO Столовый_инвентарь (название_столового_инвентаря, дата_ввода_в_эксплуатацию, правила_эксплуатации, помещение_id) VALUES (@name,@date,@rules,(SELECT id FROM Помещение WHERE название_помещения = @room_name LIMIT 1))";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@rules", rules);
                command.Parameters.AddWithValue("@room_name", room_name);
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

        private void WriteForm6_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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
