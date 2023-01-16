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
    public partial class WriteForm3 : Form
    {
        WriteForm writeForm;

        public WriteForm3(WriteForm writeForm)
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

        private void AddJob_Click(object sender, EventArgs e)
        {
            if (!textBoxSalary.Text.Any() ||  !textBoxName.Text.Any())
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

            decimal salary;
            if (!decimal.TryParse(textBoxSalary.Text.Replace('.', ','), out salary))
            {
                MessageBox.Show("Неверный формат цены блюда!");
                return;
            }


            using (NpgsqlCommand command = new NpgsqlCommand())
            {      
                BD db = new BD();
                db.OpenConnection();
                command.CommandText = "INSERT INTO Должность (название_должности, зарплата) VALUES (@name, @salary)";
                command.Connection = db.GetConnection();
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@salary", salary);

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
