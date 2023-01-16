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
    public partial class WriteForm1 : Form
    {
        WriteForm writeForm;

        public WriteForm1(WriteForm writeForm)
        {
            InitializeComponent();
            this.writeForm = writeForm;
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            if (!textBoxFIO.Text.Any() || !textBoxDateOfBirth.Text.Any() || ComboBoxJob.SelectedItem is null || !textBoxPass.Text.Any() || !textBoxTel.Text.Any())
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var name = textBoxFIO.Text;
            if (name.Length > 200)
            {
                MessageBox.Show("Неверный формат фио!");
                return;
            }

            DateTime date;
            if (!DateTime.TryParse(textBoxDateOfBirth.Text, out date))
            {
                MessageBox.Show("Неверный формат даты!");
                return;
            }

            var phoneNumber = textBoxTel.Text;
            foreach(var sim in phoneNumber)
            {
                if ((!char.IsNumber(sim) && !sim.Equals('+')) || phoneNumber.Length > 30)
                {
                    MessageBox.Show("Неверный формат номера телефона!");
                    return;
                }
            }

            var passport = textBoxPass.Text;         
            var jobName = ComboBoxJob.SelectedItem.ToString();

            using (NpgsqlCommand command = new NpgsqlCommand())
            {               
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = "INSERT INTO Сотрудник (фио, дата_рождения, телефон, №_паспорта, должность_id) VALUES (@name, @date, @phoneNumber, @passport, (SELECT id FROM Должность WHERE название_должности = @jobName LIMIT 1))";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@passport", passport);
                command.Parameters.AddWithValue("@jobName", jobName);

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

        private void WriteForm1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter())
                {
                    BD db = new BD();
                    db.OpenConnection();
                    command.CommandText = "SELECT название_должности FROM Должность";
                    command.Connection = db.GetConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    db.CloseConnection();
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                ComboBoxJob.Items.Add(row[0].ToString());
            }
        }
    }
}
