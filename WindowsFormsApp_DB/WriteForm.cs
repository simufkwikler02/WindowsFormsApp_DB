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
    public partial class WriteForm : Form
    {
        Form1 mainForm;

        public WriteForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
            this.Close();
        }

        private void query1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm1 writeForm1 = new WriteForm1(this);
            writeForm1.Show();
        }

        private void query2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm2 writeForm2 = new WriteForm2(this);
            writeForm2.Show();
        }

        private void query3_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm3 writeForm3 = new WriteForm3(this);
            writeForm3.Show();
        }

        private void query4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm4 writeForm4 = new WriteForm4(this);
            writeForm4.Show();
        }

        private void query5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm5 writeForm5 = new WriteForm5(this);
            writeForm5.Show();
        }

        private void query6_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm6 writeForm6 = new WriteForm6(this);
            writeForm6.Show();
        }

        private void query7_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm7 writeForm7 = new WriteForm7(this);
            writeForm7.Show();
        }

        private void query8_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteForm8 writeForm8 = new WriteForm8(this);
            writeForm8.Show();
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
