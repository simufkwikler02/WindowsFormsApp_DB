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
    public partial class FormRead : Form
    {
        Form1 mainForm;

        public FormRead(Form1 mainForm)
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
            Graph graph = new Graph(this);
            graph.Show();
        }

        private void query2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph2 graph2 = new Graph2(this);
            graph2.Show();
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
